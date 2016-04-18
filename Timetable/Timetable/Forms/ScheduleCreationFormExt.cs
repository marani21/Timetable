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
        public static event EventDelegate closeFormEvent;

        public ScheduleCreationFormExt()
        {
            InitializeComponent();
            CellControl.CellClickEvent += CellControl_CellClickEvent;
        }

        private void CellControl_CellClickEvent(string controlName)
        {
            CellControl cell = this.Controls.Find(controlName, true).FirstOrDefault() as CellControl;

            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl)
                {
                    ((CellControl)c).Enabled();
                    ((CellControl)c).IsActive = false;
                }
            }

            cell.Activate();
            cell.IsActive = true;
        }

        private void ScheduleCreationFormExt_Load(object sender, EventArgs e)
        {
            this.classesTableAdapter.Fill(this.dataSet.classes);
            this.classroomsTableAdapter.Fill(this.dataSet.classrooms);
            this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            this.teachingTableAdapter.Fill(this.dataSet.teaching);
            this.database_viewTableAdapter.Fill(this.dataSet.database_view);
            this.teachersTableAdapter.Fill(this.dataSet.teachers);
            this.lessonsTableAdapter.Fill(this.dataSet.lessons);

            ClearCellControls();
            FillSchedule();
            FillSubjects();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearCellControls();
            FillSchedule();
            FillSubjects();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            bool isAnyChosen = false;
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl && ((CellControl)c).IsActive == true)
                {
                    isAnyChosen = true;
                    try
                    {
                        string subject = comboBoxSubject.Text;
                        string subjectId = comboBoxSubject.SelectedValue.ToString();
                        string classroom = comboBoxClassroom.Text;
                        string className = comboBoxClass.Text;
                        DataRow[] subjectIdRows = dataSet.subjects.Select("name='" + subject + "'");
                        DataRow[] teacherIdRows = dataSet.teaching.Select("class = '" + className + "' and subject=" + subjectId);
                        string teacherId = teacherIdRows[0]["teacher"].ToString();
                        DataRow[] teacherRows = dataSet.teachers.Select("pesel = '" + teacherId.Trim() + "'");
                        string teacher = teacherRows[0]["name"].ToString().Trim() + " " + teacherRows[0]["surname"].ToString().Trim();
                        string cellName = c.Name;
                        string weekday = cellName[(cellName.Length - 3)].ToString();
                        string lessonPeriod = cellName[(cellName.Length - 1)].ToString();

                        DeleteLessonFromDataSet(className, lessonPeriod, weekday);
                        AddLessonToDataSet(className, subjectId, classroom, lessonPeriod, weekday);
                        ((CellControl)c).SetData(subject, teacher, classroom);
                        FillSubjects();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            if (!isAnyChosen)
                MessageBox.Show("Nie wybrano żadnej komórki");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                lessonsTableAdapter.Update(dataSet.lessons);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
            if (closeFormEvent != null)
            {
                closeFormEvent();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            if (closeFormEvent != null)
            {
                closeFormEvent();
            }
        }

        private void ScheduleCreationFormExt_FormClosing(object sender, FormClosingEventArgs e)
        {
            // jeśli forma nie została zamknięta poprzez "OK" , czyli zostało kliknięte "X" lub "Anuluj"
            if (this.DialogResult == DialogResult.Cancel)
            {
                //MessageBox.Show("X lub Anuluj");

                // przywróć DataSet sprzed zmian (np. utwórz nowy) - brak jakiegokolwiek połączenia z bazą, bo wszystkie zmiany, 
                //których właśnie dokonaliśmy w DataSecie chcemy cofnąć
            }
        }

        private void ClearCellControls()
        {
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl)
                {
                    ((CellControl)c).Clear();
                    ((CellControl)c).Enabled();
                    ((CellControl)c).IsActive = false;
                }
            }
        }

        private void FillSchedule()
        {
            foreach (DataRow dataRow in dataSet.lessons)
            {
                string className = comboBoxClass.Text;
                if (dataRow["class"].ToString() == className)
                {
                    string name = "cellControl";
                    name += dataRow["weekday"];
                    name += "_";
                    name += dataRow["lesson_number"];

                    try
                    {
                        string subjectId = dataRow["subject"].ToString().Trim();
                        string subject = dataSet.subjects.Select("id = " + subjectId)[0]["name"].ToString();
                        string teacherPesel = dataSet.teaching.Select("class = '" + className + "' and subject = " + subjectId)[0]["teacher"].ToString();
                        string teacher = dataSet.teachers.Select("pesel = '" + teacherPesel + "'")[0]["name"].ToString().Trim() + " " +
                            dataSet.teachers.Select("pesel = '" + teacherPesel + "'")[0]["surname"].ToString().Trim();

                        string classroom = dataRow["classroom"].ToString().Trim();

                        CellControl cellControl = (CellControl)Controls.Find(name, true)[0];
                        cellControl.SetData(subject, teacher, classroom);
                    }
                    catch (Exception e)
                    {

                    }
                }
            }
        }

        private void FillSubjects()
        {
            List<KeyValuePair<int, string>> classSubjects = new List<KeyValuePair<int, string>>();
            foreach (DataRow teachingDataRow in dataSet.teaching.Rows)
            {
                if (teachingDataRow["class"].ToString() == comboBoxClass.SelectedValue.ToString())
                {
                    //int amount = Int32.Parse(teachingDataRow["amount"].ToString());
                    int id = Int32.Parse(teachingDataRow["subject"].ToString());
                    //zamiast amount bierzemy liczbę przedmiotów, jaka jeszcze została do przydzielenia
                    int amount = HowMany(teachingDataRow["class"].ToString(), id.ToString());
                    for (int i = 0; i < amount; i++)
                    {
                        DataRow[] subjectsRows = dataSet.subjects.Select("id = " + id);
                        foreach (DataRow subjectsDataRow in subjectsRows)
                        {
                            string value = subjectsDataRow["name"].ToString().Trim();
                            classSubjects.Add(new KeyValuePair<int, string>(id, value));
                        }
                    }
                }
            }
            comboBoxSubject.DataSource = classSubjects;
            comboBoxSubject.DisplayMember = "Value";
            comboBoxSubject.ValueMember = "Key";
        }

        //metoda dodaje do tabeli lessons nowy wpis
        private void AddLessonToDataSet(string className, string subjectId, string classroom, string lessonNumber, string weekday)
        {
            //TODO: sprawdzić, czy nauczyciel, sala są już zajęci
            try
            {
                DataRow newLessonsRow = dataSet.lessons.NewRow();
                newLessonsRow["lesson_number"] = lessonNumber;
                newLessonsRow["class"] = className;
                newLessonsRow["subject"] = subjectId;
                newLessonsRow["weekday"] = weekday;
                newLessonsRow["classroom"] = classroom;

                dataSet.lessons.Rows.Add(newLessonsRow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //metoda usuwa dany wpis
        private void DeleteLessonFromDataSet(string className, string lessonNumber, string weekday)
        {
            //sprawdzić czy nauczyciel/sala są już zajęci
            try
            {
                dataSet.lessons.Select("lesson_number=" + lessonNumber + " and class = '" + className + "' and weekday = " + weekday)[0].Delete();
            }
            catch (Exception e)
            {

            }
        }

        //metoda, która sprawdza ile jeszcze dostępnych jest przedniotów dla danej klasy
        private int HowMany(string className, string subjectId)
        {
            try
            {
                DataRow[] amountRow = dataSet.teaching.Select("class = '" + className + "' and subject=" + subjectId);
                string amount = amountRow[0]["amount"].ToString();
                DataRow[] lessonsAdded = dataSet.lessons.Select("class = '" + className + "' and subject =" + subjectId);
                return int.Parse(amount) - lessonsAdded.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return -1;
        }
    }
}
