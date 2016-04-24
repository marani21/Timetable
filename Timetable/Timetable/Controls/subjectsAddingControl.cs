using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable
{
    public partial class SubjectsAddingControl : UserControl
    {
        public DataSet setDataSet
        {
            set { this.dataSet = value;
                  LoadData();

            }
        }

        public SubjectsAddingControl()
        {
            InitializeComponent();
        }
        //Ustawianie źródeł danych dla dataGridView
        private void LoadData()
        {
            this.subjectsDataGridView.DataSource = this.dataSet;                   
            this.subjectsBindingSource.DataSource = this.dataSet.subjects;
            this.subjectsDataGridView.DataSource = this.subjectsBindingSource;
        }

        //Usuwanie rekordów  
        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (subjectsDataGridView.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show(ViewConstants.DELETE_SELECTED_ROWS_WARNING, ViewConstants.WARNING,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
        

            foreach (DataGridViewRow row in subjectsDataGridView.SelectedRows)
            {
                //sprawdzenie czy wybrany rekord nie zawiera żadnych powiązań
                int subjectID = int.Parse(row.Cells[0].Value.ToString());
                bool teachingRelation = checkIfTeachingRelationExists(subjectID.ToString(), 2);
                bool lessonsRelation = checkIfLessonsRelationExists(subjectID.ToString(), 3);
                //jeśli zawiera pytamy użytkownika czy chce je usunąć, jeśli tak to usuwamy
                BindingSource bs = subjectsDataGridView.DataSource as BindingSource;
                if (teachingRelation || lessonsRelation)
                {
                    if (MessageBox.Show(ViewConstants.RELATION_DETECTED_WARNING, ViewConstants.WARNING,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        if (teachingRelation)
                        {
                            deleteTeachingRelations(subjectID.ToString(), 2);
                        }
                        if (lessonsRelation)
                        {
                            deleteLessonsRelations(subjectID.ToString(), 2);
                        }
                        bs.RemoveAt(row.Index);
                    }
                }
                //jeśli nie wykryto żandych relacji obiekt zostaje od razu usnięty
                else
                {
                    bs.RemoveAt(row.Index);
                }
            }

        }
        private bool checkIfTeachingRelationExists(string pattern, int column)
        {
            for (int i = 0; i < dataSet.teaching.Rows.Count; i++)
            {
                //sprawdzenie czy podany wiersz nie został wcześniej usunięty z lokalnego dataSet'a
                if (dataSet.teaching.Rows[i].RowState != DataRowState.Deleted)
                { 
                    if (dataSet.teaching.Rows[i][column].ToString() == pattern)
                        return true;
                }
               
            }
            return false;
        }

        private bool checkIfLessonsRelationExists(string pattern, int column)
        {
            for (int i = 0; i < dataSet.lessons.Rows.Count; i++)
            {
                //sprawdzenie czy podany wiersz nie został wcześniej usunięty z lokalnego dataSet'a
                if (dataSet.lessons.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dataSet.lessons.Rows[i][column].ToString() == pattern)
                        return true;
                }
            }
            return false;
        }

        private void deleteTeachingRelations(string pattern, int column)
        {
            for (int i = 0; i < dataSet.teaching.Rows.Count; i++)
            {
                //sprawdzenie czy podany wiersz nie został wcześniej usunięty z lokalnego dataSet'a
                if (dataSet.teaching.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dataSet.teaching.Rows[i][column].ToString() == pattern)
                    {
                        try
                        {
                            //pobieramy klucze dla wiersza ktory pasuje
                            string mClass = dataSet.teaching.Rows[i][0].ToString();
                            int mSubject = int.Parse(dataSet.teaching.Rows[i][2].ToString());
                            //pobieramy wiersz do usuniecia
                            DataSet.teachingRow deleteRow = this.dataSet.teaching.FindBy_classsubject(mClass, mSubject);
                            //usuwamy wiersz
                            deleteRow.Delete();
                        }
                        catch (Exception ex)
                        {
                            DataAddingForm.createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_DELETING_DATA, ex.ToString());
                        }
                    }
                }
            }
        }

        private void deleteLessonsRelations(string pattern, int column)
        {
            for (int i = 0; i < dataSet.lessons.Rows.Count; i++)
            {
                //sprawdzenie czy podany wiersz nie został wcześniej usunięty z lokalnego dataSet'a
                if (dataSet.lessons.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (dataSet.lessons.Rows[i][column].ToString() == pattern)
                    {
                        try
                        {
                            //pobieramy klucze dla wiersza ktory pasuje
                            int mLessonNumber = int.Parse(dataSet.lessons.Rows[i][0].ToString());
                            string mClass = dataSet.lessons.Rows[i][1].ToString();
                            int mWeekday = int.Parse(dataSet.lessons.Rows[i][3].ToString());
                            //pobieramy wiersz do usuniecia
                            DataSet.lessonsRow deleteRow = this.dataSet.lessons.FindBylesson_number_classweekday(mLessonNumber, mClass, mWeekday);
                            //usuwamy wiersz
                            deleteRow.Delete();
                        }
                        catch (Exception ex)
                        {
                            DataAddingForm.createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_DELETING_DATA, ex.ToString());
                        }
                    }
                }

            }
        }
        //pobiera najwyższe ID elementów z DataGridView i ustawia domyślną wartość dla id równą pobranej + 1
        private void subjectsDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["idDataGridViewTextBoxColumn"].Value = getMaxId()+1;
        }

        private int getMaxId()
        {
            return subjectsDataGridView.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["idDataGridViewTextBoxColumn"].Value));
        }

        private void subjectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            DataAddingForm.createDialogWithExceptionMessage(ViewConstants.ERROR, ViewConstants.ERROR_WHILE_EDITING_DATA, e.Exception.ToString());

        }
    }
}
