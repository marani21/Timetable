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
	public delegate void EventDelegate();

	public partial class ChoiceForm : Form
	{
		SchedulesViewingForm schedulesViewingForm;
		DataAddingForm subjectAssigningForm;
		Forms.ScheduleCreationFormExt scheduleCreationFormExt;

		// Konstruktor
		public ChoiceForm()
		{
			InitializeComponent();
			SchedulesViewingForm.closeFormEvent += SchedulesViewingForm_closeFormEvent;
			ScheduleCreationForm.closeFormEvent += ScheduleCreationForm_closeFormEvent;
			DataAddingForm.closeFormEvent += SubjectsAssigningForm_closeFormEvent;

		}

		private void SchedulesViewingForm_closeFormEvent()
		{
			
		}

		private void ScheduleCreationForm_closeFormEvent()
		{
		
		}
		
		private void SubjectsAssigningForm_closeFormEvent()
		{
		
		}

		//Kliknięcie na button "Przeglądaj plany"
		private void buttonViewSchedules_Click(object sender, EventArgs e)
		{
			// Otwarcie nowej formy w trybie "ShowDialog"
			schedulesViewingForm = new SchedulesViewingForm();
			schedulesViewingForm.ShowDialog();
		}

		//Kliknięcie na button "Ułóż plan"
		private void buttonCreateSchedules_Click(object sender, EventArgs e)
		{
			// Otwarcie nowej formy w trybie "ShowDialog"
			scheduleCreationFormExt = new Forms.ScheduleCreationFormExt();
			scheduleCreationFormExt.ShowDialog();
		}

		//Kliknięcie na button "Dodaj dane do bazy"
		private void buttonAssignSubjects_Click(object sender, EventArgs e)
		{
			// Otwarcie nowej formy w trybie "ShowDialog"
			subjectAssigningForm = new DataAddingForm();
			subjectAssigningForm.ShowDialog();
		}
	}
}
