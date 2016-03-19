namespace Timetable
{
	partial class ScheduleCreationForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxClasses = new System.Windows.Forms.ComboBox();
			this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
			this.columnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnMonday = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnTuesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnWednesday = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnThursday = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.columnFriday = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.labelTeacher = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.itemMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.itemViewSchedules = new System.Windows.Forms.ToolStripMenuItem();
			this.itemAssignSubjects = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Plan dla klasy ";
			// 
			// comboBoxClasses
			// 
			this.comboBoxClasses.FormattingEnabled = true;
			this.comboBoxClasses.Location = new System.Drawing.Point(94, 57);
			this.comboBoxClasses.Name = "comboBoxClasses";
			this.comboBoxClasses.Size = new System.Drawing.Size(121, 21);
			this.comboBoxClasses.TabIndex = 5;
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
			this.dataGridViewSchedule.TabIndex = 6;
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
			this.columnTime.ReadOnly = true;
			// 
			// columnMonday
			// 
			this.columnMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.columnMonday.HeaderText = "Poniedziałek";
			this.columnMonday.Name = "columnMonday";
			this.columnMonday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnMonday.Width = 120;
			// 
			// columnTuesday
			// 
			this.columnTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.columnTuesday.HeaderText = "Wtorek";
			this.columnTuesday.Name = "columnTuesday";
			this.columnTuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnTuesday.Width = 120;
			// 
			// columnWednesday
			// 
			this.columnWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.columnWednesday.HeaderText = "Środa";
			this.columnWednesday.Name = "columnWednesday";
			this.columnWednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnWednesday.Width = 120;
			// 
			// columnThursday
			// 
			this.columnThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.columnThursday.HeaderText = "Czwartek";
			this.columnThursday.Name = "columnThursday";
			this.columnThursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnThursday.Width = 120;
			// 
			// columnFriday
			// 
			this.columnFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.columnFriday.HeaderText = "Piątek";
			this.columnFriday.Name = "columnFriday";
			this.columnFriday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.columnFriday.Width = 120;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(51, 355);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "Sala:";
			// 
			// comboBoxTeacher
			// 
			this.comboBoxTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBoxTeacher.FormattingEnabled = true;
			this.comboBoxTeacher.Location = new System.Drawing.Point(95, 352);
			this.comboBoxTeacher.Name = "comboBoxTeacher";
			this.comboBoxTeacher.Size = new System.Drawing.Size(121, 24);
			this.comboBoxTeacher.TabIndex = 8;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(701, 390);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(91, 29);
			this.buttonOk.TabIndex = 9;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(13, 385);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Nauczyciel:";
			// 
			// labelTeacher
			// 
			this.labelTeacher.AutoSize = true;
			this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelTeacher.Location = new System.Drawing.Point(92, 385);
			this.labelTeacher.Name = "labelTeacher";
			this.labelTeacher.Size = new System.Drawing.Size(79, 16);
			this.labelTeacher.TabIndex = 12;
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
			this.menuStrip.TabIndex = 13;
			this.menuStrip.Text = "menuStrip1";
			// 
			// itemMenu
			// 
			this.itemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemViewSchedules,
            this.itemAssignSubjects});
			this.itemMenu.Name = "itemMenu";
			this.itemMenu.Padding = new System.Windows.Forms.Padding(30, 3, 30, 3);
			this.itemMenu.Size = new System.Drawing.Size(105, 27);
			this.itemMenu.Text = "Menu";
			// 
			// itemViewSchedules
			// 
			this.itemViewSchedules.Name = "itemViewSchedules";
			this.itemViewSchedules.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.itemViewSchedules.Size = new System.Drawing.Size(197, 30);
			this.itemViewSchedules.Text = "Przegladaj plany";
			// 
			// itemAssignSubjects
			// 
			this.itemAssignSubjects.Name = "itemAssignSubjects";
			this.itemAssignSubjects.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.itemAssignSubjects.Size = new System.Drawing.Size(197, 30);
			this.itemAssignSubjects.Text = "Przydziel przedmioty";
			// 
			// ScheduleCreationForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 431);
			this.Controls.Add(this.comboBoxClasses);
			this.Controls.Add(this.labelTeacher);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.comboBoxTeacher);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewSchedule);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "ScheduleCreationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ułóż plan";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxClasses;
		private System.Windows.Forms.DataGridView dataGridViewSchedule;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn columnTime;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnMonday;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnTuesday;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnWednesday;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnThursday;
		private System.Windows.Forms.DataGridViewComboBoxColumn columnFriday;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxTeacher;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelTeacher;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem itemMenu;
		private System.Windows.Forms.ToolStripMenuItem itemViewSchedules;
		private System.Windows.Forms.ToolStripMenuItem itemAssignSubjects;
	}
}