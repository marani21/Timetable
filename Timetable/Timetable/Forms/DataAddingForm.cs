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


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(ViewConstants.CONFIRM_SAVING_TO_DB, ViewConstants.WARNING,
               MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;

			upadateDataToDataBase();
        
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
			// jeśli forma nie została zamknięta poprzez "OK" , czyli zostało kliknięte "X" lub "Anuluj".
			if(this.DialogResult == DialogResult.Cancel)
            {
				//MessageBox.Show("X lub Anuluj");

				// przywróć DataSet sprzed zmian (np. utwórz nowy) - brak jakiegokolwiek połączenia z bazą, bo wszystkie zmiany, 
				//których właśnie dokonaliśmy w DataSecie chcemy cofnąć
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

		private void studentsAddingControl_Load(object sender, EventArgs e)
		{

		}

		private void itemAssignSubjects_Click(object sender, EventArgs e)
		{
			switchToAnotherForm();
		}

		private void itemCreateSchedule_Click(object sender, EventArgs e)
		{
			switchToAnotherForm();
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

		private void switchToAnotherForm()
		{
			if (MessageBox.Show(ViewConstants.CONFIRM_SAVING_TO_DB, ViewConstants.WARNING,
			MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
			{
				this.DialogResult = DialogResult.Cancel;
			}
			else
			{
				upadateDataToDataBase();

				this.DialogResult = DialogResult.OK;
			}

			this.Close();
			if (closeFormEvent != null)
			{
				closeFormEvent();
			}
		}

		private void itemMenu_Click(object sender, EventArgs e)
		{

		}

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
