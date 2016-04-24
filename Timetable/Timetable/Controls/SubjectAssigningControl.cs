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
                       
        }
        //Ustawianie źródeł danych dla dataGridView oraz combobox'a

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
        //filtrowanie wyświetlanych danych w DataGridView po zmianie klasy w combobox'ie
        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.teachingBindingSource.Filter = "class ='" + comboBoxClasses.SelectedValue.ToString() + "'";
           
        }

        //domyślna wartość klasy taka jak wybrana w comboboxie
        private void dataGridViewDefaultValues(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dataGridViewTextBoxColumn1"].Value = comboBoxClasses.SelectedValue.ToString();
        }
        //usuwanie rekordów
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssigning.SelectedRows.Count == 0)
                return;
            if (MessageBox.Show(ViewConstants.DELETE_SELECTED_ROWS_WARNING, ViewConstants.WARNING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridViewAssigning.SelectedRows)
            {
                BindingSource mBindingSource = dataGridViewAssigning.DataSource as BindingSource;
                mBindingSource.RemoveAt(row.Index);
            }
            
            

        }
        //uniemożliwienie wpisania innych wartości niż naturalne dla liczby godzin
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
        //usunięcie filtra i ponowne wczytanie danych; pomocne gdy zmieniamy zakładki
        public void clearFilter()
        {
            teachingBindingSource.RemoveFilter();
            LoadData();           
        }

        private void dataGridViewAssigning_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataAddingForm.createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_EDITING_DATA, e.Exception.ToString());

        }
    }
}
