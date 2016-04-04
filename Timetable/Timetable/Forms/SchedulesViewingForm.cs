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

        enum ObjectsToView { CLASS, TEACHERS, CLASSROOMS}

		public SchedulesViewingForm()
		{
			InitializeComponent();
		}

		private void button_ok_Click(object sender, EventArgs e)
		{
			this.Hide();
			if (closeFormEvent != null)
			{
				closeFormEvent();
			}
		}

		private void SchedulesViewingForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'dataSet1.lessons' table. You can move, or remove it, as needed.
            this.lessonsTableAdapter.Fill(this.dataSet1.lessons);
			// TODO: This line of code loads data into the 'dataSet.students' table. You can move, or remove it, as needed.
			this.studentsTableAdapter.Fill(this.dataSet1.students);
			// TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
			this.classesTableAdapter.Fill(this.dataSet1.classes);
            // TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.dataSet1.teachers);
            this.classroomsTableAdapter.Fill(this.dataSet1.classrooms);

           
            this.dataGridViewSchedule.DataSource = typeof(List<>);
           // this.dataGridViewSchedule.DataSource = patients.ToList();
		}

        private void ChangeGroupToView_Click(ObjectsToView objectToView)
        {
            comboBox_objectsToView.Text = "";
            comboBox_objectsToView.Items.Clear();

            switch(objectToView)
            {
                case ObjectsToView.CLASS:
                    button_setClassesView.Enabled = false;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = true;

                    foreach (DataRow dataRow in dataSet1.classes)
                    {
                        comboBox_objectsToView.Items.Add(dataRow.ItemArray[0].ToString());
                    }
                    break;

                case ObjectsToView.TEACHERS:
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = false;
                    button_setClassromsView.Enabled = true;

                    foreach (DataRow dataRow in dataSet1.teachers)
                    {
                        string item = dataRow["surname"].ToString().Trim() + " " + dataRow["name"].ToString().Trim();
                        comboBox_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.CLASSROOMS:
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = false;

                    foreach (DataRow dataRow in dataSet1.classrooms)
                    {
                        comboBox_objectsToView.Items.Add(dataRow.ItemArray[0].ToString());
                    }
                    break;
            }
        }

        private void button_setClassesView_Click(object sender, EventArgs e)
        {
            ChangeGroupToView_Click(ObjectsToView.CLASS);
        }

        private void button_setTeacherView_Click(object sender, EventArgs e)
        {
            ChangeGroupToView_Click(ObjectsToView.TEACHERS);
        }

        private void button_setClassromsView_Click(object sender, EventArgs e)
        {
            ChangeGroupToView_Click(ObjectsToView.CLASSROOMS);
        }




	}
}
