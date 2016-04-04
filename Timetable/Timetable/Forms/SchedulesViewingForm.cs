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

namespace Timetable
{
	public partial class SchedulesViewingForm : Form
	{
		public static event EventDelegate closeFormEvent;

        enum ObjectsToView { CLASS, TEACHERS, CLASSROOMS}

        private ObjectsToView objectToView;
        

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

            this.databaseViewTableAdapter.Fill(this.dataSet1.databaseView);


		}

        private void ChangeGroupToView_Click()
        {
            comboBox_objectsToView.Text = "";
            comboBox_objectsToView.Items.Clear();
            //ClearAllCellControls();
            cellControl_0_0.Enabled();
            cellControl_0_1.Clear();
            cellControl_0_1.Disable();
            cellControl_0_2.Activate();

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
            objectToView = ObjectsToView.CLASS;
            ChangeGroupToView_Click();
        }

        private void button_setTeacherView_Click(object sender, EventArgs e)
        {
            objectToView = ObjectsToView.TEACHERS;
            ChangeGroupToView_Click();
        }

        private void button_setClassromsView_Click(object sender, EventArgs e)
        {
            objectToView = ObjectsToView.CLASSROOMS;
            ChangeGroupToView_Click();
        }

        private void comboBox_objectsToView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetView()
        {
            string obj = this.comboBox_objectsToView.SelectedItem.ToString();
            
            for(int i=0; i < (int)DayOfWeek.Friday; i++)
            {
                for(int j=0; j<8; j++)
                {

                }
            }
        }


        private void ClearAllCellControls()
        {
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl)
                {
                    ((CellControl)c).Disable();
                    ((CellControl)c).Clear();
                }
            }
        }

	}
}
