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

            this.database_viewTableAdapter.Fill(this.dataSet1.database_view);
            }catch(Exception ex)
           {
               MessageBox.Show(ex.ToString());//message box zkodem bledu
           }

            ClearAllCellControls(); //na poczatku czyscimy wszystkie kontrolki z danymi
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

                    listView_objectsToView.Columns.Add("class"); //dodajemy kolumne dolisty
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


                    listView_objectsToView.Columns.Add("Imię");//dodajemy kolumne dolisty
                    listView_objectsToView.Columns.Add("Nazwisko");//dodajemy kolumne dolisty
                    listView_objectsToView.Columns.Add("Pesel");//dodajemy kolumne dolisty

                    listView_objectsToView.Columns[0].Width = 60;// ustawiamy wielkosc kolumny
                    listView_objectsToView.Columns[1].Width = 60;// ustawiamy wielkosc kolumny

                    foreach (DataRow dataRow in dataSet1.teachers)//do listy z danymi wstawiamy wszystkich nauczycieli
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = dataRow["surname"].ToString();
                        item.SubItems.Add(dataRow["name"].ToString());
                        item.SubItems.Add(dataRow["pesel"].ToString());
                        listView_objectsToView.Items.Add(item);
                    }
                    break;

                case ObjectsToView.CLASSROOMS: //jezeli wybrano jako filtr sale lekcyjna
                    //ponizej blokowany jest button z wybranym kryterium, pozostale zostaja odblokowane
                    button_setClassesView.Enabled = true;
                    button_setTeacherView.Enabled = true;
                    button_setClassromsView.Enabled = false;

                    listView_objectsToView.Columns.Add("Sale");//dodajemy kolumne dolisty
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
            foreach (Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
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
                            if (dataRow["class"].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;

                    case ObjectsToView.TEACHERS:// loop dla nauczycieli
                        foreach (DataRow dataRow in dataSet1.database_view)
                        {
                            if (dataRow["teacher_pesel"].ToString() == this.listView_objectsToView.SelectedItems[0].SubItems[2].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;

                    case ObjectsToView.CLASSROOMS:// loop dla sal lekcyjnych
                        foreach (DataRow dataRow in dataSet1.database_view)
                        {
                            if (dataRow["classroom"].ToString() == this.listView_objectsToView.SelectedItems[0].Text)
                            {
                                SetDataInCell(dataRow);
                            }

                        }
                        break;
                }
            }
        }


        //ustawia dane dla poszczegolnej kontrolki
        private void SetDataInCell(DataRow dataRow)
        {
            //okreslenie nazwy dla kontrolki
            string cellControlName = "cellControl_";
            cellControlName += dataRow["weekday"];
            cellControlName += "_";
            cellControlName += dataRow["lesson_number"];

            //okreslenie danych
            string subject = dataRow["subject_name"].ToString().Trim();
            string teacher = dataRow["teacher_surname"].ToString().Trim() + " " + dataRow["teacher_name"].ToString().Trim();
            string classroom = dataRow["classroom"].ToString();

            //znalezienie kontrolki i wywolanie metodyprzypisujacej dane oraz odblokowanie kontrolki 
            CellControl cellControl = (CellControl) this.Controls.Find(cellControlName, true)[0];
            cellControl.SetData(subject, teacher, classroom);
            cellControl.Enabled();
        }


	}
}
