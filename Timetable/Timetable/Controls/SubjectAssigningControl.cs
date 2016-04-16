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
	public partial class SubjectAssigningControl : UserControl
	{
        
        public SubjectAssigningControl()
		{
			InitializeComponent();

        }

        public DataSet setDataSet
        {
            set
            {
                this.dataSet = value;
                LoadData();
                
            }
            get { return this.dataSet; }
            
        }

        private void LoadData()
        {
            this.dataGridViewAssigning.DataSource = this.dataSet;
            
            this.classesBindingSource.DataSource = this.dataSet.classes;
            this.teachingBindingSource.DataSource = this.dataSet.teaching;
            this.subjectsBindingSource.DataSource = this.dataSet.subjects;
            this.teachersBindingSource.DataSource = this.dataSet.teachers;
            this.dataGridViewAssigning.DataSource = this.teachingBindingSource;
            this.comboBoxClasses.DataSource = this.classesBindingSource;                      
           
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.teachingBindingSource.Filter = "class ='" + comboBoxClasses.SelectedValue.ToString() + "'";
           
        }

        private void SubjectAssigningControl_Load(object sender, EventArgs e)
        {
            //teachingBindingSource.Filter = "class ='" + comboBoxClasses.SelectedValue.ToString() + "'";
            //this.teachingTableAdapter.Fill(this.dataSet.teaching);

        }


        private void dataGridViewDefaultValues(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn1"].Value = comboBoxClasses.SelectedValue.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssigning.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone pola?", "Ostrzeżenie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridViewAssigning.SelectedRows)
            {
                BindingSource mBindingSource = dataGridViewAssigning.DataSource as BindingSource;
                mBindingSource.RemoveAt(row.Index);
            }
            this.dataSet.AcceptChanges();
            

        }

        private void dataGridViewAssigning_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(amount_KeyPressed);
            if(dataGridViewAssigning.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if(tb!=null)
                {
                    tb.KeyPress += new KeyPressEventHandler(amount_KeyPressed);
                }
            }
        }
        private void amount_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void clearFilter()
        {
            teachingBindingSource.RemoveFilter();
            LoadData();           
        }

    }
}
