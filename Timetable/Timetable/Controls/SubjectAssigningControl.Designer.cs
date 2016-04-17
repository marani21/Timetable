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
            this.dataGridViewAssigning = new System.Windows.Forms.DataGridView();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Timetable.DataSet();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesTableAdapter = new Timetable.DataSetTableAdapters.classesTableAdapter();
            this.teachingTableAdapter = new Timetable.DataSetTableAdapters.teachingTableAdapter();
            this.subjectsTableAdapter = new Timetable.DataSetTableAdapters.subjectsTableAdapter();
            this.teachersTableAdapter = new Timetable.DataSetTableAdapters.teachersTableAdapter();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.teacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAssigning
            // 
            this.dataGridViewAssigning.AutoGenerateColumns = false;
            this.dataGridViewAssigning.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridViewAssigning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssigning.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teacherDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewAssigning.DataSource = this.teachingBindingSource;
            this.dataGridViewAssigning.Location = new System.Drawing.Point(3, 50);
            this.dataGridViewAssigning.Name = "dataGridViewAssigning";
            this.dataGridViewAssigning.Size = new System.Drawing.Size(525, 234);
            this.dataGridViewAssigning.TabIndex = 7;
            this.dataGridViewAssigning.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewDefaultValues);
            this.dataGridViewAssigning.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewAssigning_EditingControlShowing);
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.dataSet;
            // 
            // teachingBindingSource
            // 
            this.teachingBindingSource.DataMember = "teaching";
            this.teachingBindingSource.DataSource = this.dataSet;
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
            this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasses_SelectedIndexChanged);
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
            // teachingTableAdapter
            // 
            this.teachingTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(412, 290);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 29);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // teacherDataGridViewTextBoxColumn
            // 
            this.teacherDataGridViewTextBoxColumn.DataPropertyName = "teacher";
            this.teacherDataGridViewTextBoxColumn.DataSource = this.teachersBindingSource;
            this.teacherDataGridViewTextBoxColumn.DisplayMember = "surname";
            this.teacherDataGridViewTextBoxColumn.HeaderText = "Nauczyciel";
            this.teacherDataGridViewTextBoxColumn.Name = "teacherDataGridViewTextBoxColumn";
            this.teacherDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.teacherDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.teacherDataGridViewTextBoxColumn.ValueMember = "pesel";
            this.teacherDataGridViewTextBoxColumn.Width = 220;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.DataSource = this.subjectsBindingSource;
            this.subjectDataGridViewTextBoxColumn.DisplayMember = "name";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Przedmiot";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.subjectDataGridViewTextBoxColumn.ValueMember = "id";
            this.subjectDataGridViewTextBoxColumn.Width = 160;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Liczba godzin";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "class";
            this.dataGridViewTextBoxColumn1.HeaderText = "class";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // SubjectAssigningControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewAssigning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClasses);
            this.Name = "SubjectAssigningControl";
            this.Size = new System.Drawing.Size(532, 331);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssigning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView dataGridViewAssigning;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxClasses;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DataSet dataSet;
        private DataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.BindingSource teachingBindingSource;
        private DataSetTableAdapters.teachingTableAdapter teachingTableAdapter;
        private DataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private DataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewComboBoxColumn teacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}
