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
	public delegate void EventFormDelegate(Form newForm, Form oldForm);

	public partial class ChoiceForm : Form
	{
		SchedulesViewingForm schedulesViewingForm;
		DataAddingForm subjectAssigningForm;
		Forms.ScheduleCreationFormExt scheduleCreationFormExt;

		// Konstruktor
		public ChoiceForm()
		{
			InitializeComponent();
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
