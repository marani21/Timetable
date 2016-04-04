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

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.Hide();
			if (closeFormEvent != null)
			{
				closeFormEvent();
			}
		}

		private void itemAssignSubjects_Click(object sender, EventArgs e)
		{

		}

		
	}
}