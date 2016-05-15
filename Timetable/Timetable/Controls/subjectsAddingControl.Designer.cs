namespace Timetable
{
	partial class SubjectsAddingControl
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
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Timetable.DataSet();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new Timetable.DataSetTableAdapters.lessonsTableAdapter();
            this.teachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachingTableAdapter = new Timetable.DataSetTableAdapters.teachingTableAdapter();
            this.subjectsTableAdapter = new Timetable.DataSetTableAdapters.subjectsTableAdapter();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lessonsBindingSource
            // 
            this.lessonsBindingSource.DataMember = "lessons";
            this.lessonsBindingSource.DataSource = this.dataSet;
            // 
            // lessonsTableAdapter
            // 
            this.lessonsTableAdapter.ClearBeforeFill = true;
            // 
            // teachingBindingSource
            // 
            this.teachingBindingSource.DataMember = "teaching";
            this.teachingBindingSource.DataSource = this.dataSet;
            // 
            // teachingTableAdapter
            // 
            this.teachingTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.Location = new System.Drawing.Point(176, 275);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(118, 29);
            this.buttonDeleteSubject.TabIndex = 2;
            this.buttonDeleteSubject.Text = "Usuń";
            this.buttonDeleteSubject.UseVisualStyleBackColor = true;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.buttonDeleteSubject_Click);
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.subjectsDataGridView.DataSource = this.subjectsBindingSource;
            this.subjectsDataGridView.Location = new System.Drawing.Point(4, 4);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.Size = new System.Drawing.Size(290, 265);
            this.subjectsDataGridView.TabIndex = 3;
            this.subjectsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.subjectsDataGridView_DataError);
            this.subjectsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.subjectsDataGridView_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nazwa przedmiotu";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 230;
            // 
            // SubjectsAddingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.subjectsDataGridView);
            this.Controls.Add(this.buttonDeleteSubject);
            this.Name = "SubjectsAddingControl";
            this.Size = new System.Drawing.Size(304, 309);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private DataSetTableAdapters.lessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.BindingSource teachingBindingSource;
        private DataSetTableAdapters.teachingTableAdapter teachingTableAdapter;
        private DataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.DataGridView subjectsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
	}
}
