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

        // Właściwości określające daną kontrolkę (dzień tygodnia, blok godzinowy)
        public string Weekday { get; set; }
        public int LessonPeriod { get; set; }

        public bool IsActive { get; set; }

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

        // kontrolka ustawia swoj styl na odblokowany 
        public void Enabled()
        {
           this.BackColor = SystemColors.ControlLight;
           this.labelSubject.BackColor = SystemColors.ButtonHighlight;
           this.labelTeacher.BackColor = SystemColors.ControlLight;
           this.labelClassroom.BackColor = SystemColors.ControlLight;
        }

        // kontrolka ustawia swoj stylna aktywna (zaznaczona)
        public void Activate()
        {
            this.BackColor = Color.Bisque;
            this.labelSubject.BackColor = SystemColors.ButtonHighlight;
            this.labelTeacher.BackColor = SystemColors.ControlLight;
            this.labelClassroom.BackColor = SystemColors.ControlLight;
        }

        //kontrolka zmienia swoj styl na zablokowana
        public void Disable()
        {
            this.BackColor = SystemColors.Control;
            this.labelSubject.BackColor = SystemColors.Control;
            this.labelTeacher.BackColor = SystemColors.Control;
            this.labelClassroom.BackColor = SystemColors.Control;
        }


        //czysci pola kontrolki
        public void Clear()
        {
            Teacher = "";
            Subject = "";
            Classroom = "";
        }


        //ustawia dane kolejno: przedmiot, nauczyciel, klasa
        public void SetData(string subject, string teacher, string classroom)
        {
            Teacher = teacher;
            Subject = subject;
            Classroom = classroom;
        }
	}
}
