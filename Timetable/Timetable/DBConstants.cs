using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
	// Klasa posiadająca stałe z nazwami elementów bazy danych (tabele, kolumny...)
	class DBConstants
	{
		// Tabele
		public static readonly string CLASSES = "classes";
		public static readonly string CLASSROOMS = "classrooms";
		public static readonly string LESSONS = "lessons";
		public static readonly string LESSONS_PERIODS = "lessons_periods";
		public static readonly string STUDENTS = "students";
		public static readonly string SUBJECTS = "subjects";
		public static readonly string TEACHERS = "teachers";
		public static readonly string TEACHING = "teaching";
		public static readonly string WEEKDAYS = "weekdays";

		// Widoki
		public static readonly string DATABASE_VIEW = "database_view";

		//Kolumny
		public static readonly string CLASS_ID = "label";
		public static readonly string CLASSROOM_NUMBER = "number";

		public static readonly string LESSON_LESSON_NUMBER = "lesson_number";
		public static readonly string LESSON_CLASS = "class";
		public static readonly string LESSON_SUBJECT = "subject";
		public static readonly string LESSON_WEEKDAY = "weekday";
		public static readonly string LESSON_CLASSROOM = "classroom";

		public static readonly string LESSON_PERIOD_NUMBER = "lesson_number";
		public static readonly string LESSON_PERIOD_START_TIME = "start_time";
		public static readonly string LESSON_PERIOD_END_TIME = "end_time";

		public static readonly string STUDENT_PESEL = "pesel";
		public static readonly string STUDENT_NAME = "name";
		public static readonly string STUDENT_SURNAME = "surname";
		public static readonly string STUDENT_CLASS_ID = "class";

		public static readonly string SUBJECT_ID = "id";
		public static readonly string SUBJECT_NAME = "name";

		public static readonly string TEACHER_PESEL = "pesel";
		public static readonly string TEACHER_NAME = "name";
		public static readonly string TEACHER_SURNAME = "surname";

		public static readonly string TEACHING_CLASS_ID = "class";
		public static readonly string TEACHING_TEACHER_ID = "teacher";
		public static readonly string TEACHING_SUBJECT_ID = "subject";
		public static readonly string TEACHING_AMOUNT = "amount";

		public static readonly string WEEKDAY_ID = "id";
		public static readonly string WEEKDAY_NAME = "name";
	}
}
