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
        public ComboBox ComboBoxGet
        {
            get { return comboBoxViewSubjects; }
            private set { }
        }

        public SubjectsAddingControl()
        {
            InitializeComponent();
        }

        private void SubjectsAddingControl_Load(object sender, EventArgs e)
        {
            this.subjectsTableAdapter.Fill(this.dataSet.subjects);
            this.teachingTableAdapter.Fill(this.dataSet.teaching);
            this.lessonsTableAdapter.Fill(this.dataSet.lessons);
        }

        private void buttonAddSubject_Click(object sender, EventArgs e)
        {
            DataSet.subjectsRow newSubjectRow = dataSet.subjects.NewsubjectsRow();
            //pobieranie najwyzszego indexu 
            DataRowView item = comboBoxViewSubjects.Items[comboBoxViewSubjects.Items.Count - 1] as DataRowView;

            newSubjectRow.name = textBoxSubject.Text.ToString();
            newSubjectRow.id = int.Parse(item.Row["id"].ToString()) + 1;

            this.dataSet.subjects.Rows.Add(newSubjectRow);
            this.subjectsTableAdapter.Update(dataSet.subjects);

        }

        private void buttonEditSubject_Click(object sender, EventArgs e)
        {
            DataRowView item = comboBoxViewSubjects.Items[comboBoxViewSubjects.SelectedIndex] as DataRowView;
            item.Row["name"] = textBoxSubject.Text.ToString();
            this.subjectsTableAdapter.Update(dataSet.subjects);


        }

        private void buttonDeleteSubject_Click(object sender, EventArgs e)
        {
            DataRowView item = comboBoxViewSubjects.Items[comboBoxViewSubjects.SelectedIndex] as DataRowView;
            int subjectID = int.Parse(item.Row["id"].ToString());
            bool teachingRelation = checkIfTeachingRelationExists(subjectID.ToString(), 2);
            bool lessonsRelation = checkIfLessonsRelationExists(subjectID.ToString(), 3);
                        
            if (teachingRelation || lessonsRelation)
            {
                if (MessageBox.Show("Przedmiot zawiera powiązania w innych tabelach jesteś pewny, że chcesz go usunąć?", "Ostrzeżenie",
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
                    item.Delete();
                    subjectsTableAdapter.Update(this.dataSet.subjects);
                }
            }
            else
            {
                item.Delete();
                subjectsTableAdapter.Update(this.dataSet.subjects);
            }


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
            this.teachingTableAdapter.Update(dataSet.teaching);
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
            this.lessonsTableAdapter.Update(this.dataSet.lessons);
        }

        public void updateTableAdapters()
        {
            //this.lessonsTableAdapter.Update(this.dataSet.lessons);
            //this.teachingTableAdapter.Update(this.dataSet.teaching);
            //this.subjectsTableAdapter.Update(this.dataSet.subjects);

        }
    }
}
