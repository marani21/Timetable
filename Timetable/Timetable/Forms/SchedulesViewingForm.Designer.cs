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
			this.scheduleForComboBox = new System.Windows.Forms.ComboBox();
			this.scheduleForConcreteComboBox = new System.Windows.Forms.ComboBox();
			this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
			this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnMonday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnWednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnThursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnFriday = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelClassroom = new System.Windows.Forms.Label();
			this.labelTeacher = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.itemCreateSchedule = new System.Windows.Forms.ToolStripMenuItem();
			this.itemAssignSubjects = new System.Windows.Forms.ToolStripMenuItem();
			this.dataSet = new Timetable.DataSet();
			this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.classesTableAdapter = new Timetable.DataSetTableAdapters.classesTableAdapter();
			this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.studentsTableAdapter = new Timetable.DataSetTableAdapters.studentsTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// scheduleForComboBox
			// 
			this.scheduleForComboBox.FormattingEnabled = true;
			this.scheduleForComboBox.Location = new System.Drawing.Point(12, 52);
			this.scheduleForComboBox.Name = "scheduleForComboBox";
			this.scheduleForComboBox.Size = new System.Drawing.Size(184, 21);
			this.scheduleForComboBox.TabIndex = 0;
			// 
			// scheduleForConcreteComboBox
			// 
			this.scheduleForConcreteComboBox.DataSource = this.studentsBindingSource;
			this.scheduleForConcreteComboBox.DisplayMember = "name";
			this.scheduleForConcreteComboBox.FormattingEnabled = true;
			this.scheduleForConcreteComboBox.Location = new System.Drawing.Point(202, 52);
			this.scheduleForConcreteComboBox.Name = "scheduleForConcreteComboBox";
			this.scheduleForConcreteComboBox.Size = new System.Drawing.Size(180, 21);
			this.scheduleForConcreteComboBox.TabIndex = 1;
			this.scheduleForConcreteComboBox.ValueMember = "pesel";
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
			this.dataGridViewSchedule.Location = new System.Drawing.Point(12, 90);
			this.dataGridViewSchedule.Name = "dataGridViewSchedule";
			this.dataGridViewSchedule.Size = new System.Drawing.Size(782, 246);
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
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(701, 390);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(91, 29);
			this.buttonOk.TabIndex = 3;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(50, 355);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Sala:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(12, 384);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nauczyciel:";
			// 
			// labelClassroom
			// 
			this.labelClassroom.AutoSize = true;
			this.labelClassroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelClassroom.Location = new System.Drawing.Point(92, 355);
			this.labelClassroom.Name = "labelClassroom";
			this.labelClassroom.Size = new System.Drawing.Size(42, 16);
			this.labelClassroom.TabIndex = 6;
			this.labelClassroom.Text = "[sala]";
			// 
			// labelTeacher
			// 
			this.labelTeacher.AutoSize = true;
			this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelTeacher.Location = new System.Drawing.Point(92, 384);
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
			this.menuStrip.Size = new System.Drawing.Size(804, 31);
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
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// classesBindingSource
			// 
			this.classesBindingSource.DataMember = "classes";
			this.classesBindingSource.DataSource = this.dataSet;
			// 
			// classesTableAdapter
			// 
			this.classesTableAdapter.ClearBeforeFill = true;
			// 
			// studentsBindingSource
			// 
			this.studentsBindingSource.DataMember = "students";
			this.studentsBindingSource.DataSource = this.dataSet;
			// 
			// studentsTableAdapter
			// 
			this.studentsTableAdapter.ClearBeforeFill = true;
			// 
			// SchedulesViewingForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 431);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.labelTeacher);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelClassroom);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewSchedule);
			this.Controls.Add(this.scheduleForConcreteComboBox);
			this.Controls.Add(this.scheduleForComboBox);
			this.Name = "SchedulesViewingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Przeglądaj plan";
			this.Load += new System.EventHandler(this.SchedulesViewingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox scheduleForComboBox;
		private System.Windows.Forms.ComboBox scheduleForConcreteComboBox;
		private System.Windows.Forms.DataGridView dataGridViewSchedule;
		private System.Windows.Forms.Button buttonOk;
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
		private DataSet dataSet;
		private System.Windows.Forms.BindingSource classesBindingSource;
		private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
		private System.Windows.Forms.BindingSource studentsBindingSource;
		private DataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
	}
}