using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable.Controls
{
	public delegate void MyDelegate(string controlName);

	public partial class CellControl : UserControl
	{
		static public event MyDelegate CellClickEvent;

		public CellControl()
		{
			InitializeComponent();
		}

		private void CellControl_Click(object sender, EventArgs e)
		{
			CellClickEvent(this.Name);
		}

		private void labelSubject_Click(object sender, EventArgs e)
		{
			CellClickEvent(this.Name);
		}

		private void labelTeacher_Click(object sender, EventArgs e)
		{
			CellClickEvent(this.Name);
		}

		private void labelClassroom_Click(object sender, EventArgs e)
		{
			CellClickEvent(this.Name);
		}
	}
}
