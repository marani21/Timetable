using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
	public partial class SubjectsAssigningForm : Form
	{
		public static event EventDelegate closeFormEvent;

		public SubjectsAssigningForm()
		{
			InitializeComponent();
		}


		private void itemAssignSubjects_Click(object sender, EventArgs e)
		{

		}

        private void subjectsAddingControl_Load(object sender, EventArgs e)
        {
            //subjectsTableAdapter1.Fill(dataSet.subjects);

            //foreach (DataRow dataRow in dataSet.subjects)
            //{
            //    this.subjectsAddingControl.ComboBoxGet.Items.Add(dataRow.ItemArray[1].ToString());
            //}
        }
        private void updateTableAdapters(object sender, EventArgs e)
        {
            subjectAssigningControl.updateTableAdapters();
            subjectsAddingControl.updateTableAdapters();

        }

		private void buttonOK_Click(object sender, EventArgs e)
		{
			// wywołanie TableAdapter.Update() a właściwie kilku TableAdapterów (students, teachers, subjects, teaching)

			this.DialogResult = DialogResult.OK;
			this.Close();
			if (closeFormEvent != null)
			{
				closeFormEvent();
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
			if (closeFormEvent != null)
			{
				closeFormEvent();
			}
		}

		private void SubjectsAssigningForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// jeśli forma nie została zamknięta poprzez "OK" , czyli zostało kliknięte "X" lub "Anuluj"
			if(this.DialogResult == DialogResult.Cancel)
            {
				//MessageBox.Show("X lub Anuluj");

				// przywróć DataSet sprzed zmian (np. utwórz nowy) - brak jakiegokolwiek połączenia z bazą, bo wszystkie zmiany, 
				//których właśnie dokonaliśmy w DataSecie chcemy cofnąć
			}
		}

	
	}
}
