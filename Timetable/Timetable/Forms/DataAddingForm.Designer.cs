namespace Timetable
{
	partial class SubjectsAssigningForm
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
            this.dataTabControl.Size = new System.Drawing.Size(558, 364);
            this.dataTabControl.TabIndex = 0;
            // 
            // studentsTabPage
            // 
            this.studentsTabPage.Controls.Add(this.studentsAddingControl);
            this.studentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.studentsTabPage.Name = "studentsTabPage";
            this.studentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studentsTabPage.Size = new System.Drawing.Size(550, 338);
            this.studentsTabPage.TabIndex = 0;
            this.studentsTabPage.Text = "Uczniowie";
            this.studentsTabPage.UseVisualStyleBackColor = true;
            // 
            // studentsAddingControl
            // 
            this.studentsAddingControl.Location = new System.Drawing.Point(21, 20);
            this.studentsAddingControl.Name = "studentsAddingControl";
            this.studentsAddingControl.Size = new System.Drawing.Size(506, 335);
            this.studentsAddingControl.TabIndex = 0;
            // 
            // teachersTabPage
            // 
            this.teachersTabPage.Controls.Add(this.teachersAddingControl);
            this.teachersTabPage.Location = new System.Drawing.Point(4, 22);
            this.teachersTabPage.Name = "teachersTabPage";
            this.teachersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.teachersTabPage.Size = new System.Drawing.Size(550, 338);
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
            this.subjectsTabPage.Size = new System.Drawing.Size(550, 338);
            this.subjectsTabPage.TabIndex = 2;
            this.subjectsTabPage.Text = "Przedmioty";
            this.subjectsTabPage.UseVisualStyleBackColor = true;
            // 
            // subjectsAddingControl
            // 
            this.subjectsAddingControl.Location = new System.Drawing.Point(21, 18);
            this.subjectsAddingControl.Name = "subjectsAddingControl";
            this.subjectsAddingControl.Size = new System.Drawing.Size(502, 350);
            this.subjectsAddingControl.TabIndex = 0;
            this.subjectsAddingControl.Load += new System.EventHandler(this.subjectsAddingControl_Load);
            // 
            // subjectsAssigningTabPage
            // 
            this.subjectsAssigningTabPage.Controls.Add(this.subjectAssigningControl);
            this.subjectsAssigningTabPage.Location = new System.Drawing.Point(4, 22);
            this.subjectsAssigningTabPage.Name = "subjectsAssigningTabPage";
            this.subjectsAssigningTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.subjectsAssigningTabPage.Size = new System.Drawing.Size(550, 338);
            this.subjectsAssigningTabPage.TabIndex = 3;
            this.subjectsAssigningTabPage.Text = "Przydzielanie przedmiotów";
            this.subjectsAssigningTabPage.UseVisualStyleBackColor = true;
            // 
            // subjectAssigningControl
            // 
            this.subjectAssigningControl.Location = new System.Drawing.Point(7, 6);
            this.subjectAssigningControl.Name = "subjectAssigningControl";
            this.subjectAssigningControl.Size = new System.Drawing.Size(532, 324);
            this.subjectAssigningControl.TabIndex = 0;
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
            this.menuStrip.Size = new System.Drawing.Size(558, 31);
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
            // 
            // itemCreateSchedule
            // 
            this.itemCreateSchedule.Name = "itemCreateSchedule";
            this.itemCreateSchedule.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.itemCreateSchedule.Size = new System.Drawing.Size(172, 30);
            this.itemCreateSchedule.Text = "Ułóż plan";
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
            this.buttonOK.Location = new System.Drawing.Point(439, 404);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(105, 33);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // subjectsTableAdapter1
            // 
            this.subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // SubjectsAssigningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 449);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dataTabControl);
            this.Name = "SubjectsAssigningForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dane do bazy";
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
		private System.Windows.Forms.TabPage subjectsAssigningTabPage;
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
    }
}