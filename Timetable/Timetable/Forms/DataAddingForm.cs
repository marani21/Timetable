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
	public partial class DataAddingForm : Form
	{
        public static event EventDelegate closeFormEvent;

		public DataAddingForm()
		{
			InitializeComponent();
		}



        private void subjectsAddingControl_Load(object sender, EventArgs e)
        {
            subjectsAddingControl.setDataSet = this.dataSet;
        }

		// Kliknięcie buttona "Anuluj"
        private void buttonOK_Click(object sender, EventArgs e)
        {
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		// Kliknięcie buttona "OK"
		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Zamykanie formy (event)
		private void SubjectsAssigningForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			// jeśli zostało kliknięte "X", "Anuluj" lub przełączenie na inną formę
			if (this.DialogResult == DialogResult.Cancel && dataSet.GetChanges() != null)
			{
				// Ostrzeżenie - pytanie, czy zapisać zmiany w bazie
				// Jeśli tak
				if (MessageBox.Show(ViewConstants.SAVE_CHANGES_QUESTION, "Ostrzeżenie", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
				{
					// Zapisanie do bazy tabeli lessons
					upadateDataToDataBase();
				}
			}
			else if (this.DialogResult == DialogResult.OK)
			{
				// Zapisanie do bazy tabeli lessons
				upadateDataToDataBase();
			}

			// W przypadku nieoczekiwanego zamknięcia formy (całej aplikacji, nie przez użytkownika)
			if (e.CloseReason == CloseReason.TaskManagerClosing || e.CloseReason == CloseReason.WindowsShutDown || e.CloseReason == CloseReason.None)
			{
				// Zapisanie do bazy tabeli lessons
				upadateDataToDataBase();
			}
		}

        private void subjectAssigningControl_Load(object sender, EventArgs e)
        {
            subjectAssigningControl.setDataSet = this.dataSet;
        }

        private void SubjectsAssigningForm_Load(object sender, EventArgs e)
        {
            try {
                this.subjectsTableAdapter1.Fill(this.dataSet.subjects);
                this.studentsTableAdapter1.Fill(this.dataSet.students);
                this.teachersTableAdapter1.Fill(this.dataSet.teachers);
                this.teachingTableAdapter1.Fill(this.dataSet.teaching);
                this.classesTableAdapter1.Fill(this.dataSet.classes);
            }
            catch(Exception ex)
            {
                createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_GETTING_DATA_FROM_DB, ex.ToString());

            }
        }

        private void updateData(object sender, EventArgs e)
        {
            subjectAssigningControl.clearFilter();
        }

		private void upadateDataToDataBase()
		{
			try
			{
				DataSet changes = this.dataSet.GetChanges() as DataSet;
				if (changes != null)
				{
					this.teachingTableAdapter1.Update(this.dataSet.teaching);
					this.classesTableAdapter1.Update(this.dataSet.classes);
					this.subjectsTableAdapter1.Update(this.dataSet.subjects);
					this.studentsTableAdapter1.Update(this.dataSet.students);
					this.teachersTableAdapter1.Update(this.dataSet.teachers);
				}

			}
			catch (Exception ex)
			{
                createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_UPDATING_DATA_TO_DB, ex.ToString());
			}
		}

		// Pokazanie okna dialogowego w przypadku wystąpienia błędu (np. nie wszystkie pola rekordu zostały wypełnione)
        public static void createDialogWithExceptionMessage(String tittle, String error, String exeptionDetails)
        {
            var dialogTypeName = "System.Windows.Forms.PropertyGridInternal.GridErrorDlg";
            var dialogType = typeof(Form).Assembly.GetType(dialogTypeName);
            var dialog = (Form)Activator.CreateInstance(dialogType, new PropertyGrid());
            //
            dialog.Text = tittle;
            dialogType.GetProperty("Details").SetValue(dialog, exeptionDetails, null);
            dialogType.GetProperty("Message").SetValue(dialog, error, null);

            var result = dialog.ShowDialog();
        }
	}
}
