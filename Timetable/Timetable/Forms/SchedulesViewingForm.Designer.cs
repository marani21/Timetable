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
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNumber,
            this.columnTime,
            this.columnMonday,
            this.columnTuesday,
            this.columnWednesday,
            this.columnThursday,
            this.columnFriday});
            this.dataGridViewSchedule.Location = new System.Drawing.Point(15, 119);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.Size = new System.Drawing.Size(757, 285);
            this.dataGridViewSchedule.TabIndex = 2;
            // 
            // columnNumber
            // 
            this.columnNumber.Frozen = true;
            this.columnNumber.HeaderText = "Nr";
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.ReadOnly = true;
            this.columnNumber.Width = 40;
            // 
            // columnTime
            // 
            this.columnTime.HeaderText = "Godziny";
            this.columnTime.Name = "columnTime";
            // 
            // columnMonday
            // 
            this.columnMonday.HeaderText = "Poniedziałek";
            this.columnMonday.Name = "columnMonday";
            this.columnMonday.ReadOnly = true;
            this.columnMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnMonday.Width = 120;
            // 
            // columnTuesday
            // 
            this.columnTuesday.HeaderText = "Wtorek";
            this.columnTuesday.Name = "columnTuesday";
            this.columnTuesday.ReadOnly = true;
            this.columnTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnTuesday.Width = 120;
            // 
            // columnWednesday
            // 
            this.columnWednesday.HeaderText = "Środa";
            this.columnWednesday.Name = "columnWednesday";
            this.columnWednesday.ReadOnly = true;
            this.columnWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnWednesday.Width = 120;
            // 
            // columnThursday
            // 
            this.columnThursday.HeaderText = "Czwartek";
            this.columnThursday.Name = "columnThursday";
            this.columnThursday.ReadOnly = true;
            this.columnThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnThursday.Width = 120;
            // 
            // columnFriday
            // 
            this.columnFriday.HeaderText = "Piątek";
            this.columnFriday.Name = "columnFriday";
            this.columnFriday.ReadOnly = true;
            this.columnFriday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnFriday.Width = 120;
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
            this.label1.Location = new System.Drawing.Point(50, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nauczyciel:";
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClassroom.Location = new System.Drawing.Point(92, 499);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(42, 16);
            this.labelClassroom.TabIndex = 6;
            this.labelClassroom.Text = "[sala]";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeacher.Location = new System.Drawing.Point(92, 528);
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
            this.menuStrip.Size = new System.Drawing.Size(784, 31);
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
            this.comboBox_objectsToView.Location = new System.Drawing.Point(222, 60);
            this.comboBox_objectsToView.Name = "comboBox_objectsToView";
            this.comboBox_objectsToView.Size = new System.Drawing.Size(180, 21);
            this.comboBox_objectsToView.TabIndex = 1;
            // 
            // button_setClassesView
            // 
            this.button_setClassesView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_setClassesView.Image = global::Timetable.Properties.Resources.User_Group_icon;
            this.button_setClassesView.Location = new System.Drawing.Point(12, 35);
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
            this.button_setTeacherView.Location = new System.Drawing.Point(82, 36);
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
            this.button_setClassromsView.Location = new System.Drawing.Point(152, 36);
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
            // SchedulesViewingForm
            // 
            this.AcceptButton = this.button_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button_setClassromsView);
            this.Controls.Add(this.button_setTeacherView);
            this.Controls.Add(this.button_setClassesView);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClassroom);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.comboBox_objectsToView);
            this.Name = "SchedulesViewingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Przeglądaj plan";
            this.Load += new System.EventHandler(this.SchedulesViewingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
		private System.Windows.Forms.Button button_ok;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelTeacher;
		private System.Windows.Forms.Label labelClassroom;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnMonday;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTuesday;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnWednesday;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnThursday;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnFriday;
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
	}
}