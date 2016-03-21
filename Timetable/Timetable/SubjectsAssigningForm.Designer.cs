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
			this.comboBoxClasses = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataSet = new Timetable.DataSet();
			this.dataGridViewAssigning = new System.Windows.Forms.DataGridView();
			this.buttonNewRow = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.teacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.amount = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBoxClasses
			// 
			this.comboBoxClasses.FormattingEnabled = true;
			this.comboBoxClasses.Location = new System.Drawing.Point(120, 17);
			this.comboBoxClasses.Name = "comboBoxClasses";
			this.comboBoxClasses.Size = new System.Drawing.Size(162, 21);
			this.comboBoxClasses.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Przedmioty dla klasy";
			// 
			// dataSet1
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridViewAssigning
			// 
			this.dataGridViewAssigning.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridViewAssigning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAssigning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.subject,
			this.teacher,
			this.amount,
			this.delete});
			this.dataGridViewAssigning.Location = new System.Drawing.Point(12, 54);
			this.dataGridViewAssigning.Name = "dataGridViewAssigning";
			this.dataGridViewAssigning.Size = new System.Drawing.Size(524, 234);
			this.dataGridViewAssigning.TabIndex = 2;
			// 
			// buttonNewRow
			// 
			this.buttonNewRow.Location = new System.Drawing.Point(12, 294);
			this.buttonNewRow.Name = "buttonNewRow";
			this.buttonNewRow.Size = new System.Drawing.Size(524, 30);
			this.buttonNewRow.TabIndex = 3;
			this.buttonNewRow.Text = "+";
			this.buttonNewRow.UseVisualStyleBackColor = true;
			// 
			// buttonOk
			// 
			this.buttonOk.Location = new System.Drawing.Point(445, 349);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(91, 29);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// subject
			// 
			this.subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.subject.HeaderText = "Przedmiot";
			this.subject.Name = "subject";
			this.subject.Width = 170;
			// 
			// teacher
			// 
			this.teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.teacher.HeaderText = "Nauczyciel";
			this.teacher.Name = "teacher";
			this.teacher.Width = 190;
			// 
			// amount
			// 
			this.amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.amount.HeaderText = "Ilość";
			this.amount.Name = "amount";
			this.amount.Width = 50;
			// 
			// delete
			// 
			this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.delete.HeaderText = "";
			this.delete.Name = "delete";
			this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.delete.Width = 70;
			// 
			// SubjectsAssigningForm
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 390);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonNewRow);
			this.Controls.Add(this.dataGridViewAssigning);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxClasses);
			this.Name = "SubjectsAssigningForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Przydziel przedmioty";
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxClasses;
		private System.Windows.Forms.Label label1;
		private DataSet dataSet;
		private System.Windows.Forms.DataGridView dataGridViewAssigning;
		private System.Windows.Forms.Button buttonNewRow;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.DataGridViewComboBoxColumn subject;
		private System.Windows.Forms.DataGridViewComboBoxColumn teacher;
		private System.Windows.Forms.DataGridViewComboBoxColumn amount;
		private System.Windows.Forms.DataGridViewButtonColumn delete;
	}
}