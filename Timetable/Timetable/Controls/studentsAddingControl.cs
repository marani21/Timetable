using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
	public partial class StudentsAddingControl : UserControl
	{
        public DataSet setDataSet
        {
            set
            {
                this.dataSet = value;
                LoadData();
            }
        }

        public StudentsAddingControl()
        {
            InitializeComponent();
        }

        //Ustawianie źródeł danych dla dataGridView
        private void LoadData()
        {
            this.studentsDataGridView.DataSource = this.dataSet;
            this.studentsBindingSource.DataSource = this.dataSet.students;
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show(ViewConstants.DELETE_SELECTED_ROWS_WARNING, ViewConstants.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            foreach (DataGridViewRow row in studentsDataGridView.SelectedRows)
            {
                BindingSource bs = studentsDataGridView.DataSource as BindingSource;
                bs.RemoveAt(row.Index);
            }
        }
    }
}
