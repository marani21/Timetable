namespace Timetable
{
	partial class SchedulesViewingForm
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
            this.components = new System.ComponentModel.Container();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_ok = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCreateSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAssignSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.classesTableAdapter = new Timetable.DataSetTableAdapters.classesTableAdapter();
            this.studentsTableAdapter = new Timetable.DataSetTableAdapters.studentsTableAdapter();
            this.button_setClassesView = new System.Windows.Forms.Button();
            this.button_setTeacherView = new System.Windows.Forms.Button();
            this.button_setClassromsView = new System.Windows.Forms.Button();
            this.dataSet1 = new Timetable.DataSet();
            this.teachersTableAdapter = new Timetable.DataSetTableAdapters.teachersTableAdapter();
            this.lessonsTableAdapter = new Timetable.DataSetTableAdapters.lessonsTableAdapter();
            this.classroomsTableAdapter = new Timetable.DataSetTableAdapters.classroomsTableAdapter();
            this.panelCells = new System.Windows.Forms.Panel();
            this.cellControl_5_7 = new Timetable.Controls.CellControl();
            this.cellControl_4_7 = new Timetable.Controls.CellControl();
            this.cellControl_3_7 = new Timetable.Controls.CellControl();
            this.cellControl_2_7 = new Timetable.Controls.CellControl();
            this.cellControl_1_7 = new Timetable.Controls.CellControl();
            this.cellControl_5_6 = new Timetable.Controls.CellControl();
            this.cellControl_4_6 = new Timetable.Controls.CellControl();
            this.cellControl_3_6 = new Timetable.Controls.CellControl();
            this.cellControl_2_6 = new Timetable.Controls.CellControl();
            this.cellControl_1_6 = new Timetable.Controls.CellControl();
            this.label_lp_7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_lp_6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cellControl_5_5 = new Timetable.Controls.CellControl();
            this.cellControl_4_5 = new Timetable.Controls.CellControl();
            this.cellControl_3_5 = new Timetable.Controls.CellControl();
            this.cellControl_2_5 = new Timetable.Controls.CellControl();
            this.cellControl_1_5 = new Timetable.Controls.CellControl();
            this.cellControl_5_4 = new Timetable.Controls.CellControl();
            this.cellControl_4_4 = new Timetable.Controls.CellControl();
            this.cellControl_3_4 = new Timetable.Controls.CellControl();
            this.cellControl_2_4 = new Timetable.Controls.CellControl();
            this.cellControl_1_4 = new Timetable.Controls.CellControl();
            this.label_lp_5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_lp_4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cellControl_5_3 = new Timetable.Controls.CellControl();
            this.cellControl_4_3 = new Timetable.Controls.CellControl();
            this.cellControl_3_3 = new Timetable.Controls.CellControl();
            this.cellControl_2_3 = new Timetable.Controls.CellControl();
            this.cellControl_1_3 = new Timetable.Controls.CellControl();
            this.cellControl_5_2 = new Timetable.Controls.CellControl();
            this.cellControl_4_2 = new Timetable.Controls.CellControl();
            this.cellControl_3_2 = new Timetable.Controls.CellControl();
            this.cellControl_2_2 = new Timetable.Controls.CellControl();
            this.cellControl_1_2 = new Timetable.Controls.CellControl();
            this.label_lp_3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_lp_2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cellControl_5_1 = new Timetable.Controls.CellControl();
            this.cellControl_4_1 = new Timetable.Controls.CellControl();
            this.cellControl_3_1 = new Timetable.Controls.CellControl();
            this.cellControl_2_1 = new Timetable.Controls.CellControl();
            this.cellControl_1_1 = new Timetable.Controls.CellControl();
            this.cellControl_5_0 = new Timetable.Controls.CellControl();
            this.cellControl_4_0 = new Timetable.Controls.CellControl();
            this.cellControl_3_0 = new Timetable.Controls.CellControl();
            this.cellControl_2_0 = new Timetable.Controls.CellControl();
            this.cellControl_1_0 = new Timetable.Controls.CellControl();
            this.label_lp_1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_lp_0 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.listView_objectsToView = new System.Windows.Forms.ListView();
            this.database_viewTableAdapter = new Timetable.DataSetTableAdapters.database_viewTableAdapter();
            this.lessons_periodsTableAdapter = new Timetable.DataSetTableAdapters.lessons_periodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelCells.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(697, 522);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(81, 29);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
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
            this.menuStrip.Size = new System.Drawing.Size(1022, 31);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // itemMenu
            // 
            this.itemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCreateSchedule,
            this.itemAssignSubjects});
            this.itemMenu.Name = "itemMenu";
            this.itemMenu.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.itemMenu.Size = new System.Drawing.Size(105, 27);
            this.itemMenu.Text = "Menu";
            // 
            // itemCreateSchedule
            // 
            this.itemCreateSchedule.Name = "itemCreateSchedule";
            this.itemCreateSchedule.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.itemCreateSchedule.Size = new System.Drawing.Size(197, 30);
            this.itemCreateSchedule.Text = "Ułóż plan";
            // 
            // itemAssignSubjects
            // 
            this.itemAssignSubjects.Name = "itemAssignSubjects";
            this.itemAssignSubjects.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.itemAssignSubjects.Size = new System.Drawing.Size(197, 30);
            this.itemAssignSubjects.Text = "Przydziel przedmioty";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // button_setClassesView
            // 
            this.button_setClassesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setClassesView.Image = global::Timetable.Properties.Resources.User_Group_icon;
            this.button_setClassesView.Location = new System.Drawing.Point(6, 59);
            this.button_setClassesView.Name = "button_setClassesView";
            this.button_setClassesView.Size = new System.Drawing.Size(70, 70);
            this.button_setClassesView.TabIndex = 15;
            this.button_setClassesView.Text = "Klasa";
            this.button_setClassesView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_setClassesView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_setClassesView.UseVisualStyleBackColor = true;
            this.button_setClassesView.Click += new System.EventHandler(this.button_setClassesView_Click);
            // 
            // button_setTeacherView
            // 
            this.button_setTeacherView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setTeacherView.Image = global::Timetable.Properties.Resources.Teacher_icon;
            this.button_setTeacherView.Location = new System.Drawing.Point(80, 59);
            this.button_setTeacherView.Name = "button_setTeacherView";
            this.button_setTeacherView.Size = new System.Drawing.Size(70, 70);
            this.button_setTeacherView.TabIndex = 16;
            this.button_setTeacherView.Text = "Nauczyciel";
            this.button_setTeacherView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_setTeacherView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_setTeacherView.UseVisualStyleBackColor = true;
            this.button_setTeacherView.Click += new System.EventHandler(this.button_setTeacherView_Click);
            // 
            // button_setClassromsView
            // 
            this.button_setClassromsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setClassromsView.Image = global::Timetable.Properties.Resources.Tutorial_icon;
            this.button_setClassromsView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_setClassromsView.Location = new System.Drawing.Point(154, 59);
            this.button_setClassromsView.Name = "button_setClassromsView";
            this.button_setClassromsView.Size = new System.Drawing.Size(70, 70);
            this.button_setClassromsView.TabIndex = 17;
            this.button_setClassromsView.Text = "Sala";
            this.button_setClassromsView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_setClassromsView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_setClassromsView.UseVisualStyleBackColor = true;
            this.button_setClassromsView.Click += new System.EventHandler(this.button_setClassromsView_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // classroomsTableAdapter
            // 
            this.classroomsTableAdapter.ClearBeforeFill = true;
            // 
            // panelCells
            // 
            this.panelCells.AutoScroll = true;
            this.panelCells.Controls.Add(this.cellControl_5_7);
            this.panelCells.Controls.Add(this.cellControl_4_7);
            this.panelCells.Controls.Add(this.cellControl_3_7);
            this.panelCells.Controls.Add(this.cellControl_2_7);
            this.panelCells.Controls.Add(this.cellControl_1_7);
            this.panelCells.Controls.Add(this.cellControl_5_6);
            this.panelCells.Controls.Add(this.cellControl_4_6);
            this.panelCells.Controls.Add(this.cellControl_3_6);
            this.panelCells.Controls.Add(this.cellControl_2_6);
            this.panelCells.Controls.Add(this.cellControl_1_6);
            this.panelCells.Controls.Add(this.label_lp_7);
            this.panelCells.Controls.Add(this.label15);
            this.panelCells.Controls.Add(this.label_lp_6);
            this.panelCells.Controls.Add(this.label17);
            this.panelCells.Controls.Add(this.cellControl_5_5);
            this.panelCells.Controls.Add(this.cellControl_4_5);
            this.panelCells.Controls.Add(this.cellControl_3_5);
            this.panelCells.Controls.Add(this.cellControl_2_5);
            this.panelCells.Controls.Add(this.cellControl_1_5);
            this.panelCells.Controls.Add(this.cellControl_5_4);
            this.panelCells.Controls.Add(this.cellControl_4_4);
            this.panelCells.Controls.Add(this.cellControl_3_4);
            this.panelCells.Controls.Add(this.cellControl_2_4);
            this.panelCells.Controls.Add(this.cellControl_1_4);
            this.panelCells.Controls.Add(this.label_lp_5);
            this.panelCells.Controls.Add(this.label19);
            this.panelCells.Controls.Add(this.label_lp_4);
            this.panelCells.Controls.Add(this.label21);
            this.panelCells.Controls.Add(this.cellControl_5_3);
            this.panelCells.Controls.Add(this.cellControl_4_3);
            this.panelCells.Controls.Add(this.cellControl_3_3);
            this.panelCells.Controls.Add(this.cellControl_2_3);
            this.panelCells.Controls.Add(this.cellControl_1_3);
            this.panelCells.Controls.Add(this.cellControl_5_2);
            this.panelCells.Controls.Add(this.cellControl_4_2);
            this.panelCells.Controls.Add(this.cellControl_3_2);
            this.panelCells.Controls.Add(this.cellControl_2_2);
            this.panelCells.Controls.Add(this.cellControl_1_2);
            this.panelCells.Controls.Add(this.label_lp_3);
            this.panelCells.Controls.Add(this.label11);
            this.panelCells.Controls.Add(this.label_lp_2);
            this.panelCells.Controls.Add(this.label13);
            this.panelCells.Controls.Add(this.cellControl_5_1);
            this.panelCells.Controls.Add(this.cellControl_4_1);
            this.panelCells.Controls.Add(this.cellControl_3_1);
            this.panelCells.Controls.Add(this.cellControl_2_1);
            this.panelCells.Controls.Add(this.cellControl_1_1);
            this.panelCells.Controls.Add(this.cellControl_5_0);
            this.panelCells.Controls.Add(this.cellControl_4_0);
            this.panelCells.Controls.Add(this.cellControl_3_0);
            this.panelCells.Controls.Add(this.cellControl_2_0);
            this.panelCells.Controls.Add(this.cellControl_1_0);
            this.panelCells.Controls.Add(this.label_lp_1);
            this.panelCells.Controls.Add(this.label9);
            this.panelCells.Controls.Add(this.label_lp_0);
            this.panelCells.Controls.Add(this.label6);
            this.panelCells.Location = new System.Drawing.Point(230, 59);
            this.panelCells.Name = "panelCells";
            this.panelCells.Size = new System.Drawing.Size(792, 503);
            this.panelCells.TabIndex = 43;
            // 
            // cellControl_5_7
            // 
            this.cellControl_5_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_7.Classroom = "101";
            this.cellControl_5_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_7.IsActive = false;
            this.cellControl_5_7.Location = new System.Drawing.Point(654, 444);
            this.cellControl_5_7.Name = "cellControl_5_7";
            this.cellControl_5_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_7.Subject = "Matematyka";
            this.cellControl_5_7.TabIndex = 85;
            this.cellControl_5_7.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_7
            // 
            this.cellControl_4_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_7.Classroom = "101";
            this.cellControl_4_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_7.IsActive = false;
            this.cellControl_4_7.Location = new System.Drawing.Point(520, 444);
            this.cellControl_4_7.Name = "cellControl_4_7";
            this.cellControl_4_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_7.Subject = "Matematyka";
            this.cellControl_4_7.TabIndex = 84;
            this.cellControl_4_7.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_7
            // 
            this.cellControl_3_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_7.Classroom = "101";
            this.cellControl_3_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_7.IsActive = false;
            this.cellControl_3_7.Location = new System.Drawing.Point(386, 444);
            this.cellControl_3_7.Name = "cellControl_3_7";
            this.cellControl_3_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_7.Subject = "Matematyka";
            this.cellControl_3_7.TabIndex = 83;
            this.cellControl_3_7.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_7
            // 
            this.cellControl_2_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_7.Classroom = "101";
            this.cellControl_2_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_7.IsActive = false;
            this.cellControl_2_7.Location = new System.Drawing.Point(252, 444);
            this.cellControl_2_7.Name = "cellControl_2_7";
            this.cellControl_2_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_7.Subject = "Matematyka";
            this.cellControl_2_7.TabIndex = 82;
            this.cellControl_2_7.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_7
            // 
            this.cellControl_1_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_7.Classroom = "101";
            this.cellControl_1_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_7.IsActive = false;
            this.cellControl_1_7.Location = new System.Drawing.Point(118, 444);
            this.cellControl_1_7.Name = "cellControl_1_7";
            this.cellControl_1_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_7.Subject = "Matematyka";
            this.cellControl_1_7.TabIndex = 81;
            this.cellControl_1_7.Teacher = "Adam Zielonka";
            // 
            // cellControl_5_6
            // 
            this.cellControl_5_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_6.Classroom = "101";
            this.cellControl_5_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_6.IsActive = false;
            this.cellControl_5_6.Location = new System.Drawing.Point(654, 381);
            this.cellControl_5_6.Name = "cellControl_5_6";
            this.cellControl_5_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_6.Subject = "Matematyka";
            this.cellControl_5_6.TabIndex = 80;
            this.cellControl_5_6.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_6
            // 
            this.cellControl_4_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_6.Classroom = "101";
            this.cellControl_4_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_6.IsActive = false;
            this.cellControl_4_6.Location = new System.Drawing.Point(520, 381);
            this.cellControl_4_6.Name = "cellControl_4_6";
            this.cellControl_4_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_6.Subject = "Matematyka";
            this.cellControl_4_6.TabIndex = 79;
            this.cellControl_4_6.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_6
            // 
            this.cellControl_3_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_6.Classroom = "101";
            this.cellControl_3_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_6.IsActive = false;
            this.cellControl_3_6.Location = new System.Drawing.Point(386, 381);
            this.cellControl_3_6.Name = "cellControl_3_6";
            this.cellControl_3_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_6.Subject = "Matematyka";
            this.cellControl_3_6.TabIndex = 78;
            this.cellControl_3_6.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_6
            // 
            this.cellControl_2_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_6.Classroom = "101";
            this.cellControl_2_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_6.IsActive = false;
            this.cellControl_2_6.Location = new System.Drawing.Point(252, 381);
            this.cellControl_2_6.Name = "cellControl_2_6";
            this.cellControl_2_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_6.Subject = "Matematyka";
            this.cellControl_2_6.TabIndex = 77;
            this.cellControl_2_6.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_6
            // 
            this.cellControl_1_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_6.Classroom = "101";
            this.cellControl_1_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_6.IsActive = false;
            this.cellControl_1_6.Location = new System.Drawing.Point(118, 381);
            this.cellControl_1_6.Name = "cellControl_1_6";
            this.cellControl_1_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_6.Subject = "Matematyka";
            this.cellControl_1_6.TabIndex = 76;
            this.cellControl_1_6.Teacher = "Adam Zielonka";
            // 
            // label_lp_7
            // 
            this.label_lp_7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_7.Location = new System.Drawing.Point(27, 444);
            this.label_lp_7.Name = "label_lp_7";
            this.label_lp_7.Size = new System.Drawing.Size(85, 57);
            this.label_lp_7.TabIndex = 75;
            this.label_lp_7.Text = "13:55 - 14:40";
            this.label_lp_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.Location = new System.Drawing.Point(2, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 57);
            this.label15.TabIndex = 74;
            this.label15.Text = "7";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lp_6
            // 
            this.label_lp_6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_6.Location = new System.Drawing.Point(27, 381);
            this.label_lp_6.Name = "label_lp_6";
            this.label_lp_6.Size = new System.Drawing.Size(85, 57);
            this.label_lp_6.TabIndex = 73;
            this.label_lp_6.Text = "12:35 - 13:25";
            this.label_lp_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label17.Location = new System.Drawing.Point(2, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 57);
            this.label17.TabIndex = 72;
            this.label17.Text = "6";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellControl_5_5
            // 
            this.cellControl_5_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_5.Classroom = "101";
            this.cellControl_5_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_5.IsActive = false;
            this.cellControl_5_5.Location = new System.Drawing.Point(654, 318);
            this.cellControl_5_5.Name = "cellControl_5_5";
            this.cellControl_5_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_5.Subject = "Matematyka";
            this.cellControl_5_5.TabIndex = 71;
            this.cellControl_5_5.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_5
            // 
            this.cellControl_4_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_5.Classroom = "101";
            this.cellControl_4_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_5.IsActive = false;
            this.cellControl_4_5.Location = new System.Drawing.Point(520, 318);
            this.cellControl_4_5.Name = "cellControl_4_5";
            this.cellControl_4_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_5.Subject = "Matematyka";
            this.cellControl_4_5.TabIndex = 70;
            this.cellControl_4_5.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_5
            // 
            this.cellControl_3_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_5.Classroom = "101";
            this.cellControl_3_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_5.IsActive = false;
            this.cellControl_3_5.Location = new System.Drawing.Point(386, 318);
            this.cellControl_3_5.Name = "cellControl_3_5";
            this.cellControl_3_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_5.Subject = "Matematyka";
            this.cellControl_3_5.TabIndex = 69;
            this.cellControl_3_5.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_5
            // 
            this.cellControl_2_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_5.Classroom = "101";
            this.cellControl_2_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_5.IsActive = false;
            this.cellControl_2_5.Location = new System.Drawing.Point(252, 318);
            this.cellControl_2_5.Name = "cellControl_2_5";
            this.cellControl_2_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_5.Subject = "Matematyka";
            this.cellControl_2_5.TabIndex = 68;
            this.cellControl_2_5.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_5
            // 
            this.cellControl_1_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_5.Classroom = "101";
            this.cellControl_1_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_5.IsActive = false;
            this.cellControl_1_5.Location = new System.Drawing.Point(118, 318);
            this.cellControl_1_5.Name = "cellControl_1_5";
            this.cellControl_1_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_5.Subject = "Matematyka";
            this.cellControl_1_5.TabIndex = 67;
            this.cellControl_1_5.Teacher = "Adam Zielonka";
            // 
            // cellControl_5_4
            // 
            this.cellControl_5_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_4.Classroom = "101";
            this.cellControl_5_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_4.IsActive = false;
            this.cellControl_5_4.Location = new System.Drawing.Point(654, 255);
            this.cellControl_5_4.Name = "cellControl_5_4";
            this.cellControl_5_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_4.Subject = "Matematyka";
            this.cellControl_5_4.TabIndex = 66;
            this.cellControl_5_4.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_4
            // 
            this.cellControl_4_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_4.Classroom = "101";
            this.cellControl_4_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_4.IsActive = false;
            this.cellControl_4_4.Location = new System.Drawing.Point(520, 255);
            this.cellControl_4_4.Name = "cellControl_4_4";
            this.cellControl_4_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_4.Subject = "Matematyka";
            this.cellControl_4_4.TabIndex = 65;
            this.cellControl_4_4.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_4
            // 
            this.cellControl_3_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_4.Classroom = "101";
            this.cellControl_3_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_4.IsActive = false;
            this.cellControl_3_4.Location = new System.Drawing.Point(386, 255);
            this.cellControl_3_4.Name = "cellControl_3_4";
            this.cellControl_3_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_4.Subject = "Matematyka";
            this.cellControl_3_4.TabIndex = 64;
            this.cellControl_3_4.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_4
            // 
            this.cellControl_2_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_4.Classroom = "101";
            this.cellControl_2_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_4.IsActive = false;
            this.cellControl_2_4.Location = new System.Drawing.Point(252, 255);
            this.cellControl_2_4.Name = "cellControl_2_4";
            this.cellControl_2_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_4.Subject = "Matematyka";
            this.cellControl_2_4.TabIndex = 63;
            this.cellControl_2_4.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_4
            // 
            this.cellControl_1_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_4.Classroom = "101";
            this.cellControl_1_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_4.IsActive = false;
            this.cellControl_1_4.Location = new System.Drawing.Point(118, 255);
            this.cellControl_1_4.Name = "cellControl_1_4";
            this.cellControl_1_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_4.Subject = "Matematyka";
            this.cellControl_1_4.TabIndex = 62;
            this.cellControl_1_4.Teacher = "Adam Zielonka";
            // 
            // label_lp_5
            // 
            this.label_lp_5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_5.Location = new System.Drawing.Point(27, 318);
            this.label_lp_5.Name = "label_lp_5";
            this.label_lp_5.Size = new System.Drawing.Size(85, 57);
            this.label_lp_5.TabIndex = 61;
            this.label_lp_5.Text = "11:40 - 12:25";
            this.label_lp_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label19.Location = new System.Drawing.Point(2, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 57);
            this.label19.TabIndex = 60;
            this.label19.Text = "5";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lp_4
            // 
            this.label_lp_4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_4.Location = new System.Drawing.Point(27, 255);
            this.label_lp_4.Name = "label_lp_4";
            this.label_lp_4.Size = new System.Drawing.Size(85, 57);
            this.label_lp_4.TabIndex = 59;
            this.label_lp_4.Text = "10:50 - 11:35";
            this.label_lp_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label21.Location = new System.Drawing.Point(2, 255);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 57);
            this.label21.TabIndex = 58;
            this.label21.Text = "4";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellControl_5_3
            // 
            this.cellControl_5_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_3.Classroom = "101";
            this.cellControl_5_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_3.IsActive = false;
            this.cellControl_5_3.Location = new System.Drawing.Point(654, 192);
            this.cellControl_5_3.Name = "cellControl_5_3";
            this.cellControl_5_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_3.Subject = "Matematyka";
            this.cellControl_5_3.TabIndex = 57;
            this.cellControl_5_3.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_3
            // 
            this.cellControl_4_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_3.Classroom = "101";
            this.cellControl_4_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_3.IsActive = false;
            this.cellControl_4_3.Location = new System.Drawing.Point(520, 192);
            this.cellControl_4_3.Name = "cellControl_4_3";
            this.cellControl_4_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_3.Subject = "Matematyka";
            this.cellControl_4_3.TabIndex = 56;
            this.cellControl_4_3.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_3
            // 
            this.cellControl_3_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_3.Classroom = "101";
            this.cellControl_3_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_3.IsActive = false;
            this.cellControl_3_3.Location = new System.Drawing.Point(386, 192);
            this.cellControl_3_3.Name = "cellControl_3_3";
            this.cellControl_3_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_3.Subject = "Matematyka";
            this.cellControl_3_3.TabIndex = 55;
            this.cellControl_3_3.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_3
            // 
            this.cellControl_2_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_3.Classroom = "101";
            this.cellControl_2_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_3.IsActive = false;
            this.cellControl_2_3.Location = new System.Drawing.Point(252, 192);
            this.cellControl_2_3.Name = "cellControl_2_3";
            this.cellControl_2_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_3.Subject = "Matematyka";
            this.cellControl_2_3.TabIndex = 54;
            this.cellControl_2_3.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_3
            // 
            this.cellControl_1_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_3.Classroom = "101";
            this.cellControl_1_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_3.IsActive = false;
            this.cellControl_1_3.Location = new System.Drawing.Point(118, 192);
            this.cellControl_1_3.Name = "cellControl_1_3";
            this.cellControl_1_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_3.Subject = "Matematyka";
            this.cellControl_1_3.TabIndex = 53;
            this.cellControl_1_3.Teacher = "Adam Zielonka";
            // 
            // cellControl_5_2
            // 
            this.cellControl_5_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_2.Classroom = "101";
            this.cellControl_5_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_2.IsActive = false;
            this.cellControl_5_2.Location = new System.Drawing.Point(654, 129);
            this.cellControl_5_2.Name = "cellControl_5_2";
            this.cellControl_5_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_2.Subject = "Matematyka";
            this.cellControl_5_2.TabIndex = 52;
            this.cellControl_5_2.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_2
            // 
            this.cellControl_4_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_2.Classroom = "101";
            this.cellControl_4_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_2.IsActive = false;
            this.cellControl_4_2.Location = new System.Drawing.Point(520, 129);
            this.cellControl_4_2.Name = "cellControl_4_2";
            this.cellControl_4_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_2.Subject = "Matematyka";
            this.cellControl_4_2.TabIndex = 51;
            this.cellControl_4_2.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_2
            // 
            this.cellControl_3_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_2.Classroom = "101";
            this.cellControl_3_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_2.IsActive = false;
            this.cellControl_3_2.Location = new System.Drawing.Point(386, 129);
            this.cellControl_3_2.Name = "cellControl_3_2";
            this.cellControl_3_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_2.Subject = "Matematyka";
            this.cellControl_3_2.TabIndex = 50;
            this.cellControl_3_2.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_2
            // 
            this.cellControl_2_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_2.Classroom = "101";
            this.cellControl_2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_2.IsActive = false;
            this.cellControl_2_2.Location = new System.Drawing.Point(252, 129);
            this.cellControl_2_2.Name = "cellControl_2_2";
            this.cellControl_2_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_2.Subject = "Matematyka";
            this.cellControl_2_2.TabIndex = 49;
            this.cellControl_2_2.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_2
            // 
            this.cellControl_1_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_2.Classroom = "101";
            this.cellControl_1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_2.IsActive = false;
            this.cellControl_1_2.Location = new System.Drawing.Point(118, 129);
            this.cellControl_1_2.Name = "cellControl_1_2";
            this.cellControl_1_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_2.Subject = "Matematyka";
            this.cellControl_1_2.TabIndex = 48;
            this.cellControl_1_2.Teacher = "Adam Zielonka";
            // 
            // label_lp_3
            // 
            this.label_lp_3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_3.Location = new System.Drawing.Point(27, 192);
            this.label_lp_3.Name = "label_lp_3";
            this.label_lp_3.Size = new System.Drawing.Size(85, 57);
            this.label_lp_3.TabIndex = 47;
            this.label_lp_3.Text = "9:50 - 10:35";
            this.label_lp_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(2, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 57);
            this.label11.TabIndex = 46;
            this.label11.Text = "3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lp_2
            // 
            this.label_lp_2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_2.Location = new System.Drawing.Point(27, 129);
            this.label_lp_2.Name = "label_lp_2";
            this.label_lp_2.Size = new System.Drawing.Size(85, 57);
            this.label_lp_2.TabIndex = 45;
            this.label_lp_2.Text = "8:55 - 9:40";
            this.label_lp_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.Location = new System.Drawing.Point(2, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 57);
            this.label13.TabIndex = 44;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellControl_5_1
            // 
            this.cellControl_5_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_1.Classroom = "101";
            this.cellControl_5_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_1.IsActive = false;
            this.cellControl_5_1.Location = new System.Drawing.Point(654, 66);
            this.cellControl_5_1.Name = "cellControl_5_1";
            this.cellControl_5_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_1.Subject = "Matematyka";
            this.cellControl_5_1.TabIndex = 43;
            this.cellControl_5_1.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_1
            // 
            this.cellControl_4_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_1.Classroom = "101";
            this.cellControl_4_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_1.IsActive = false;
            this.cellControl_4_1.Location = new System.Drawing.Point(520, 66);
            this.cellControl_4_1.Name = "cellControl_4_1";
            this.cellControl_4_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_1.Subject = "Matematyka";
            this.cellControl_4_1.TabIndex = 42;
            this.cellControl_4_1.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_1
            // 
            this.cellControl_3_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_1.Classroom = "101";
            this.cellControl_3_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_1.IsActive = false;
            this.cellControl_3_1.Location = new System.Drawing.Point(386, 66);
            this.cellControl_3_1.Name = "cellControl_3_1";
            this.cellControl_3_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_1.Subject = "Matematyka";
            this.cellControl_3_1.TabIndex = 41;
            this.cellControl_3_1.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_1
            // 
            this.cellControl_2_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_1.Classroom = "101";
            this.cellControl_2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_1.IsActive = false;
            this.cellControl_2_1.Location = new System.Drawing.Point(252, 66);
            this.cellControl_2_1.Name = "cellControl_2_1";
            this.cellControl_2_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_1.Subject = "Matematyka";
            this.cellControl_2_1.TabIndex = 40;
            this.cellControl_2_1.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_1
            // 
            this.cellControl_1_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_1.Classroom = "101";
            this.cellControl_1_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_1.IsActive = false;
            this.cellControl_1_1.Location = new System.Drawing.Point(118, 66);
            this.cellControl_1_1.Name = "cellControl_1_1";
            this.cellControl_1_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_1.Subject = "Matematyka";
            this.cellControl_1_1.TabIndex = 39;
            this.cellControl_1_1.Teacher = "Adam Zielonka";
            // 
            // cellControl_5_0
            // 
            this.cellControl_5_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_5_0.Classroom = "101";
            this.cellControl_5_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_5_0.IsActive = false;
            this.cellControl_5_0.Location = new System.Drawing.Point(654, 3);
            this.cellControl_5_0.Name = "cellControl_5_0";
            this.cellControl_5_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_5_0.Subject = "Matematyka";
            this.cellControl_5_0.TabIndex = 38;
            this.cellControl_5_0.Teacher = "Adam Zielonka";
            // 
            // cellControl_4_0
            // 
            this.cellControl_4_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_0.Classroom = "101";
            this.cellControl_4_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_0.IsActive = false;
            this.cellControl_4_0.Location = new System.Drawing.Point(520, 3);
            this.cellControl_4_0.Name = "cellControl_4_0";
            this.cellControl_4_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_0.Subject = "Matematyka";
            this.cellControl_4_0.TabIndex = 37;
            this.cellControl_4_0.Teacher = "Adam Zielonka";
            // 
            // cellControl_3_0
            // 
            this.cellControl_3_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_0.Classroom = "101";
            this.cellControl_3_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_0.IsActive = false;
            this.cellControl_3_0.Location = new System.Drawing.Point(386, 3);
            this.cellControl_3_0.Name = "cellControl_3_0";
            this.cellControl_3_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_0.Subject = "Matematyka";
            this.cellControl_3_0.TabIndex = 36;
            this.cellControl_3_0.Teacher = "Adam Zielonka";
            // 
            // cellControl_2_0
            // 
            this.cellControl_2_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_0.Classroom = "101";
            this.cellControl_2_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_0.IsActive = false;
            this.cellControl_2_0.Location = new System.Drawing.Point(252, 3);
            this.cellControl_2_0.Name = "cellControl_2_0";
            this.cellControl_2_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_0.Subject = "Matematyka";
            this.cellControl_2_0.TabIndex = 35;
            this.cellControl_2_0.Teacher = "Adam Zielonka";
            // 
            // cellControl_1_0
            // 
            this.cellControl_1_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_0.Classroom = "101";
            this.cellControl_1_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_0.IsActive = false;
            this.cellControl_1_0.Location = new System.Drawing.Point(118, 3);
            this.cellControl_1_0.Name = "cellControl_1_0";
            this.cellControl_1_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_0.Subject = "Matematyka";
            this.cellControl_1_0.TabIndex = 34;
            this.cellControl_1_0.Teacher = "Adam Zielonka";
            // 
            // label_lp_1
            // 
            this.label_lp_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_1.Location = new System.Drawing.Point(27, 66);
            this.label_lp_1.Name = "label_lp_1";
            this.label_lp_1.Size = new System.Drawing.Size(85, 57);
            this.label_lp_1.TabIndex = 33;
            this.label_lp_1.Text = "8:00 - 8:45";
            this.label_lp_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(2, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 57);
            this.label9.TabIndex = 32;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_lp_0
            // 
            this.label_lp_0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_lp_0.Location = new System.Drawing.Point(27, 3);
            this.label_lp_0.Name = "label_lp_0";
            this.label_lp_0.Size = new System.Drawing.Size(85, 57);
            this.label_lp_0.TabIndex = 31;
            this.label_lp_0.Text = "7:10 - 7:55";
            this.label_lp_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 57);
            this.label6.TabIndex = 30;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(890, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Piątek";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(756, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Czwartek";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(622, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Środa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(488, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 23);
            this.label22.TabIndex = 39;
            this.label22.Text = "Wtorek";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(354, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 23);
            this.label23.TabIndex = 38;
            this.label23.Text = "Poniedziałek";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView_objectsToView
            // 
            this.listView_objectsToView.FullRowSelect = true;
            this.listView_objectsToView.Location = new System.Drawing.Point(6, 143);
            this.listView_objectsToView.MultiSelect = false;
            this.listView_objectsToView.Name = "listView_objectsToView";
            this.listView_objectsToView.Size = new System.Drawing.Size(218, 309);
            this.listView_objectsToView.TabIndex = 44;
            this.listView_objectsToView.UseCompatibleStateImageBehavior = false;
            this.listView_objectsToView.View = System.Windows.Forms.View.Details;
            this.listView_objectsToView.SelectedIndexChanged += new System.EventHandler(this.listView_objectsToView_SelectedIndexChanged);
            // 
            // database_viewTableAdapter
            // 
            this.database_viewTableAdapter.ClearBeforeFill = true;
            // 
            // lessons_periodsTableAdapter
            // 
            this.lessons_periodsTableAdapter.ClearBeforeFill = true;
            // 
            // SchedulesViewingForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 582);
            this.Controls.Add(this.listView_objectsToView);
            this.Controls.Add(this.panelCells);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button_setClassromsView);
            this.Controls.Add(this.button_setTeacherView);
            this.Controls.Add(this.button_setClassesView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.button_ok);
            this.Name = "SchedulesViewingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przeglądaj plan";
            this.Load += new System.EventHandler(this.SchedulesViewingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelCells.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem itemMenu;
		private System.Windows.Forms.ToolStripMenuItem itemCreateSchedule;
        private System.Windows.Forms.ToolStripMenuItem itemAssignSubjects;
		private System.Windows.Forms.BindingSource classesBindingSource;
		private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
		private System.Windows.Forms.BindingSource studentsBindingSource;
        private DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button button_setClassesView;
        private System.Windows.Forms.Button button_setTeacherView;
        private System.Windows.Forms.Button button_setClassromsView;
        private DataSet dataSet1;
        private DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private DataSetTableAdapters.lessonsTableAdapter lessonsTableAdapter;
        private DataSetTableAdapters.classroomsTableAdapter classroomsTableAdapter;
        private System.Windows.Forms.Panel panelCells;
        private Controls.CellControl cellControl_5_7;
        private Controls.CellControl cellControl_4_7;
        private Controls.CellControl cellControl_3_7;
        private Controls.CellControl cellControl_2_7;
        private Controls.CellControl cellControl_1_7;
        private Controls.CellControl cellControl_5_6;
        private Controls.CellControl cellControl_4_6;
        private Controls.CellControl cellControl_3_6;
        private Controls.CellControl cellControl_2_6;
        private Controls.CellControl cellControl_1_6;
        private System.Windows.Forms.Label label_lp_7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_lp_6;
        private System.Windows.Forms.Label label17;
        private Controls.CellControl cellControl_5_5;
        private Controls.CellControl cellControl_4_5;
        private Controls.CellControl cellControl_3_5;
        private Controls.CellControl cellControl_2_5;
        private Controls.CellControl cellControl_1_5;
        private Controls.CellControl cellControl_5_4;
        private Controls.CellControl cellControl_4_4;
        private Controls.CellControl cellControl_3_4;
        private Controls.CellControl cellControl_2_4;
        private Controls.CellControl cellControl_1_4;
        private System.Windows.Forms.Label label_lp_5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_lp_4;
        private System.Windows.Forms.Label label21;
        private Controls.CellControl cellControl_5_3;
        private Controls.CellControl cellControl_4_3;
        private Controls.CellControl cellControl_3_3;
        private Controls.CellControl cellControl_2_3;
        private Controls.CellControl cellControl_1_3;
        private Controls.CellControl cellControl_5_2;
        private Controls.CellControl cellControl_4_2;
        private Controls.CellControl cellControl_3_2;
        private Controls.CellControl cellControl_2_2;
        private Controls.CellControl cellControl_1_2;
        private System.Windows.Forms.Label label_lp_3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_lp_2;
        private System.Windows.Forms.Label label13;
        private Controls.CellControl cellControl_5_1;
        private Controls.CellControl cellControl_4_1;
        private Controls.CellControl cellControl_3_1;
        private Controls.CellControl cellControl_2_1;
        private Controls.CellControl cellControl_1_1;
        private Controls.CellControl cellControl_5_0;
        private Controls.CellControl cellControl_4_0;
        private Controls.CellControl cellControl_3_0;
        private Controls.CellControl cellControl_2_0;
        private Controls.CellControl cellControl_1_0;
        private System.Windows.Forms.Label label_lp_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_lp_0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView listView_objectsToView;
        private DataSetTableAdapters.database_viewTableAdapter database_viewTableAdapter;
        private DataSetTableAdapters.lessons_periodsTableAdapter lessons_periodsTableAdapter;
	}
}