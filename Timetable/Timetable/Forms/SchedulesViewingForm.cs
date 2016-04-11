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

            this.database_viewTableAdapter.Fill(this.dataSet1.database_view);
            ClearAllCellControls();

		}

        private void ChangeGroupToView_Click()
        {
            ClearAllCellControls();

            listView_objectsToView.Clear();

            switch(objectToView)
            {
                case ObjectsToView.CLASS:
                    button_setClassesView.Enabled = false;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = true;

                    listView_objectsToView.Columns.Add("class");
                    listView_objectsToView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    foreach (DataRow dataRow in dataSet1.classes)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow[0].ToString();
                        listView_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.TEACHERS:
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = false;
                    button_setClassromsView.Enabled = true;


                    listView_objectsToView.Columns.Add("name");
                    listView_objectsToView.Columns.Add("surname");
                    listView_objectsToView.Columns.Add("ID");

                    listView_objectsToView.Columns[0].Width = 60;
                    listView_objectsToView.Columns[1].Width = 60;

                    foreach (DataRow dataRow in dataSet1.teachers)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow["surname"].ToString();
                        item.SubItems.Add(dataRow["name"].ToString());
                        item.SubItems.Add(dataRow["pesel"].ToString());
                        listView_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.CLASSROOMS:
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = false;

                    listView_objectsToView.Columns.Add("classrooms");
                    listView_objectsToView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                    foreach (DataRow dataRow in dataSet1.classrooms)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow[0].ToString();
                        listView_objectsToView.Items.Add(item);
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

        private void listView_objectsToView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllCellControls();
            switch(objectToView)
            {
                case ObjectsToView.CLASS:
                    foreach(DataRow dataRow in dataSet1.database_view)
                    {
                        if(dataRow["class"].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                        {
                            SetDataInCell(dataRow);
                        }
                       
                    }
                    break;

                case ObjectsToView.TEACHERS:
                    foreach(DataRow dataRow in dataSet1.database_view)
                    {
                        if(dataRow["teacher_pesel"].ToString() == this.listView_objectsToView.SelectedItems[0].SubItems[2].Text)
                        {
                            SetDataInCell(dataRow);
                        }
                       
                    }
                    break;

                case ObjectsToView.CLASSROOMS:
                    foreach(DataRow dataRow in dataSet1.database_view)
                    {
                        if(dataRow["classroom"].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                        {
                            SetDataInCell(dataRow);
                        }
                       
                    }
                    break;
            }
        }

        private void SetDataInCell(DataRow dataRow)
        {
            //okreslenie nazwy dla kontrolki
            string cellControlName = "cellControl_";
            cellControlName += dataRow["weekday"];
            cellControlName += "_";
            cellControlName += dataRow["lesson_number"];

            //okreslenie danych
            string subject = dataRow["subject_name"].ToString();
            string teacher = dataRow["teacher_surname"].ToString().Trim() + " " + dataRow["teacher_name"].ToString().Trim();
            string classroom = dataRow["classroom"].ToString();

            //znalezienie kontrolki i wywolanie metodyprzypisujacej dane oraz odblokowanie kontrolki 
            CellControl cellControl = (CellControl) this.Controls.Find(cellControlName, true)[0];
            cellControl.SetData(subject, teacher, classroom);
            cellControl.Enabled();
        }


	}
}
