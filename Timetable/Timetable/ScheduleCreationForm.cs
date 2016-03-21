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
	public partial class ScheduleCreationForm: Form
	{
		public static event EventDelegate closeFormEvent;

		public ScheduleCreationForm()
		{
			InitializeComponent();
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Zamykam...");
			this.Hide();
			if(closeFormEvent!=null)
			{
				closeFormEvent();
			}
		}
	}
}
