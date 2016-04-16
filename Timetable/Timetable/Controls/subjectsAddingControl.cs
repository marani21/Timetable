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
            get { return this.dataSet; }
        }

        public SubjectsAddingControl()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            this.subjectsDataGridView.DataSource = this.dataSet;                   
            this.subjectsBindingSource.DataSource = this.dataSet.subjects;
            this.subjectsDataGridView.DataSource = this.subjectsBindingSource;
        }

        private void SubjectsAddingControl_Load(object sender, EventArgs e)
        {
            //this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            //this.teachingTableAdapter.Fill(this.dataSet.teaching);
            //this.lessonsTableAdapter.Fill(this.dataSet.lessons);
        }
       
        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (subjectsDataGridView.SelectedRows.Count == 0)
                return;

            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczone rekordy?", "Ostrzeżenie",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.No)
                return;
            int subjesctID = int.Parse(dataSet.subjects.Rows[0]["id"].ToString());
            int subjescstID = int.Parse(dataSet.subjects.Rows[0]["id"].ToString());


            foreach (DataGridViewRow row in subjectsDataGridView.SelectedRows)
            {
                int subjectID = int.Parse(dataSet.subjects.Rows[row.Index]["id"].ToString());
                bool teachingRelation = checkIfTeachingRelationExists(subjectID.ToString(), 2);
                bool lessonsRelation = checkIfLessonsRelationExists(subjectID.ToString(), 3);

                BindingSource bs = subjectsDataGridView.DataSource as BindingSource;
                if (teachingRelation || lessonsRelation)
                {
                    if (MessageBox.Show("Jeden z rekordów zawiera powiązania, usunąc powiązania i przedmiot?", "Ostrzeżenie",
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
                else
                {
                    bs.RemoveAt(row.Index);
                }
            }
            
            //subjectsDataGridView.Update();
            this.dataSet.AcceptChanges();

        }

        private bool checkIfTeachingRelationExists(string pattern, int column)
        {
            for (int i = 0; i < dataSet.teaching.Rows.Count; i++)
            {
                if (dataSet.teaching.Rows[i][column].ToString() == pattern)
                    return true;
            }
            return false;
        }

        private bool checkIfLessonsRelationExists(string pattern, int column)
        {
            for (int i = 0; i < dataSet.lessons.Rows.Count; i++)
            {
                if (dataSet.lessons.Rows[i][column].ToString() == pattern)
                    return true;
            }
            return false;
        }

        private void deleteTeachingRelations(string pattern, int column)
        {
            for (int i = 0; i < dataSet.teaching.Rows.Count; i++)
            {
                if (dataSet.teaching.Rows[i][column].ToString() == pattern)
                {
                    try
                    {
                        //pobieramy klucze dla wiersza ktory pasuje
                        string mClass = dataSet.teaching.Rows[i][0].ToString();
                        int mSubject = int.Parse(dataSet.teaching.Rows[i][2].ToString());
                        //pobieramy wiersz do usuniecia
                        DataSet.teachingRow deleteRow = dataSet.teaching.FindBy_classsubject(mClass, mSubject);
                        //usuwamy wiersz
                        deleteRow.Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void deleteLessonsRelations(string pattern, int column)
        {
            for (int i = 0; i < dataSet.lessons.Rows.Count; i++)
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
                        DataSet.lessonsRow deleteRow = dataSet.lessons.FindBylesson_number_classweekday(mLessonNumber, mClass, mWeekday);
                        //usuwamy wiersz
                        deleteRow.Delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }

            }
        }

    }
}
