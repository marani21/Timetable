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
			
			foreach(Control c in this.Controls.Find("panelCells", true).FirstOrDefault().Controls)
			{
                if (c is CellControl)
                    ((CellControl)c).Enabled();
			}

            cell.Activate();
		}

        private void ScheduleCreationFormExt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.dataSet.classes);
            // TODO: This line of code loads data into the 'dataSet.classrooms' table. You can move, or remove it, as needed.
            this.classroomsTableAdapter.Fill(this.dataSet.classrooms);
            // TODO: This line of code loads data into the 'dataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            // TODO: This line of code loads data into the 'dataSet.teaching' table. You can move, or remove it, as needed.
            this.teachingTableAdapter.Fill(this.dataSet.teaching);
            // TODO: This line of code loads data into the 'dataSet.database_view' table. You can move, or remove it, as needed.
            this.database_viewTableAdapter.Fill(this.dataSet.database_view);

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
            // TODO: Asia
            // Wstawienie danych (przedmiot, sala, nauczyciel) do wybranego cellControl,
            // zadbać o to, aby zostało obsłużone zdarzenie gdy żaden cellControl nie jest zaznaczony
            // Nauczyciela należy wyszukać z bazy danych na podstawie klasy oraz przedmiotu


        }

		private void buttonOK_Click(object sender, EventArgs e)
		{
			// wywołanie TableAdapter.Update() 

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
                    ((CellControl)c).Clear();
            }
        }

        private void FillSchedule()
        {
            foreach (DataRow dataRow in dataSet.database_view)
            {
                if (dataRow["class"].ToString() == comboBoxClass.SelectedValue.ToString())
                {
                    string name = "cellControl";
                    name += dataRow["weekday"];
                    name += "_";
                    name += dataRow["lesson_number"];

                    string subject = dataRow["subject_name"].ToString().Trim();
                    string teacher = dataRow["teacher_name"].ToString().Trim() + " " + dataRow["teacher_surname"].ToString().Trim();
                    string classroom = dataRow["classroom"].ToString().Trim();

                    CellControl cellControl = (CellControl)Controls.Find(name, true)[0];
                    cellControl.SetData(subject, teacher, classroom);
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
                    int amount = Int32.Parse(teachingDataRow["amount"].ToString());
                    int id = Int32.Parse(teachingDataRow["subject"].ToString());
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
	}
}
