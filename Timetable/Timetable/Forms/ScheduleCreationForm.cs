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
            // TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.dataSet.classes);
            // TODO: This line of code loads data into the 'dataSet.classrooms' table. You can move, or remove it, as needed.
            this.classroomsTableAdapter.Fill(this.dataSet.classrooms);
            // TODO: This line of code loads data into the 'dataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            // TODO: This line of code loads data into the 'dataSet.teaching' table. You can move, or remove it, as needed.
            this.teachingTableAdapter.Fill(this.dataSet.teaching);

            FillSubjects();

        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubjects();
        }

        private void comboBoxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FillSubjects()
        {
            AddToWeekdayColumns();
            foreach (DataRow teachingDataRow in dataSet.teaching.Rows)
            {
                if (teachingDataRow["class"].ToString() == comboBoxClasses.SelectedValue.ToString())
                {
                    int amount = Int32.Parse(teachingDataRow["amount"].ToString());
                    string id = teachingDataRow["subject"].ToString();
                    for (int i = 0; i < amount; i++)
                    {
                        DataRow[] subjectsRows = dataSet.subjects.Select("id = " + id);
                        foreach (DataRow subjectsDataRow in subjectsRows)
                        {
                            AddToWeekdayColumns(false, subjectsDataRow["name"].ToString());
                        }
                    }
                }
            }
        }

        private void AddToWeekdayColumns(bool clear = true, string value = "")
        {
            List<string> list = new List<string>();
            if (clear == true)
            {
                columnMonday.Items.Clear();
                columnTuesday.Items.Clear();
                columnWednesday.Items.Clear();
                columnThursday.Items.Clear();
                columnFriday.Items.Clear();
            }
            else
            {
                columnMonday.Items.Add(value);
                columnTuesday.Items.Add(value);
                columnWednesday.Items.Add(value);
                columnThursday.Items.Add(value);
                columnFriday.Items.Add(value);
            }
        }
    }
}
