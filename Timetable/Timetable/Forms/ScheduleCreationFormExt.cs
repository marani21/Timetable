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
				if(c is CellControl)
					c.BackColor = SystemColors.ControlLight;
			}

			cell.BackColor = Color.Bisque;
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

            FillSubjects();
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubjects();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Da bum tssss");
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
                            string value = subjectsDataRow["name"].ToString();
                            classSubjects.Add(new KeyValuePair<int, string>(id, value));
                        }
                    }
                }
            }
            comboBox1.DataSource = classSubjects;
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
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
	}
}
