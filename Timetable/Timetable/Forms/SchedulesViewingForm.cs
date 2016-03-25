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
	public partial class SchedulesViewingForm : Form
	{
		public static event EventDelegate closeFormEvent;

		public SchedulesViewingForm()
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

		private void SchedulesViewingForm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet.students' table. You can move, or remove it, as needed.
			this.studentsTableAdapter.Fill(this.dataSet.students);
			// TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
			this.classesTableAdapter.Fill(this.dataSet.classes);

		}
	}
}
