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
	public delegate void EventDelegate();

	public partial class ChoiceForm : Form
	{
		SchedulesViewingForm schedulesViewingForm;
		ScheduleCreationForm scheduleCreationForm;
		SubjectsAssigningForm subjectAssigningForm;

		public ChoiceForm()
		{
			InitializeComponent();
			SchedulesViewingForm.closeFormEvent += SchedulesViewingForm_closeFormEvent;
			ScheduleCreationForm.closeFormEvent += ScheduleCreationForm_closeFormEvent;
			SubjectsAssigningForm.closeFormEvent += SubjectsAssigningForm_closeFormEvent;

		}

		private void SchedulesViewingForm_closeFormEvent()
		{
			this.Show();
		}

		private void ScheduleCreationForm_closeFormEvent()
		{
			this.Show();
		}
        
		private void SubjectsAssigningForm_closeFormEvent()
		{
			this.Show();
		}

		private void buttonViewSchedules_Click(object sender, EventArgs e)
		{
			schedulesViewingForm = new SchedulesViewingForm();
			this.Hide();
			schedulesViewingForm.Show();
		}

		private void buttonCreateSchedules_Click(object sender, EventArgs e)
		{
			scheduleCreationForm = new ScheduleCreationForm();
			this.Hide();
			scheduleCreationForm.Show();
		}

		private void buttonAssignSubjects_Click(object sender, EventArgs e)
		{
			subjectAssigningForm = new SubjectsAssigningForm();
			this.Hide();
			subjectAssigningForm.Show();
		}
	}
}