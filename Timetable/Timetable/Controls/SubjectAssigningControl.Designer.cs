namespace Timetable
{
	partial class SubjectAssigningControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.buttonNewRow = new System.Windows.Forms.Button();
            this.dataGridViewAssigning = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.teacher = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.dataSet = new Timetable.DataSet();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Timetable.DataSetTableAdapters.classesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewRow
            // 
            this.buttonNewRow.Location = new System.Drawing.Point(3, 290);
            this.buttonNewRow.Name = "buttonNewRow";
            this.buttonNewRow.Size = new System.Drawing.Size(525, 30);
            this.buttonNewRow.TabIndex = 8;
            this.buttonNewRow.Text = "+";
            this.buttonNewRow.UseVisualStyleBackColor = true;
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
            this.dataGridViewAssigning.Location = new System.Drawing.Point(3, 50);
            this.dataGridViewAssigning.Name = "dataGridViewAssigning";
            this.dataGridViewAssigning.Size = new System.Drawing.Size(525, 234);
            this.dataGridViewAssigning.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Przedmioty dla klasy";
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.DataSource = this.classesBindingSource;
            this.comboBoxClasses.DisplayMember = "label";
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Location = new System.Drawing.Point(111, 13);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(263, 21);
            this.comboBoxClasses.TabIndex = 5;
            this.comboBoxClasses.ValueMember = "label";
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
            // SubjectAssigningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNewRow);
            this.Controls.Add(this.dataGridViewAssigning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClasses);
            this.Name = "SubjectAssigningControl";
            this.Size = new System.Drawing.Size(532, 331);
            this.Load += new System.EventHandler(this.SubjectAssigningControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonNewRow;
		private System.Windows.Forms.DataGridView dataGridViewAssigning;
		private System.Windows.Forms.DataGridViewComboBoxColumn subject;
		private System.Windows.Forms.DataGridViewComboBoxColumn teacher;
		private System.Windows.Forms.DataGridViewComboBoxColumn amount;
		private System.Windows.Forms.DataGridViewButtonColumn delete;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSet dataSet;
        private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
    }
}
