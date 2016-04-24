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
            // Szukanie zaznaczonej kontrolki
            CellControl cell = this.Controls.Find(controlName, true).FirstOrDefault() as CellControl;

            // Ustawienie wszystkich kontrolek na widoczne oraz ustawienie właściwości IsActive na false
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                if (c is CellControl)
                {
                    ((CellControl)c).Enabled();
                    ((CellControl)c).IsActive = false;
                }
            }
            if(cell != null)
            { 
                cell.Activate(); // Ustawienie zaznaczonej kontrolki na podświetloną
                cell.IsActive = true; // Ustawienie właściwości IsActive, zaznaczonej kontrolki, na true
            }
        }

        #region Metody elementów GUI

        private void ScheduleCreationFormExt_Load(object sender, EventArgs e)
        {
            // Pobieranie z bazy odpowiednich tabel
            try
            {
                this.classesTableAdapter.Fill(this.dataSet.classes);
                this.classroomsTableAdapter.Fill(this.dataSet.classrooms);
                this.subjectsTableAdapter.Fill(this.dataSet.subjects);
                this.teachingTableAdapter.Fill(this.dataSet.teaching);
                this.database_viewTableAdapter.Fill(this.dataSet.database_view);
                this.teachersTableAdapter.Fill(this.dataSet.teachers);
                this.lessonsTableAdapter.Fill(this.dataSet.lessons);
                this.lessons_periodsTableAdapter.Fill(this.dataSet.lessons_periods);
            }
            catch (Exception)
            {
                MessageBox.Show(ViewConstants.NO_DATABASE_CONNECTION);
            }

            ClearCellControls();
            FillLabelLesson();
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

            // Przechodzenie po wszystkich kontrolkach z panelCells
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                // Jeśli kontrolka jest CellControl oraz jest zaznaczona
                if (c is CellControl && ((CellControl)c).IsActive == true)
                {
                    isAnyChosen = true;
                    try
                    {
                        string subject = comboBoxSubject.Text;
                        string subjectId = comboBoxSubject.SelectedValue.ToString();
                        string classroom = comboBoxClassroom.Text;
                        string className = comboBoxClass.Text;
                        DataRow[] subjectIdRows = dataSet.subjects.Select(DBConstants.SUBJECT_NAME + "='" + subject + "'");
                        DataRow[] teacherIdRows = dataSet.teaching.Select(DBConstants.TEACHING_CLASS_ID + "='" + className + "' and " + DBConstants.TEACHING_SUBJECT_ID + "=" + subjectId);
                        string teacherId = teacherIdRows[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                        DataRow[] teacherRows = dataSet.teachers.Select(DBConstants.TEACHER_PESEL + "='" + teacherId.Trim() + "'");
                        string teacher = teacherRows[0][DBConstants.TEACHER_NAME].ToString().Trim() + " " + teacherRows[0][DBConstants.TEACHER_SURNAME].ToString().Trim();
                        string cellName = c.Name;
                        string weekday = cellName[(cellName.Length - 3)].ToString();
                        string lessonPeriod = cellName[(cellName.Length - 1)].ToString();

                        // Jeżeli możliwe jest wstawienie danego przedmiotu do planu w danym czasie
                        if (IsPossibleToAdd(className, teacherId, classroom, weekday, lessonPeriod))
                        {
                            DeleteLessonFromDataSet(className, lessonPeriod, weekday); // Usuwanie lekcji z danego czasu (możliwe że chcemy nadpisać)
                            AddLessonToDataSet(className, subjectId, classroom, lessonPeriod, weekday); // Wstawianie nowej lekcji w tym czasie
                            ((CellControl)c).SetData(subject, teacher, classroom); // Wpisanie odpowiednich wartości do kontrolki
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
            // Wyświetlanie odpowiedniego monitu jeśli żadna kontrolka nie została zaznaczona
            if (!isAnyChosen)
                MessageBox.Show(ViewConstants.CELL_NOT_CHOSEN);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool isAnyChosen = false;
            // Przechodzenie po wszystkich kontrolkach z panelCells
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                // Jeśli kontrolka jest CellControl oraz jest zaznaczona
                if (c is CellControl && ((CellControl)c).IsActive == true)
                {
                    isAnyChosen = true;
                    try
                    {
                        string cellName = c.Name;
                        string className = comboBoxClass.Text;
                        string weekday = cellName[(cellName.Length - 3)].ToString();
                        string lessonPeriod = cellName[(cellName.Length - 1)].ToString();

                        DeleteLessonFromDataSet(className, lessonPeriod, weekday); // Usuwanie lekcji z danego czasu
                        ((CellControl)c).Clear(); // Czyszczenie zawartości danej kontrolki
                        FillSubjects();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
            }
            // Wyświetlanie odpowiedniego monitu jeśli żadna kontrolka nie została zaznaczona
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
            // Zapisanie do bazy tabeli lessons
            try
            {
                lessonsTableAdapter.Update(dataSet.lessons);
            }
            catch (Exception)
            {
                MessageBox.Show(ViewConstants.NO_DATABASE_CONNECTION);
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

        // Uzupełnianie labelLesson odpowiednimi blokami godzinowymi
        // w formacie: godzina_rozpoczęcia - godzina_zakończenia
        private void FillLabelLesson()
        {
            // Zmienna i będzie od 7 do 0, ponieważ w ScheduleCreationFormExt.Designer.cs
            // Label'e są wstawiane do Controls w kolejności od rosnącej do malejącej
            int i = 7;
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
            {
                // Jeśli kontrolka jest Label oraz zawiera w nazwie słowo "Lesson"
                if (c is Label && c.Name.Contains("Lesson"))
                {
                    // Ustawienie do tekstu godziny rozpoczęcia i zakończenia dla i-tego bloku godzinowego
                    ((Label)c).Text = dataSet.lessons_periods.Select(DBConstants.LESSON_LESSON_NUMBER + "=" + i)[0][DBConstants.LESSON_PERIOD_START_TIME].ToString().Remove(5);
                    ((Label)c).Text += " - ";
                    ((Label)c).Text += dataSet.lessons_periods.Select(DBConstants.LESSON_LESSON_NUMBER + "=" + i)[0][DBConstants.LESSON_PERIOD_END_TIME].ToString().Remove(5);
                    i--;
                }
            }
        }

        // Uzupełnianie kontrolek planem lekcji
        private void FillSchedule()
        {
            // Przechodzenie po wszystkich wierszach tabeli lessons
            foreach (DataRow dataRow in dataSet.lessons)
            {
                // Jeśli RowState danego wiersza nie jest ustawiony na Deleted
                if (dataRow.RowState != DataRowState.Deleted)
                {
                    string className = comboBoxClass.Text;
                    // Jeśli class z tego wiersza zgadza się z klasą wybraną w comboBoxClass
                    if (dataRow[DBConstants.LESSON_CLASS].ToString() == className)
                    {
                        // Generowanie odpowiedniej nazwy, aby móc wyszukać odpowiednią kontrolkę
                        string name = "cellControl";
                        name += dataRow[DBConstants.LESSON_WEEKDAY];
                        name += "_";
                        name += dataRow[DBConstants.LESSON_LESSON_NUMBER];

                        try
                        {
                            string subjectId = dataRow[DBConstants.LESSON_SUBJECT].ToString().Trim();
                            string subject = dataSet.subjects.Select(DBConstants.SUBJECT_ID + "=" + subjectId)[0][DBConstants.SUBJECT_NAME].ToString().Trim();
                            string teacherPesel = dataSet.teaching.Select(DBConstants.TEACHING_CLASS_ID + "='" + className + "' and " + DBConstants.TEACHING_SUBJECT_ID + "=" + subjectId)[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                            string teacher = dataSet.teachers.Select(DBConstants.TEACHER_PESEL + "='" + teacherPesel + "'")[0][DBConstants.TEACHER_NAME].ToString().Trim() + " " +
                                dataSet.teachers.Select(DBConstants.TEACHER_PESEL + "='" + teacherPesel + "'")[0][DBConstants.TEACHER_SURNAME].ToString().Trim();

                            string classroom = dataRow[DBConstants.LESSON_CLASSROOM].ToString().Trim();

                            // Szukanie kontrolki o takiej nazwie jaka została wygenerowana
                            CellControl cellControl = (CellControl)Controls.Find(name, true)[0];

                            // Wpisanie do kontrolki odpowiednich danych z tabeli lessons
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

            // Lista, która posłuży jako DataSource dla comboBoxSubject
            List<KeyValuePair<int, string>> classSubjects = new List<KeyValuePair<int, string>>();

            // Przechodzenie po wszystkich wierszach tabeli teaching
            foreach (DataRow teachingDataRow in dataSet.teaching.Rows)
            {
                // Jeśli class z tego wiersza zgadza się z klasą wybraną w comboBoxClass
                if (teachingDataRow[DBConstants.TEACHING_CLASS_ID].ToString() == comboBoxClass.Text)
                {
                    // Szukanie id wiersza tabeli teaching
                    int id = Int32.Parse(teachingDataRow[DBConstants.TEACHING_SUBJECT_ID].ToString());

                    // Określenie liczby danego przedmiotu jaka została jeszcze do przydzielenia
                    int amount = HowMany(teachingDataRow[DBConstants.TEACHING_CLASS_ID].ToString(), id.ToString());
                    if (amount > 0)
                    {
                        noSubjectsLeft = false;
                    }
                    // Wstawienie odpowiedniej ilości danego przedmiotu do classSubjects
                    for (int i = 0; i < amount; i++)
                    {
                        DataRow[] subjectsRows = dataSet.subjects.Select(DBConstants.SUBJECT_ID + "=" + id);
                        foreach (DataRow subjectsDataRow in subjectsRows)
                        {
                            string value = subjectsDataRow[DBConstants.SUBJECT_NAME].ToString().Trim();
                            classSubjects.Add(new KeyValuePair<int, string>(id, value));
                        }
                    }
                }
            }
            comboBoxSubject.DataSource = classSubjects; // Ustawienie classSubjects jako DataSource comboBoxSubject
            comboBoxSubject.DisplayMember = "Value"; // Ustawienie wartości do wyświetlania (nazwa przedmiotu)
            comboBoxSubject.ValueMember = "Key"; // Ustawienie wartości (id)

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
                dataSet.lessons.Select(DBConstants.LESSON_PERIOD_NUMBER + "=" + lessonNumber + " and " + DBConstants.LESSON_CLASS + "='" + className + "' and " + DBConstants.LESSON_WEEKDAY + "=" + weekday)[0].Delete();
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
                DataRow[] amountRow = dataSet.teaching.Select(DBConstants.TEACHING_CLASS_ID + "='" + className + "' and " + DBConstants.TEACHING_SUBJECT_ID + "=" + subjectId);
                string amount = amountRow[0][DBConstants.TEACHING_AMOUNT].ToString();
                DataRow[] lessonsAdded = dataSet.lessons.Select(DBConstants.LESSON_CLASS + "='" + className + "' and " + DBConstants.LESSON_SUBJECT + "=" + subjectId);
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
            DataRow[] findClassrooms = dataSet.lessons.Select(DBConstants.LESSON_CLASS + "<>'" + className + "' and " + DBConstants.LESSON_CLASSROOM + "=" + classroom + " and " + DBConstants.LESSON_WEEKDAY + "=" + weekday + " and " + DBConstants.LESSON_LESSON_NUMBER + "=" + lessonNumber);
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
            DataRow[] findTeachers = dataSet.lessons.Select(DBConstants.LESSON_CLASS + "<>'" + className + "' and " + DBConstants.LESSON_WEEKDAY + "=" + weekday + " and " + DBConstants.LESSON_LESSON_NUMBER + "=" + lessonNumber);
            foreach (DataRow dataRow in findTeachers)
            {
                string classTmp = dataRow[DBConstants.LESSON_CLASS].ToString().Trim();
                string subjectIdTmp = dataRow[DBConstants.LESSON_SUBJECT].ToString().Trim();
                string teacherPesel = dataSet.teaching.Select(DBConstants.TEACHING_CLASS_ID + "='" + classTmp + "' and " + DBConstants.TEACHING_SUBJECT_ID + "=" + subjectIdTmp)[0][DBConstants.TEACHING_TEACHER_ID].ToString();
                if (teacherId == teacherPesel)
                {
                    MessageBox.Show(ViewConstants.TEACHER_BUSY + classTmp);
                    flagTeacher = false;
                }
            }
            // Jeśli sala oraz nauczyciel nie są zajęci to zwracamy true, w przeciwnym wypadku zwracamy false
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
