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
            this.buttonAddSubject = new System.Windows.Forms.Button();
            this.buttonEditSubject = new System.Windows.Forms.Button();
            this.buttonDeleteSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxViewSubjects = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Timetable.DataSet();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.lessonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lessonsTableAdapter = new Timetable.DataSetTableAdapters.lessonsTableAdapter();
            this.teachingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachingTableAdapter = new Timetable.DataSetTableAdapters.teachingTableAdapter();
            this.subjectsTableAdapter = new Timetable.DataSetTableAdapters.subjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddSubject
            // 
            this.buttonAddSubject.Location = new System.Drawing.Point(119, 53);
            this.buttonAddSubject.Name = "buttonAddSubject";
            this.buttonAddSubject.Size = new System.Drawing.Size(99, 23);
            this.buttonAddSubject.TabIndex = 0;
            this.buttonAddSubject.Text = "Dodaj";
            this.buttonAddSubject.UseVisualStyleBackColor = true;
            this.buttonAddSubject.Click += new System.EventHandler(this.buttonAddSubject_Click);
            // 
            // buttonEditSubject
            // 
            this.buttonEditSubject.Location = new System.Drawing.Point(119, 82);
            this.buttonEditSubject.Name = "buttonEditSubject";
            this.buttonEditSubject.Size = new System.Drawing.Size(99, 23);
            this.buttonEditSubject.TabIndex = 1;
            this.buttonEditSubject.Text = "Edytuj";
            this.buttonEditSubject.UseVisualStyleBackColor = true;
            this.buttonEditSubject.Click += new System.EventHandler(this.buttonEditSubject_Click);
            // 
            // buttonDeleteSubject
            // 
            this.buttonDeleteSubject.Location = new System.Drawing.Point(119, 111);
            this.buttonDeleteSubject.Name = "buttonDeleteSubject";
            this.buttonDeleteSubject.Size = new System.Drawing.Size(99, 23);
            this.buttonDeleteSubject.TabIndex = 2;
            this.buttonDeleteSubject.Text = "Usuń";
            this.buttonDeleteSubject.UseVisualStyleBackColor = true;
            this.buttonDeleteSubject.Click += new System.EventHandler(this.buttonDeleteSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dostępne przedmioty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wprowadź przedmiot:";
            // 
            // comboBoxViewSubjects
            // 
            this.comboBoxViewSubjects.DataSource = this.subjectsBindingSource;
            this.comboBoxViewSubjects.DisplayMember = "name";
            this.comboBoxViewSubjects.FormattingEnabled = true;
            this.comboBoxViewSubjects.Location = new System.Drawing.Point(119, 3);
            this.comboBoxViewSubjects.Name = "comboBoxViewSubjects";
            this.comboBoxViewSubjects.Size = new System.Drawing.Size(293, 21);
            this.comboBoxViewSubjects.TabIndex = 5;
            this.comboBoxViewSubjects.ValueMember = "name";
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
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(119, 27);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(293, 20);
            this.textBoxSubject.TabIndex = 6;
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
            // SubjectsAddingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.comboBoxViewSubjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteSubject);
            this.Controls.Add(this.buttonEditSubject);
            this.Controls.Add(this.buttonAddSubject);
            this.Name = "SubjectsAddingControl";
            this.Size = new System.Drawing.Size(415, 141);
            this.Load += new System.EventHandler(this.SubjectsAddingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button buttonAddSubject;
        private System.Windows.Forms.Button buttonEditSubject;
        private System.Windows.Forms.Button buttonDeleteSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxViewSubjects;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource lessonsBindingSource;
        private DataSetTableAdapters.lessonsTableAdapter lessonsTableAdapter;
        private System.Windows.Forms.BindingSource teachingBindingSource;
        private DataSetTableAdapters.teachingTableAdapter teachingTableAdapter;
        private DataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
    }
}
