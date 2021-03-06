﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable
{
	// Klasa posiadająca stałe, które wyświetlamy w widoku
	static class ViewConstants
	{
		public static readonly string CLASS = "klasa";
		public static readonly string CLASSROOM = "sala";
		public static readonly string NAME = "imię";
		public static readonly string PERSONAL_IDENTITY_NUMBER = "pesel";
		public static readonly string STUDENT = "uczeń";
		public static readonly string SUBJECT = "przedmiot";
		public static readonly string SURNAME = "nazwisko";
		public static readonly string TEACHER = "nauczyciel";

		public static readonly string SCHEDULE_FOR_CLASS = "Plan dla klasy: ";
		public static readonly string SUBJECT_FOR_CLASS = "Przedmiot dla klasy: ";
		public static readonly string SCHEDULES_MANAGER = "Manager planów lekcji";
		public static readonly string ADD_DATA_TO_DATABASE = "Dodaj dane do bazy";
		public static readonly string VIEW_SCHEDULES = "Przeglądaj plany";
		public static readonly string CREATE_SCHEDULE = "Ułóż plan";

		// Akcje
		public static readonly string INSTER = "Wstaw";
		public static readonly string DELETE = "Usuń";
		public static readonly string ADD = "Dodaj";
		public static readonly string EDIT = "Edytuj";
		public static readonly string CANCEL = "Anuluj";
		public static readonly string OK = "OK";
	
		// Komunikaty
		public static readonly string CELL_NOT_CHOSEN = "Nie wybrano żadnej komórki";
		public static readonly string CLASSROOM_BUSY = "Sala jest zajęta przez ";
		public static readonly string SAVE_CHANGES_QUESTION = "Czy chcesz zapisać wszystkie dokonane zmiany?";
		public static readonly string TEACHER_BUSY = "Nauczyciel jest zajęty ";
        public static readonly string WARNING = "Ostrzeżenie ";
        public static readonly string DELETE_SELECTED_ROWS_WARNING = "Czy na pewno chcesz usunąć zaznaczone pola?";
        public static readonly string RELATION_DETECTED_WARNING = "Jeden z rekordów zawiera powiązania, usunąc powiązania i rekord?";
        public static readonly string ERROR = "Błąd";
        public static readonly string ERROR_WHILE_CONNECTING_TO_DB = "Wystąpił błąd podczas próby połączenia z bazą danych.";
        public static readonly string ERROR_WHILE_UPDATING_DATA_TO_DB = "Wystąpił błąd podczas próby zapisanie danych w bazie.";
        public static readonly string ERROR_WHILE_GETTING_DATA_FROM_DB = "Wystąpił błąd podczas pobierania danych z bazy.";
        public static readonly string ERROR_WHILE_DELETING_DATA = "Wystąpił błąd podczas usuwania danych.";
        public static readonly string ERROR_WHILE_EDITING_DATA = "Wystąpił błąd edycji danych.";
        public static readonly string CONFIRM_SAVING_TO_DB = "Czy na pewno chcesz zapisać wszystkie dokonane zmiany w bazie?";
        public static readonly string NO_DATABASE_CONNECTION = "Brak połączenia z bazą danych";

















    }
}
