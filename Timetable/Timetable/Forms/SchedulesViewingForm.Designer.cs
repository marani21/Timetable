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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelClassroom = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCreateSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAssignSubjects = new System.Windows.Forms.ToolStripMenuItem();
            this.classesTableAdapter = new Timetable.DataSetTableAdapters.classesTableAdapter();
            this.studentsTableAdapter = new Timetable.DataSetTableAdapters.studentsTableAdapter();
            this.comboBox_objectsToView = new System.Windows.Forms.ComboBox();
            this.button_setClassesView = new System.Windows.Forms.Button();
            this.button_setTeacherView = new System.Windows.Forms.Button();
            this.button_setClassromsView = new System.Windows.Forms.Button();
            this.dataSet1 = new Timetable.DataSet();
            this.teachersTableAdapter = new Timetable.DataSetTableAdapters.teachersTableAdapter();
            this.lessonsTableAdapter = new Timetable.DataSetTableAdapters.lessonsTableAdapter();
            this.classroomsTableAdapter = new Timetable.DataSetTableAdapters.classroomsTableAdapter();
            this.panelCells = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cellControl_4_7 = new Timetable.Controls.CellControl();
            this.cellControl_3_7 = new Timetable.Controls.CellControl();
            this.cellControl_2_7 = new Timetable.Controls.CellControl();
            this.cellControl_1_7 = new Timetable.Controls.CellControl();
            this.cellControl_0_7 = new Timetable.Controls.CellControl();
            this.cellControl_4_6 = new Timetable.Controls.CellControl();
            this.cellControl_3_6 = new Timetable.Controls.CellControl();
            this.cellControl_2_6 = new Timetable.Controls.CellControl();
            this.cellControl_1_6 = new Timetable.Controls.CellControl();
            this.cellControl_0_6 = new Timetable.Controls.CellControl();
            this.cellControl_4_5 = new Timetable.Controls.CellControl();
            this.cellControl_3_5 = new Timetable.Controls.CellControl();
            this.cellControl_2_5 = new Timetable.Controls.CellControl();
            this.cellControl_1_5 = new Timetable.Controls.CellControl();
            this.cellControl_0_5 = new Timetable.Controls.CellControl();
            this.cellControl_4_4 = new Timetable.Controls.CellControl();
            this.cellControl_3_4 = new Timetable.Controls.CellControl();
            this.cellControl_2_4 = new Timetable.Controls.CellControl();
            this.cellControl_1_4 = new Timetable.Controls.CellControl();
            this.cellControl_0_4 = new Timetable.Controls.CellControl();
            this.cellControl_4_3 = new Timetable.Controls.CellControl();
            this.cellControl_3_3 = new Timetable.Controls.CellControl();
            this.cellControl_2_3 = new Timetable.Controls.CellControl();
            this.cellControl_1_3 = new Timetable.Controls.CellControl();
            this.cellControl_0_3 = new Timetable.Controls.CellControl();
            this.cellControl_4_2 = new Timetable.Controls.CellControl();
            this.cellControl_3_2 = new Timetable.Controls.CellControl();
            this.cellControl_2_2 = new Timetable.Controls.CellControl();
            this.cellControl_1_2 = new Timetable.Controls.CellControl();
            this.cellControl_0_2 = new Timetable.Controls.CellControl();
            this.cellControl_4_1 = new Timetable.Controls.CellControl();
            this.cellControl_3_1 = new Timetable.Controls.CellControl();
            this.cellControl_2_1 = new Timetable.Controls.CellControl();
            this.cellControl_1_1 = new Timetable.Controls.CellControl();
            this.cellControl_0_1 = new Timetable.Controls.CellControl();
            this.cellControl_4_0 = new Timetable.Controls.CellControl();
            this.cellControl_3_0 = new Timetable.Controls.CellControl();
            this.cellControl_2_0 = new Timetable.Controls.CellControl();
            this.cellControl_1_0 = new Timetable.Controls.CellControl();
            this.cellControl_0_0 = new Timetable.Controls.CellControl();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelCells.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(681, 522);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(91, 29);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nauczyciel:";
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClassroom.Location = new System.Drawing.Point(89, 166);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(42, 16);
            this.labelClassroom.TabIndex = 6;
            this.labelClassroom.Text = "[sala]";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeacher.Location = new System.Drawing.Point(89, 195);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(79, 16);
            this.labelTeacher.TabIndex = 7;
            this.labelTeacher.Text = "[nauczyciel]";
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
            this.menuStrip.Size = new System.Drawing.Size(1050, 31);
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
            // comboBox_objectsToView
            // 
            this.comboBox_objectsToView.FormattingEnabled = true;
            this.comboBox_objectsToView.Location = new System.Drawing.Point(6, 129);
            this.comboBox_objectsToView.Name = "comboBox_objectsToView";
            this.comboBox_objectsToView.Size = new System.Drawing.Size(202, 21);
            this.comboBox_objectsToView.TabIndex = 1;
            this.comboBox_objectsToView.SelectedIndexChanged += new System.EventHandler(this.comboBox_objectsToView_SelectedIndexChanged);
            // 
            // button_setClassesView
            // 
            this.button_setClassesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setClassesView.Image = global::Timetable.Properties.Resources.User_Group_icon;
            this.button_setClassesView.Location = new System.Drawing.Point(6, 59);
            this.button_setClassesView.Name = "button_setClassesView";
            this.button_setClassesView.Size = new System.Drawing.Size(64, 64);
            this.button_setClassesView.TabIndex = 15;
            this.button_setClassesView.Text = "Class";
            this.button_setClassesView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_setClassesView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_setClassesView.UseVisualStyleBackColor = true;
            this.button_setClassesView.Click += new System.EventHandler(this.button_setClassesView_Click);
            // 
            // button_setTeacherView
            // 
            this.button_setTeacherView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setTeacherView.Image = global::Timetable.Properties.Resources.Teacher_icon;
            this.button_setTeacherView.Location = new System.Drawing.Point(75, 59);
            this.button_setTeacherView.Name = "button_setTeacherView";
            this.button_setTeacherView.Size = new System.Drawing.Size(64, 64);
            this.button_setTeacherView.TabIndex = 16;
            this.button_setTeacherView.Text = "Teachers";
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
            this.button_setClassromsView.Location = new System.Drawing.Point(144, 59);
            this.button_setClassromsView.Name = "button_setClassromsView";
            this.button_setClassromsView.Size = new System.Drawing.Size(64, 64);
            this.button_setClassromsView.TabIndex = 17;
            this.button_setClassromsView.Text = "Classroms";
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
            this.panelCells.Controls.Add(this.cellControl_4_7);
            this.panelCells.Controls.Add(this.cellControl_3_7);
            this.panelCells.Controls.Add(this.cellControl_2_7);
            this.panelCells.Controls.Add(this.cellControl_1_7);
            this.panelCells.Controls.Add(this.cellControl_0_7);
            this.panelCells.Controls.Add(this.cellControl_4_6);
            this.panelCells.Controls.Add(this.cellControl_3_6);
            this.panelCells.Controls.Add(this.cellControl_2_6);
            this.panelCells.Controls.Add(this.cellControl_1_6);
            this.panelCells.Controls.Add(this.cellControl_0_6);
            this.panelCells.Controls.Add(this.label14);
            this.panelCells.Controls.Add(this.label15);
            this.panelCells.Controls.Add(this.label16);
            this.panelCells.Controls.Add(this.label17);
            this.panelCells.Controls.Add(this.cellControl_4_5);
            this.panelCells.Controls.Add(this.cellControl_3_5);
            this.panelCells.Controls.Add(this.cellControl_2_5);
            this.panelCells.Controls.Add(this.cellControl_1_5);
            this.panelCells.Controls.Add(this.cellControl_0_5);
            this.panelCells.Controls.Add(this.cellControl_4_4);
            this.panelCells.Controls.Add(this.cellControl_3_4);
            this.panelCells.Controls.Add(this.cellControl_2_4);
            this.panelCells.Controls.Add(this.cellControl_1_4);
            this.panelCells.Controls.Add(this.cellControl_0_4);
            this.panelCells.Controls.Add(this.label18);
            this.panelCells.Controls.Add(this.label19);
            this.panelCells.Controls.Add(this.label20);
            this.panelCells.Controls.Add(this.label21);
            this.panelCells.Controls.Add(this.cellControl_4_3);
            this.panelCells.Controls.Add(this.cellControl_3_3);
            this.panelCells.Controls.Add(this.cellControl_2_3);
            this.panelCells.Controls.Add(this.cellControl_1_3);
            this.panelCells.Controls.Add(this.cellControl_0_3);
            this.panelCells.Controls.Add(this.cellControl_4_2);
            this.panelCells.Controls.Add(this.cellControl_3_2);
            this.panelCells.Controls.Add(this.cellControl_2_2);
            this.panelCells.Controls.Add(this.cellControl_1_2);
            this.panelCells.Controls.Add(this.cellControl_0_2);
            this.panelCells.Controls.Add(this.label10);
            this.panelCells.Controls.Add(this.label11);
            this.panelCells.Controls.Add(this.label12);
            this.panelCells.Controls.Add(this.label13);
            this.panelCells.Controls.Add(this.cellControl_4_1);
            this.panelCells.Controls.Add(this.cellControl_3_1);
            this.panelCells.Controls.Add(this.cellControl_2_1);
            this.panelCells.Controls.Add(this.cellControl_1_1);
            this.panelCells.Controls.Add(this.cellControl_0_1);
            this.panelCells.Controls.Add(this.cellControl_4_0);
            this.panelCells.Controls.Add(this.cellControl_3_0);
            this.panelCells.Controls.Add(this.cellControl_2_0);
            this.panelCells.Controls.Add(this.cellControl_1_0);
            this.panelCells.Controls.Add(this.cellControl_0_0);
            this.panelCells.Controls.Add(this.label8);
            this.panelCells.Controls.Add(this.label9);
            this.panelCells.Controls.Add(this.label7);
            this.panelCells.Controls.Add(this.label6);
            this.panelCells.Location = new System.Drawing.Point(214, 59);
            this.panelCells.Name = "panelCells";
            this.panelCells.Size = new System.Drawing.Size(805, 503);
            this.panelCells.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label14.Location = new System.Drawing.Point(41, 444);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 57);
            this.label14.TabIndex = 75;
            this.label14.Text = "7:30 - 8:15";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label15.Location = new System.Drawing.Point(2, 444);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 57);
            this.label15.TabIndex = 74;
            this.label15.Text = "7";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label16.Location = new System.Drawing.Point(41, 381);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 57);
            this.label16.TabIndex = 73;
            this.label16.Text = "7:30 - 8:15";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label17.Location = new System.Drawing.Point(2, 381);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 57);
            this.label17.TabIndex = 72;
            this.label17.Text = "6";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label18.Location = new System.Drawing.Point(41, 318);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 57);
            this.label18.TabIndex = 61;
            this.label18.Text = "7:30 - 8:15";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label19.Location = new System.Drawing.Point(2, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 57);
            this.label19.TabIndex = 60;
            this.label19.Text = "5";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label20.Location = new System.Drawing.Point(41, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 57);
            this.label20.TabIndex = 59;
            this.label20.Text = "7:30 - 8:15";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label21.Location = new System.Drawing.Point(2, 255);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 57);
            this.label21.TabIndex = 58;
            this.label21.Text = "4";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(41, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 57);
            this.label10.TabIndex = 47;
            this.label10.Text = "7:30 - 8:15";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label11.Location = new System.Drawing.Point(2, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 57);
            this.label11.TabIndex = 46;
            this.label11.Text = "3";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(41, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 57);
            this.label12.TabIndex = 45;
            this.label12.Text = "7:30 - 8:15";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label13.Location = new System.Drawing.Point(2, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 57);
            this.label13.TabIndex = 44;
            this.label13.Text = "2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(41, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 57);
            this.label8.TabIndex = 33;
            this.label8.Text = "7:30 - 8:15";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label9.Location = new System.Drawing.Point(2, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 57);
            this.label9.TabIndex = 32;
            this.label9.Text = "1";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(41, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 57);
            this.label7.TabIndex = 31;
            this.label7.Text = "7:30 - 8:15";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label6.Location = new System.Drawing.Point(2, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 57);
            this.label6.TabIndex = 30;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(879, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Piątek";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(745, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Czwartek";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(611, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Środa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(477, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(128, 23);
            this.label22.TabIndex = 39;
            this.label22.Text = "Wtorek";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(343, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(128, 23);
            this.label23.TabIndex = 38;
            this.label23.Text = "Poniedziałek";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellControl_4_7
            // 
            this.cellControl_4_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_7.Location = new System.Drawing.Point(668, 444);
            this.cellControl_4_7.Name = "cellControl_4_7";
            this.cellControl_4_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_7.TabIndex = 85;
            // 
            // cellControl_3_7
            // 
            this.cellControl_3_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_7.Location = new System.Drawing.Point(534, 444);
            this.cellControl_3_7.Name = "cellControl_3_7";
            this.cellControl_3_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_7.TabIndex = 84;
            // 
            // cellControl_2_7
            // 
            this.cellControl_2_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_7.Location = new System.Drawing.Point(400, 444);
            this.cellControl_2_7.Name = "cellControl_2_7";
            this.cellControl_2_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_7.TabIndex = 83;
            // 
            // cellControl_1_7
            // 
            this.cellControl_1_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_7.Location = new System.Drawing.Point(266, 444);
            this.cellControl_1_7.Name = "cellControl_1_7";
            this.cellControl_1_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_7.TabIndex = 82;
            // 
            // cellControl_0_7
            // 
            this.cellControl_0_7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_7.Location = new System.Drawing.Point(132, 444);
            this.cellControl_0_7.Name = "cellControl_0_7";
            this.cellControl_0_7.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_7.TabIndex = 81;
            // 
            // cellControl_4_6
            // 
            this.cellControl_4_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_6.Location = new System.Drawing.Point(668, 381);
            this.cellControl_4_6.Name = "cellControl_4_6";
            this.cellControl_4_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_6.TabIndex = 80;
            // 
            // cellControl_3_6
            // 
            this.cellControl_3_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_6.Location = new System.Drawing.Point(534, 381);
            this.cellControl_3_6.Name = "cellControl_3_6";
            this.cellControl_3_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_6.TabIndex = 79;
            // 
            // cellControl_2_6
            // 
            this.cellControl_2_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_6.Location = new System.Drawing.Point(400, 381);
            this.cellControl_2_6.Name = "cellControl_2_6";
            this.cellControl_2_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_6.TabIndex = 78;
            // 
            // cellControl_1_6
            // 
            this.cellControl_1_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_6.Location = new System.Drawing.Point(266, 381);
            this.cellControl_1_6.Name = "cellControl_1_6";
            this.cellControl_1_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_6.TabIndex = 77;
            // 
            // cellControl_0_6
            // 
            this.cellControl_0_6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_6.Location = new System.Drawing.Point(132, 381);
            this.cellControl_0_6.Name = "cellControl_0_6";
            this.cellControl_0_6.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_6.TabIndex = 76;
            // 
            // cellControl_4_5
            // 
            this.cellControl_4_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_5.Location = new System.Drawing.Point(668, 318);
            this.cellControl_4_5.Name = "cellControl_4_5";
            this.cellControl_4_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_5.TabIndex = 71;
            // 
            // cellControl_3_5
            // 
            this.cellControl_3_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_5.Location = new System.Drawing.Point(534, 318);
            this.cellControl_3_5.Name = "cellControl_3_5";
            this.cellControl_3_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_5.TabIndex = 70;
            // 
            // cellControl_2_5
            // 
            this.cellControl_2_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_5.Location = new System.Drawing.Point(400, 318);
            this.cellControl_2_5.Name = "cellControl_2_5";
            this.cellControl_2_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_5.TabIndex = 69;
            // 
            // cellControl_1_5
            // 
            this.cellControl_1_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_5.Location = new System.Drawing.Point(266, 318);
            this.cellControl_1_5.Name = "cellControl_1_5";
            this.cellControl_1_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_5.TabIndex = 68;
            // 
            // cellControl_0_5
            // 
            this.cellControl_0_5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_5.Location = new System.Drawing.Point(132, 318);
            this.cellControl_0_5.Name = "cellControl_0_5";
            this.cellControl_0_5.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_5.TabIndex = 67;
            // 
            // cellControl_4_4
            // 
            this.cellControl_4_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_4.Location = new System.Drawing.Point(668, 255);
            this.cellControl_4_4.Name = "cellControl_4_4";
            this.cellControl_4_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_4.TabIndex = 66;
            // 
            // cellControl_3_4
            // 
            this.cellControl_3_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_4.Location = new System.Drawing.Point(534, 255);
            this.cellControl_3_4.Name = "cellControl_3_4";
            this.cellControl_3_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_4.TabIndex = 65;
            // 
            // cellControl_2_4
            // 
            this.cellControl_2_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_4.Location = new System.Drawing.Point(400, 255);
            this.cellControl_2_4.Name = "cellControl_2_4";
            this.cellControl_2_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_4.TabIndex = 64;
            // 
            // cellControl_1_4
            // 
            this.cellControl_1_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_4.Location = new System.Drawing.Point(266, 255);
            this.cellControl_1_4.Name = "cellControl_1_4";
            this.cellControl_1_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_4.TabIndex = 63;
            // 
            // cellControl_0_4
            // 
            this.cellControl_0_4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_4.Location = new System.Drawing.Point(132, 255);
            this.cellControl_0_4.Name = "cellControl_0_4";
            this.cellControl_0_4.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_4.TabIndex = 62;
            // 
            // cellControl_4_3
            // 
            this.cellControl_4_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_3.Location = new System.Drawing.Point(668, 192);
            this.cellControl_4_3.Name = "cellControl_4_3";
            this.cellControl_4_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_3.TabIndex = 57;
            // 
            // cellControl_3_3
            // 
            this.cellControl_3_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_3.Location = new System.Drawing.Point(534, 192);
            this.cellControl_3_3.Name = "cellControl_3_3";
            this.cellControl_3_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_3.TabIndex = 56;
            // 
            // cellControl_2_3
            // 
            this.cellControl_2_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_3.Location = new System.Drawing.Point(400, 192);
            this.cellControl_2_3.Name = "cellControl_2_3";
            this.cellControl_2_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_3.TabIndex = 55;
            // 
            // cellControl_1_3
            // 
            this.cellControl_1_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_3.Location = new System.Drawing.Point(266, 192);
            this.cellControl_1_3.Name = "cellControl_1_3";
            this.cellControl_1_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_3.TabIndex = 54;
            // 
            // cellControl_0_3
            // 
            this.cellControl_0_3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_3.Location = new System.Drawing.Point(132, 192);
            this.cellControl_0_3.Name = "cellControl_0_3";
            this.cellControl_0_3.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_3.TabIndex = 53;
            // 
            // cellControl_4_2
            // 
            this.cellControl_4_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_2.Location = new System.Drawing.Point(668, 129);
            this.cellControl_4_2.Name = "cellControl_4_2";
            this.cellControl_4_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_2.TabIndex = 52;
            // 
            // cellControl_3_2
            // 
            this.cellControl_3_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_2.Location = new System.Drawing.Point(534, 129);
            this.cellControl_3_2.Name = "cellControl_3_2";
            this.cellControl_3_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_2.TabIndex = 51;
            // 
            // cellControl_2_2
            // 
            this.cellControl_2_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_2.Location = new System.Drawing.Point(400, 129);
            this.cellControl_2_2.Name = "cellControl_2_2";
            this.cellControl_2_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_2.TabIndex = 50;
            // 
            // cellControl_1_2
            // 
            this.cellControl_1_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_2.Location = new System.Drawing.Point(266, 129);
            this.cellControl_1_2.Name = "cellControl_1_2";
            this.cellControl_1_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_2.TabIndex = 49;
            // 
            // cellControl_0_2
            // 
            this.cellControl_0_2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_2.Location = new System.Drawing.Point(132, 129);
            this.cellControl_0_2.Name = "cellControl_0_2";
            this.cellControl_0_2.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_2.TabIndex = 48;
            // 
            // cellControl_4_1
            // 
            this.cellControl_4_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_1.Location = new System.Drawing.Point(668, 66);
            this.cellControl_4_1.Name = "cellControl_4_1";
            this.cellControl_4_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_1.TabIndex = 43;
            // 
            // cellControl_3_1
            // 
            this.cellControl_3_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_1.Location = new System.Drawing.Point(534, 66);
            this.cellControl_3_1.Name = "cellControl_3_1";
            this.cellControl_3_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_1.TabIndex = 42;
            // 
            // cellControl_2_1
            // 
            this.cellControl_2_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_1.Location = new System.Drawing.Point(400, 66);
            this.cellControl_2_1.Name = "cellControl_2_1";
            this.cellControl_2_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_1.TabIndex = 41;
            // 
            // cellControl_1_1
            // 
            this.cellControl_1_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_1.Location = new System.Drawing.Point(266, 66);
            this.cellControl_1_1.Name = "cellControl_1_1";
            this.cellControl_1_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_1.TabIndex = 40;
            // 
            // cellControl_0_1
            // 
            this.cellControl_0_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_1.Location = new System.Drawing.Point(132, 66);
            this.cellControl_0_1.Name = "cellControl_0_1";
            this.cellControl_0_1.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_1.TabIndex = 39;
            // 
            // cellControl_4_0
            // 
            this.cellControl_4_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_4_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_4_0.Location = new System.Drawing.Point(668, 3);
            this.cellControl_4_0.Name = "cellControl_4_0";
            this.cellControl_4_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_4_0.TabIndex = 38;
            // 
            // cellControl_3_0
            // 
            this.cellControl_3_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_3_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_3_0.Location = new System.Drawing.Point(534, 3);
            this.cellControl_3_0.Name = "cellControl_3_0";
            this.cellControl_3_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_3_0.TabIndex = 37;
            // 
            // cellControl_2_0
            // 
            this.cellControl_2_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_2_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_2_0.Location = new System.Drawing.Point(400, 3);
            this.cellControl_2_0.Name = "cellControl_2_0";
            this.cellControl_2_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_2_0.TabIndex = 36;
            // 
            // cellControl_1_0
            // 
            this.cellControl_1_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_1_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_1_0.Location = new System.Drawing.Point(266, 3);
            this.cellControl_1_0.Name = "cellControl_1_0";
            this.cellControl_1_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_1_0.TabIndex = 35;
            // 
            // cellControl_0_0
            // 
            this.cellControl_0_0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cellControl_0_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cellControl_0_0.Location = new System.Drawing.Point(132, 3);
            this.cellControl_0_0.Name = "cellControl_0_0";
            this.cellControl_0_0.Size = new System.Drawing.Size(128, 57);
            this.cellControl_0_0.TabIndex = 34;
            // 
            // SchedulesViewingForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 596);
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
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClassroom);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_objectsToView);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelClassroom;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem itemMenu;
		private System.Windows.Forms.ToolStripMenuItem itemCreateSchedule;
        private System.Windows.Forms.ToolStripMenuItem itemAssignSubjects;
		private System.Windows.Forms.BindingSource classesBindingSource;
		private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_objectsToView;
        private System.Windows.Forms.Button button_setClassesView;
        private System.Windows.Forms.Button button_setTeacherView;
        private System.Windows.Forms.Button button_setClassromsView;
        private DataSet dataSet1;
        private DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private DataSetTableAdapters.lessonsTableAdapter lessonsTableAdapter;
        private DataSetTableAdapters.classroomsTableAdapter classroomsTableAdapter;
        private System.Windows.Forms.Panel panelCells;
        private Controls.CellControl cellControl_4_7;
        private Controls.CellControl cellControl_3_7;
        private Controls.CellControl cellControl_2_7;
        private Controls.CellControl cellControl_1_7;
        private Controls.CellControl cellControl_0_7;
        private Controls.CellControl cellControl_4_6;
        private Controls.CellControl cellControl_3_6;
        private Controls.CellControl cellControl_2_6;
        private Controls.CellControl cellControl_1_6;
        private Controls.CellControl cellControl_0_6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Controls.CellControl cellControl_4_5;
        private Controls.CellControl cellControl_3_5;
        private Controls.CellControl cellControl_2_5;
        private Controls.CellControl cellControl_1_5;
        private Controls.CellControl cellControl_0_5;
        private Controls.CellControl cellControl_4_4;
        private Controls.CellControl cellControl_3_4;
        private Controls.CellControl cellControl_2_4;
        private Controls.CellControl cellControl_1_4;
        private Controls.CellControl cellControl_0_4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Controls.CellControl cellControl_4_3;
        private Controls.CellControl cellControl_3_3;
        private Controls.CellControl cellControl_2_3;
        private Controls.CellControl cellControl_1_3;
        private Controls.CellControl cellControl_0_3;
        private Controls.CellControl cellControl_4_2;
        private Controls.CellControl cellControl_3_2;
        private Controls.CellControl cellControl_2_2;
        private Controls.CellControl cellControl_1_2;
        private Controls.CellControl cellControl_0_2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Controls.CellControl cellControl_4_1;
        private Controls.CellControl cellControl_3_1;
        private Controls.CellControl cellControl_2_1;
        private Controls.CellControl cellControl_1_1;
        private Controls.CellControl cellControl_0_1;
        private Controls.CellControl cellControl_4_0;
        private Controls.CellControl cellControl_3_0;
        private Controls.CellControl cellControl_2_0;
        private Controls.CellControl cellControl_1_0;
        private Controls.CellControl cellControl_0_0;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
	}
}