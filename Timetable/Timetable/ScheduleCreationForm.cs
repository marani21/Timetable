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
    public partial class ScheduleCreationForm : Form
    {
        public static event EventDelegate closeFormEvent;

        public ScheduleCreationForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Zamykam...");
            //this.Hide();
            //if (closeFormEvent != null)
            //{
            //    closeFormEvent();
            //}

            // TODO: Update bazy danych
            this.Close();
        }

        private void ScheduleCreationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.classrooms' table. You can move, or remove it, as needed.
            this.classroomsTableAdapter.Fill(this.dataSet.classrooms);
            // TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.dataSet.classes);

        }
    }
}
