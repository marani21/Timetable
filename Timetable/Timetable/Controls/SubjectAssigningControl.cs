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

        public void updateTableAdapters()
        {
            this.classesTableAdapter.Update(this.dataSet.classes);
            this.subjectsTableAdapter.Update(this.dataSet.subjects);
            this.teachersTableAdapter.Update(this.dataSet.teachers);
            this.teachingTableAdapter.Update(this.dataSet.teaching);

        }
        private void SubjectAssigningControl_Load(object sender, EventArgs e)
        {
            this.amountDataGridViewTextBoxColumn.ValueType = typeof(int);
            this.classesTableAdapter.Fill(this.dataSet.classes);
            this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            this.teachersTableAdapter.Fill(this.dataSet.teachers);
            if(this.dataSet.subjects.Count != 0)
               teachingBindingSource.Filter = "class ='" + comboBoxClasses.SelectedValue.ToString() + "'";

            // teacherDataGridViewTextBoxColumn.ValueType = typeof(teacherDataGridViewTextBoxColumn.ValueMember);
            this.teachingTableAdapter.Fill(this.dataSet.teaching);
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            teachingBindingSource.Filter = "class ='" + comboBoxClasses.SelectedValue.ToString() + "'";
            this.teachingTableAdapter.Fill(this.dataSet.teaching);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet changes = dataSet.GetChanges() as DataSet;
                if(changes != null)
                {
                    this.teachingTableAdapter.Update(this.dataSet.teaching);
                    this.teachingTableAdapter.Fill(this.dataSet.teaching);
                    this.dataSet.AcceptChanges();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            this.teachingTableAdapter.Update(this.dataSet.teaching);
        }
    }
}
