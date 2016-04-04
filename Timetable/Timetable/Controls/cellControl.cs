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

        public string Subject { get { return this.labelSubject.Text; } set { this.labelSubject.Text = value; } }
        public string Teacher { get { return this.labelTeacher.Text; } set { this.labelTeacher.Text = value; } }
        public string Classroom { get { return this.labelClassroom.Text; } set { this.labelClassroom.Text = value; } }


		public CellControl()
		{
			InitializeComponent();
		}

		private void CellControl_Click(object sender, EventArgs e)
		{
			if(CellClickEvent != null)
                CellClickEvent(this.Name);
		}

		private void labelSubject_Click(object sender, EventArgs e)
		{
            if (CellClickEvent != null)
                CellClickEvent(this.Name);
		}

		private void labelTeacher_Click(object sender, EventArgs e)
		{
            if (CellClickEvent != null)
                CellClickEvent(this.Name);
		}

		private void labelClassroom_Click(object sender, EventArgs e)
		{
            if (CellClickEvent != null)
                CellClickEvent(this.Name);
		}
	}
}
