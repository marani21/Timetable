﻿using System;
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



        private void subjectsAddingControl_Load(object sender, EventArgs e)
        {
            subjectsAddingControl.setDataSet = this.dataSet;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zapisać wszystkie dokonane zmiany w bazie?", "Ostrzeżenie",
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
			// jeśli forma nie została zamknięta poprzez "OK" , czyli zostało kliknięte "X" lub "Anuluj"
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
            this.subjectsTableAdapter1.Fill(this.dataSet.subjects);
            this.studentsTableAdapter1.Fill(this.dataSet.students);
            this.teachersTableAdapter1.Fill(this.dataSet.teachers);
            this.teachingTableAdapter1.Fill(this.dataSet.teaching);
            this.classesTableAdapter1.Fill(this.dataSet.classes);
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
				MessageBox.Show(ex.ToString());
			}
		}

		private void switchToAnotherForm()
		{
			if (MessageBox.Show("Czy chcesz zapisać wszystkie dokonane zmiany w bazie?", "Ostrzeżenie",
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
	}
}
