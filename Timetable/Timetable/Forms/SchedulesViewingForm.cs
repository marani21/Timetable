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
		public static event EventDelegate closeFormEvent;//event zamkniecia formy

        enum ObjectsToView { CLASS, TEACHERS, CLASSROOMS} // enum pomagajacy w wyborze selekcji danych

        private ObjectsToView objectToView;  //aktualnie wybrane kryterium do filtrowania

        //nazwy kontrolek 
        private string cellControlName = "cellControl_";
        private string parentOfCellControlName = "panelCells";

        //nazwy uzywane do nazw kolumn w listView
        private string listView_objectsToView_classColumnName_0 = "klasa";
        private string listView_objectsToView_teacherColumnName_0 = "imię";
        private string listView_objectsToView_teacherColumnName_1 = "nazwisko";
        private string listView_objectsToView_teacherColumnName_2 = "pesel";
        private string listView_objectsToView_classroomColumnName_0 = "sala";

        //nazwy uzywanych pol z bazy danych
        private string dbField_teacherName = "teacher_name";
        private string dbField_teacherSurname = "teacher_surname";
        private string dbField_teacherPesel = "teacher_pesel";
        private string dbField_classroom = "classroom";
        private string dbField_class = "class";
        private string dbField_subjectName = "subject_name";
        private string dbField_weekday = "weekday";
        private string dbField_lessonNumber = "lesson_number";


        private List<Label> lessonPeriodsLabelsList = new List<Label>();
		public SchedulesViewingForm()
		{
			InitializeComponent();
            lessonPeriodsLabelsList.Add(this.label_lp_0);
            lessonPeriodsLabelsList.Add(this.label_lp_1);
            lessonPeriodsLabelsList.Add(this.label_lp_2);
            lessonPeriodsLabelsList.Add(this.label_lp_3);
            lessonPeriodsLabelsList.Add(this.label_lp_4);
            lessonPeriodsLabelsList.Add(this.label_lp_5);
            lessonPeriodsLabelsList.Add(this.label_lp_6);
            lessonPeriodsLabelsList.Add(this.label_lp_7);
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
           try
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
            this.lessons_periodsTableAdapter.Fill(this.dataSet1.lessons_periods);

            this.database_viewTableAdapter.Fill(this.dataSet1.database_view);
            }catch(Exception ex)
           {
               MessageBox.Show(ex.ToString());//message box zkodem bledu
           }


            ClearAllCellControls(); //na poczatku czyscimy wszystkie kontrolki z danymi
            SetLessonPeriods();
		}


        // metoda wywołana po wyborze kryterium do pokazania danych z planu
        private void ChangeGroupToView_Click()
        {
            ClearAllCellControls(); //czyscimy wszystkie kontrolki z danymi

            listView_objectsToView.Clear(); // czyscimy liste z objektami do wyswietlania

            switch(objectToView)
            {
                case ObjectsToView.CLASS:// jezeli wybrano jako filtr klase
                    //ponizej blokowany jest button z wybranym kryterium, pozostale zostaja odblokowane
                    button_setClassesView.Enabled = false; 
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = true;

                    listView_objectsToView.Columns.Add(listView_objectsToView_classColumnName_0); //dodajemy kolumne dolisty
                    listView_objectsToView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);// ustawiamy wielkosc kolumny-auto size

                    foreach (DataRow dataRow in dataSet1.classes)//do listy z danymi wstawiamy wszystkie klasy
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow[0].ToString();
                        listView_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.TEACHERS: // jezeli wybrano jako filtr nauczyciela
                    //ponizej blokowany jest button z wybranym kryterium, pozostale zostaja odblokowane
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = false;
                    button_setClassromsView.Enabled = true;


                    listView_objectsToView.Columns.Add(listView_objectsToView_teacherColumnName_0);//dodajemy kolumne dolisty
                    listView_objectsToView.Columns.Add(listView_objectsToView_teacherColumnName_1);//dodajemy kolumne dolisty
                    listView_objectsToView.Columns.Add(listView_objectsToView_teacherColumnName_2);//dodajemy kolumne dolisty

                    listView_objectsToView.Columns[0].Width = 60;// ustawiamy wielkosc kolumny
                    listView_objectsToView.Columns[1].Width = 60;// ustawiamy wielkosc kolumny

                    foreach (DataRow dataRow in dataSet1.teachers)//do listy z danymi wstawiamy wszystkich nauczycieli
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow[1].ToString();
                        item.SubItems.Add(dataRow[2].ToString());
                        item.SubItems.Add(dataRow[0].ToString());
                        listView_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.CLASSROOMS: //jezeli wybrano jako filtr sale lekcyjna
                    //ponizej blokowany jest button z wybranym kryterium, pozostale zostaja odblokowane
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = false;

                    listView_objectsToView.Columns.Add(listView_objectsToView_classroomColumnName_0);//dodajemy kolumne dolisty
                    listView_objectsToView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);// ustawiamy wielkosc kolumny-auto size

                    foreach (DataRow dataRow in dataSet1.classrooms)//do listy z danymi wstawiamy wszystkie sale lekcyjne
                    {
                        ListViewItem item = new ListViewItem(); 
                        item.Text = dataRow[0].ToString();
                        listView_objectsToView.Items.Add(item);
                    }
                    break;
            }
        }

        //button - filtr dla klas
        private void button_setClassesView_Click(object sender, EventArgs e)
        {
            objectToView = ObjectsToView.CLASS;//ustawienie jakoobecnego kryterium
            ChangeGroupToView_Click();
        }

        //button - filtr dla nauczycieli
        private void button_setTeacherView_Click(object sender, EventArgs e)
        {
            objectToView = ObjectsToView.TEACHERS;//ustawienie jakoobecnego kryterium
            ChangeGroupToView_Click();
        }

        //button - filtr dla sal lekcyjnych
        private void button_setClassromsView_Click(object sender, EventArgs e)
        {
            objectToView = ObjectsToView.CLASSROOMS; //ustawienie jakoobecnego kryterium 
            ChangeGroupToView_Click();
        }


        //czysci wszystkie kontrolki przedstawiajace zajecia
        private void ClearAllCellControls()
        {
            foreach (Control c in this.Controls.Find(parentOfCellControlName, true).FirstOrDefault().Controls)
            {
                if (c is CellControl)
                {
                    ((CellControl)c).Disable();
                    ((CellControl)c).Clear();
                }
            }
        }


        //metoda reagujaca na zmiane itemu z listy przedtawiajacej dane (liste sal, nauczycieli, klas) dla ktorych przedstawiony zostanie plan
        private void listView_objectsToView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearAllCellControls(); //czyscimy wszystkie komorki
            if (this.listView_objectsToView.SelectedItems.Count > 0)// jezeli zaznaczono jakis item (zabezpieczenie)
            {
                // dlakazdej grupy jest inna petla z uwagi na to ze dla kazdej grupy inacznej zbudowano liste przedstawiajaca wszystkich jej czlonkow
                switch (objectToView)
                {
                    case ObjectsToView.CLASS: // loop dla klas
                        foreach (DataRow dataRow in dataSet1.database_view)
                        {
                            if (dataRow[dbField_class].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;

                    case ObjectsToView.TEACHERS:// loop dla nauczycieli
                        foreach (DataRow dataRow in dataSet1.database_view)
                        {
                            if (dataRow[dbField_teacherPesel].ToString() == this.listView_objectsToView.SelectedItems[0].SubItems[2].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;

                    case ObjectsToView.CLASSROOMS:// loop dla sal lekcyjnych
                        foreach (DataRow dataRow in dataSet1.database_view)
                        {
                            if (dataRow[dbField_classroom].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;
                }
            }
        }


        //ustawia godziny przedmiotow
        private void SetLessonPeriods()
        {
            int i = 0;
            foreach (DataRow dataRow in dataSet1.lessons_periods)
            {
                //jezeli indeks mniejszy odilości labeli
                if (i < lessonPeriodsLabelsList.Count)
                {
					int id = int.Parse(dataRow[0].ToString());
                    lessonPeriodsLabelsList[id].Text = dataRow[1].ToString().Remove(5) + " - " + dataRow[2].ToString().Remove(5);
                    i++;
                }               
                else
                    break;
            }
        }

        //ustawia dane dla poszczegolnej kontrolki
        private void SetDataInCell(DataRow dataRow)
        {
            //okreslenie nazwy dla kontrolki
            string itmName = cellControlName;
            itmName += dataRow[dbField_weekday];
            itmName += "_";
            itmName += dataRow[dbField_lessonNumber];

            //okreslenie danych
            string subject = dataRow[dbField_subjectName].ToString().Trim();
            string teacher = dataRow[dbField_teacherSurname].ToString().Trim() + " " + dataRow[dbField_teacherName].ToString().Trim();
            string classroom = dataRow[dbField_classroom].ToString();

            //znalezienie kontrolki i wywolanie metodyprzypisujacej dane oraz odblokowanie kontrolki 
            CellControl cellControl = (CellControl)this.Controls.Find(itmName, true)[0];
            cellControl.SetData(subject, teacher, classroom);
            cellControl.Enabled();
        }


	}
}
