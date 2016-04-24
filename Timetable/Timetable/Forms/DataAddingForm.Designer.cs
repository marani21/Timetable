namespace Timetable
{
	partial class DataAddingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataSet = new Timetable.DataSet();
			this.dataTabControl = new System.Windows.Forms.TabControl();
			this.studentsTabPage = new System.Windows.Forms.TabPage();
			this.studentsAddingControl = new Timetable.StudentsAddingControl();
			this.teachersTabPage = new System.Windows.Forms.TabPage();
			this.teachersAddingControl = new Timetable.TeachersAddingControl();
			this.subjectsTabPage = new System.Windows.Forms.TabPage();
			this.subjectsAddingControl = new Timetable.SubjectsAddingControl();
			this.subjectsAssigningTabPage = new System.Windows.Forms.TabPage();
			this.subjectAssigningControl = new Timetable.SubjectAssigningControl();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.itemCreateSchedule = new System.Windows.Forms.ToolStripMenuItem();
			this.itemViewSchedules = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonOK = new System.Windows.Forms.Button();
			this.subjectsTableAdapter1 = new Timetable.DataSetTableAdapters.subjectsTableAdapter();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.classesTableAdapter1 = new Timetable.DataSetTableAdapters.classesTableAdapter();
			this.classroomsTableAdapter1 = new Timetable.DataSetTableAdapters.classroomsTableAdapter();
			this.lessons_periodsTableAdapter1 = new Timetable.DataSetTableAdapters.lessons_periodsTableAdapter();
			this.lessonsTableAdapter1 = new Timetable.DataSetTableAdapters.lessonsTableAdapter();
			this.studentsTableAdapter1 = new Timetable.DataSetTableAdapters.studentsTableAdapter();
			this.teachersTableAdapter1 = new Timetable.DataSetTableAdapters.teachersTableAdapter();
			this.teachingTableAdapter1 = new Timetable.DataSetTableAdapters.teachingTableAdapter();
			this.weekdaysTableAdapter1 = new Timetable.DataSetTableAdapters.weekdaysTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			this.dataTabControl.SuspendLayout();
			this.studentsTabPage.SuspendLayout();
			this.teachersTabPage.SuspendLayout();
			this.subjectsTabPage.SuspendLayout();
			this.subjectsAssigningTabPage.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataTabControl
			// 
			this.dataTabControl.Controls.Add(this.studentsTabPage);
			this.dataTabControl.Controls.Add(this.teachersTabPage);
			this.dataTabControl.Controls.Add(this.subjectsTabPage);
			this.dataTabControl.Controls.Add(this.subjectsAssigningTabPage);
			this.dataTabControl.Location = new System.Drawing.Point(1, 34);
			this.dataTabControl.Name = "dataTabControl";
			this.dataTabControl.SelectedIndex = 0;
			this.dataTabControl.Size = new System.Drawing.Size(490, 364);
			this.dataTabControl.TabIndex = 0;
			this.dataTabControl.SelectedIndexChanged += new System.EventHandler(this.updateData);
			// 
			// studentsTabPage
			// 
			this.studentsTabPage.Controls.Add(this.studentsAddingControl);
			this.studentsTabPage.Location = new System.Drawing.Point(4, 22);
			this.studentsTabPage.Name = "studentsTabPage";
			this.studentsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.studentsTabPage.Size = new System.Drawing.Size(482, 338);
			this.studentsTabPage.TabIndex = 0;
			this.studentsTabPage.Text = "Uczniowie";
			this.studentsTabPage.UseVisualStyleBackColor = true;
			// 
			// studentsAddingControl
			// 
			this.studentsAddingControl.Location = new System.Drawing.Point(3, 3);
			this.studentsAddingControl.Name = "studentsAddingControl";
			this.studentsAddingControl.Size = new System.Drawing.Size(558, 335);
			this.studentsAddingControl.TabIndex = 0;
			this.studentsAddingControl.Load += new System.EventHandler(this.studentsAddingControl_Load);
			// 
			// teachersTabPage
			// 
			this.teachersTabPage.Controls.Add(this.teachersAddingControl);
			this.teachersTabPage.Location = new System.Drawing.Point(4, 22);
			this.teachersTabPage.Name = "teachersTabPage";
			this.teachersTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.teachersTabPage.Size = new System.Drawing.Size(482, 338);
			this.teachersTabPage.TabIndex = 1;
			this.teachersTabPage.Text = "Nauczyciele";
			this.teachersTabPage.UseVisualStyleBackColor = true;
			// 
			// teachersAddingControl
			// 
			this.teachersAddingControl.Location = new System.Drawing.Point(28, 23);
			this.teachersAddingControl.Name = "teachersAddingControl";
			this.teachersAddingControl.Size = new System.Drawing.Size(491, 341);
			this.teachersAddingControl.TabIndex = 0;
			// 
			// subjectsTabPage
			// 
			this.subjectsTabPage.Controls.Add(this.subjectsAddingControl);
			this.subjectsTabPage.Location = new System.Drawing.Point(4, 22);
			this.subjectsTabPage.Name = "subjectsTabPage";
			this.subjectsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.subjectsTabPage.Size = new System.Drawing.Size(482, 338);
			this.subjectsTabPage.TabIndex = 2;
			this.subjectsTabPage.Text = "Przedmioty";
			this.subjectsTabPage.UseVisualStyleBackColor = true;
			// 
			// subjectsAddingControl
			// 
			this.subjectsAddingControl.Location = new System.Drawing.Point(7, 19);
			this.subjectsAddingControl.Name = "subjectsAddingControl";
			this.subjectsAddingControl.Size = new System.Drawing.Size(306, 313);
			this.subjectsAddingControl.TabIndex = 0;
			this.subjectsAddingControl.Load += new System.EventHandler(this.subjectsAddingControl_Load);
			// 
			// subjectsAssigningTabPage
			// 
			this.subjectsAssigningTabPage.Controls.Add(this.subjectAssigningControl);
			this.subjectsAssigningTabPage.Location = new System.Drawing.Point(4, 22);
			this.subjectsAssigningTabPage.Name = "subjectsAssigningTabPage";
			this.subjectsAssigningTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.subjectsAssigningTabPage.Size = new System.Drawing.Size(482, 338);
			this.subjectsAssigningTabPage.TabIndex = 3;
			this.subjectsAssigningTabPage.Text = "Przydzielanie przedmiotów";
			this.subjectsAssigningTabPage.UseVisualStyleBackColor = true;
			// 
			// subjectAssigningControl
			// 
			this.subjectAssigningControl.Location = new System.Drawing.Point(6, 8);
			this.subjectAssigningControl.Name = "subjectAssigningControl";
			this.subjectAssigningControl.Size = new System.Drawing.Size(476, 324);
			this.subjectAssigningControl.TabIndex = 0;
			this.subjectAssigningControl.Load += new System.EventHandler(this.subjectAssigningControl_Load);
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip.Size = new System.Drawing.Size(497, 31);
			this.menuStrip.TabIndex = 15;
			this.menuStrip.Text = "menuStrip1";
			// 
			// itemMenu
			// 
			this.itemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCreateSchedule,
            this.itemViewSchedules});
			this.itemMenu.Name = "itemMenu";
			this.itemMenu.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
			this.itemMenu.Size = new System.Drawing.Size(105, 27);
			this.itemMenu.Text = "Menu";
			this.itemMenu.Click += new System.EventHandler(this.itemMenu_Click);
			// 
			// itemCreateSchedule
			// 
			this.itemCreateSchedule.Name = "itemCreateSchedule";
			this.itemCreateSchedule.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.itemCreateSchedule.Size = new System.Drawing.Size(172, 30);
			this.itemCreateSchedule.Text = "Ułóż plan";
			this.itemCreateSchedule.Click += new System.EventHandler(this.itemCreateSchedule_Click);
			// 
			// itemViewSchedules
			// 
			this.itemViewSchedules.Name = "itemViewSchedules";
			this.itemViewSchedules.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.itemViewSchedules.Size = new System.Drawing.Size(172, 30);
			this.itemViewSchedules.Text = "Przegladaj plany";
			this.itemViewSchedules.Click += new System.EventHandler(this.itemAssignSubjects_Click);
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new System.Drawing.Point(382, 404);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(105, 33);
			this.buttonOK.TabIndex = 16;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// subjectsTableAdapter1
			// 
			this.subjectsTableAdapter1.ClearBeforeFill = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(271, 404);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(105, 33);
			this.buttonCancel.TabIndex = 17;
			this.buttonCancel.Text = "Anuluj";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// classesTableAdapter1
			// 
			this.classesTableAdapter1.ClearBeforeFill = true;
			// 
			// classroomsTableAdapter1
			// 
			this.classroomsTableAdapter1.ClearBeforeFill = true;
			// 
			// lessons_periodsTableAdapter1
			// 
			this.lessons_periodsTableAdapter1.ClearBeforeFill = true;
			// 
			// lessonsTableAdapter1
			// 
			this.lessonsTableAdapter1.ClearBeforeFill = true;
			// 
			// studentsTableAdapter1
			// 
			this.studentsTableAdapter1.ClearBeforeFill = true;
			// 
			// teachersTableAdapter1
			// 
			this.teachersTableAdapter1.ClearBeforeFill = true;
			// 
			// teachingTableAdapter1
			// 
			this.teachingTableAdapter1.ClearBeforeFill = true;
			// 
			// weekdaysTableAdapter1
			// 
			this.weekdaysTableAdapter1.ClearBeforeFill = true;
			// 
			// SubjectsAssigningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 449);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.dataTabControl);
			this.Name = "SubjectsAssigningForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dodaj dane do bazy";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubjectsAssigningForm_FormClosing);
			this.Load += new System.EventHandler(this.SubjectsAssigningForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			this.dataTabControl.ResumeLayout(false);
			this.studentsTabPage.ResumeLayout(false);
			this.teachersTabPage.ResumeLayout(false);
			this.subjectsTabPage.ResumeLayout(false);
			this.subjectsAssigningTabPage.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataSet dataSet;
		private System.Windows.Forms.TabControl dataTabControl;
		private System.Windows.Forms.TabPage studentsTabPage;
		private System.Windows.Forms.TabPage teachersTabPage;
		private System.Windows.Forms.TabPage subjectsTabPage;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem itemMenu;
		private System.Windows.Forms.ToolStripMenuItem itemCreateSchedule;
		private System.Windows.Forms.ToolStripMenuItem itemViewSchedules;
		private StudentsAddingControl studentsAddingControl;
		private TeachersAddingControl teachersAddingControl;
		private SubjectsAddingControl subjectsAddingControl;
		private SubjectAssigningControl subjectAssigningControl;
		private System.Windows.Forms.Button buttonOK;
		private DataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter1;
		private System.Windows.Forms.Button buttonCancel;
        private DataSetTableAdapters.classesTableAdapter classesTableAdapter1;
        private DataSetTableAdapters.classroomsTableAdapter classroomsTableAdapter1;
        private DataSetTableAdapters.lessons_periodsTableAdapter lessons_periodsTableAdapter1;
        private DataSetTableAdapters.lessonsTableAdapter lessonsTableAdapter1;
        private DataSetTableAdapters.studentsTableAdapter studentsTableAdapter1;
        private DataSetTableAdapters.teachersTableAdapter teachersTableAdapter1;
        private DataSetTableAdapters.teachingTableAdapter teachingTableAdapter1;
        private DataSetTableAdapters.weekdaysTableAdapter weekdaysTableAdapter1;
        public System.Windows.Forms.TabPage subjectsAssigningTabPage;
    }
}