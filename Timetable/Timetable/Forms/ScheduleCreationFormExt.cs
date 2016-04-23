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

        #region Konstruktor

        public ScheduleCreationFormExt()
        {
            InitializeComponent();
            CellControl.CellClickEvent += CellControl_CellClickEvent;
        }

        #endregion

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

        #region Metody elementów GUI

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
                        string teacherId = teacherIdRows[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                        DataRow[] teacherRows = dataSet.teachers.Select("pesel = '" + teacherId.Trim() + "'");
                        string teacher = teacherRows[0][DBConstants.TEACHER_NAME].ToString().Trim() + " " + teacherRows[0][DBConstants.TEACHER_SURNAME].ToString().Trim();
                        string cellName = c.Name;
                        string weekday = cellName[(cellName.Length - 3)].ToString();
                        string lessonPeriod = cellName[(cellName.Length - 1)].ToString();

                        if (IsPossibleToAdd(className, teacherId, classroom, weekday, lessonPeriod))
                        {
                            DeleteLessonFromDataSet(className, lessonPeriod, weekday);
                            AddLessonToDataSet(className, subjectId, classroom, lessonPeriod, weekday);
                            ((CellControl)c).SetData(subject, teacher, classroom);
                            FillSubjects();
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            if (!isAnyChosen)
                MessageBox.Show(ViewConstants.CELL_NOT_CHOSEN);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool isAnyChosen = false;
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl && ((CellControl)c).IsActive == true)
                {
                    isAnyChosen = true;
                    try
                    {
                        string cellName = c.Name;
                        string className = comboBoxClass.Text;
                        string weekday = cellName[(cellName.Length - 3)].ToString();
                        string lessonPeriod = cellName[(cellName.Length - 1)].ToString();

                        DeleteLessonFromDataSet(className, lessonPeriod, weekday);
                        ((CellControl)c).Clear();
                        FillSubjects();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            if (!isAnyChosen)
                MessageBox.Show(ViewConstants.CELL_NOT_CHOSEN);
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

        #endregion

        #region Metody pomocnicze przy GUI

        // Czyszczenie zawartości kontrolek
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

        // Uzupełnianie kontrolek planem lekcji
        private void FillSchedule()
        {
            foreach (DataRow dataRow in dataSet.lessons)
            {
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    string className = comboBoxClass.Text;
                    if (dataRow[DBConstants.LESSON_CLASS].ToString() == className)
                    {
                        string name = "cellControl";
                        name += dataRow[DBConstants.LESSON_WEEKDAY];
                        name += "_";
                        name += dataRow[DBConstants.LESSON_LESSON_NUMBER];

                        try
                        {
                            string subjectId = dataRow[DBConstants.LESSON_SUBJECT].ToString().Trim();
                            string subject = dataSet.subjects.Select("id = " + subjectId)[0][DBConstants.SUBJECT_NAME].ToString().Trim();
                            string teacherPesel = dataSet.teaching.Select("class = '" + className + "' and subject = " + subjectId)[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                            string teacher = dataSet.teachers.Select("pesel = '" + teacherPesel + "'")[0][DBConstants.TEACHER_NAME].ToString().Trim() + " " +
                                dataSet.teachers.Select("pesel = '" + teacherPesel + "'")[0][DBConstants.TEACHER_SURNAME].ToString().Trim();

                            string classroom = dataRow[DBConstants.LESSON_CLASSROOM].ToString().Trim();

                            CellControl cellControl = (CellControl)Controls.Find(name, true)[0];
                            cellControl.SetData(subject, teacher, classroom);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }

        // Wypełnianie comboBoxSubject odpowiednimi przedmiotami
        private void FillSubjects()
        {
            bool noSubjectsLeft = true;
            List<KeyValuePair<int, string>> classSubjects = new List<KeyValuePair<int, string>>();
            foreach (DataRow teachingDataRow in dataSet.teaching.Rows)
            {
                if (teachingDataRow[DBConstants.TEACHING_CLASS_ID].ToString() == comboBoxClass.SelectedValue.ToString())
                {
                    int id = Int32.Parse(teachingDataRow[DBConstants.TEACHING_SUBJECT_ID].ToString());
                    int amount = HowMany(teachingDataRow[DBConstants.TEACHING_CLASS_ID].ToString(), id.ToString());
                    if (amount > 0)
                    {
                        noSubjectsLeft = false;
                    }
                    for (int i = 0; i < amount; i++)
                    {
                        DataRow[] subjectsRows = dataSet.subjects.Select("id = " + id);
                        foreach (DataRow subjectsDataRow in subjectsRows)
                        {
                            string value = subjectsDataRow[DBConstants.SUBJECT_NAME].ToString().Trim();
                            classSubjects.Add(new KeyValuePair<int, string>(id, value));
                        }
                    }
                }
            }
            comboBoxSubject.DataSource = classSubjects;
            comboBoxSubject.DisplayMember = "Value";
            comboBoxSubject.ValueMember = "Key";

            if (noSubjectsLeft)
            {
                buttonSet.Enabled = false;
            }
            else
            {
                buttonSet.Enabled = true;
            }
        }

        #endregion

        #region Metody operujące na DataSet

        // Dodawanie do tabeli lessons
        private void AddLessonToDataSet(string className, string subjectId, string classroom, string lessonNumber, string weekday)
        {
            try
            {
                DataRow newLessonsRow = dataSet.lessons.NewRow();
                newLessonsRow[DBConstants.LESSON_LESSON_NUMBER] = lessonNumber;
                newLessonsRow[DBConstants.LESSON_CLASS] = className;
                newLessonsRow[DBConstants.LESSON_SUBJECT] = subjectId;
                newLessonsRow[DBConstants.LESSON_WEEKDAY] = weekday;
                newLessonsRow[DBConstants.LESSON_CLASSROOM] = classroom;

                dataSet.lessons.Rows.Add(newLessonsRow);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        // Usuwanie z tabeli lessons
        private void DeleteLessonFromDataSet(string className, string lessonNumber, string weekday)
        {
            try
            {
                dataSet.lessons.Select("lesson_number=" + lessonNumber + " and class = '" + className + "' and weekday = " + weekday)[0].Delete();
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region Metody sprawdzające

        // Sprawdzanie ilości dostępnych przedmiotów dla danej klasy
        private int HowMany(string className, string subjectId)
        {
            try
            {
                DataRow[] amountRow = dataSet.teaching.Select("class = '" + className + "' and subject=" + subjectId);
                string amount = amountRow[0][DBConstants.TEACHING_AMOUNT].ToString();
                DataRow[] lessonsAdded = dataSet.lessons.Select("class = '" + className + "' and subject =" + subjectId);
                return int.Parse(amount) - lessonsAdded.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return -1;
        }

        // Sprawdzanie czy lekcja jest możliwa do dodania w danym dniu tygodnia i bloku godzinowym
        private bool IsPossibleToAdd(string className, string teacherId, string classroom, string weekday, string lessonNumber)
        {
            bool flagClassroom;
            bool flagTeacher = true;

            // Sprawdzanie czy sala jest zajęta przez inną klasę
            DataRow[] findClassrooms = dataSet.lessons.Select("class <> '" + className + "' and classroom = " + classroom + " and weekday = " + weekday + " and lesson_number = " + lessonNumber);
            if (findClassrooms.Length > 0)
            {
                MessageBox.Show(ViewConstants.CLASSROOM_BUSY + findClassrooms[0][DBConstants.LESSON_CLASS].ToString());
                flagClassroom = false;
            }
            else
            {
                flagClassroom = true;
            }

            // Sprawdzanie czy nauczyciel jest zajęty przez inną klasę
            DataRow[] findTeachers = dataSet.lessons.Select("class <> '" + className + "' and weekday = " + weekday + " and lesson_number = " + lessonNumber);
            foreach (DataRow dataRow in findTeachers)
            {
                string classTmp = dataRow[DBConstants.LESSON_CLASS].ToString().Trim();
                string subjectIdTmp = dataRow[DBConstants.LESSON_SUBJECT].ToString().Trim();
                string teacherPesel = dataSet.teaching.Select("class = '" + classTmp + "' and subject = " + subjectIdTmp)[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                if (teacherId == teacherPesel)
                {
                    MessageBox.Show(ViewConstants.TEACHER_BUSY + classTmp);
                    flagTeacher = false;
                }
            }
            if (flagClassroom && flagTeacher)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
