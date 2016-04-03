using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable.Controls;

namespace Timetable.Forms
{
	public partial class ScheduleCreationFormExt : Form
	{
		public ScheduleCreationFormExt()
		{
			InitializeComponent();
			CellControl.CellClickEvent += CellControl_CellClickEvent;
		}

		private void CellControl_CellClickEvent(string controlName)
		{
			CellControl cell = this.Controls.Find(controlName, true).FirstOrDefault() as CellControl;
			
			foreach(Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
			{
				if(c is CellControl)
					c.BackColor = SystemColors.ControlLight;
			}

			cell.BackColor = Color.Bisque;
		}
	}
}
