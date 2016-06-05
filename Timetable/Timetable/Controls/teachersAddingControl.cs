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
	public partial class TeachersAddingControl : UserControl
	{
        public DataSet setDataSet
        {
            set
            {
                this.dataSet = value;
                LoadData();
            }
        }

        public TeachersAddingControl()
        {
            InitializeComponent();
        }

        //Ustawianie źródeł danych dla dataGridView
        private void LoadData()
        {
            this.teachersDataGridView.DataSource = this.dataSet;
            this.teachersBindingSource.DataSource = this.dataSet.teachers;
            this.teachersDataGridView.DataSource = this.teachersBindingSource;
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            if (teachersDataGridView.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show(ViewConstants.DELETE_SELECTED_ROWS_WARNING, ViewConstants.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            foreach (DataGridViewRow row in teachersDataGridView.SelectedRows)
            {
                BindingSource bs = teachersDataGridView.DataSource as BindingSource;
                bs.RemoveAt(row.Index);
            }
        }
    }
}
