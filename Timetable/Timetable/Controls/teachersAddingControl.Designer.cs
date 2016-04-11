namespace Timetable
{
	partial class TeachersAddingControl
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
            this.labelPesel = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxViewTeachers = new System.Windows.Forms.ComboBox();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPesel
            // 
            this.labelPesel.AutoSize = true;
            this.labelPesel.Location = new System.Drawing.Point(3, 34);
            this.labelPesel.Name = "labelPesel";
            this.labelPesel.Size = new System.Drawing.Size(75, 13);
            this.labelPesel.TabIndex = 0;
            this.labelPesel.Text = "Numer PESEL";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(26, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(3, 86);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(53, 13);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Nazwisko";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dostępni nauczyciele:";
            // 
            // comboBoxViewTeachers
            // 
            this.comboBoxViewTeachers.FormattingEnabled = true;
            this.comboBoxViewTeachers.Location = new System.Drawing.Point(121, 4);
            this.comboBoxViewTeachers.Name = "comboBoxViewTeachers";
            this.comboBoxViewTeachers.Size = new System.Drawing.Size(169, 21);
            this.comboBoxViewTeachers.TabIndex = 7;
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Location = new System.Drawing.Point(121, 120);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTeacher.TabIndex = 8;
            this.buttonAddTeacher.Text = "Dodaj";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Location = new System.Drawing.Point(121, 150);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTeacher.TabIndex = 9;
            this.buttonEditTeacher.Text = "Edytuj";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(121, 180);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTeacher.TabIndex = 10;
            this.buttonDeleteTeacher.Text = "Usuń";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // TeachersAddingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.buttonEditTeacher);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.comboBoxViewTeachers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPesel);
            this.Name = "TeachersAddingControl";
            this.Size = new System.Drawing.Size(293, 216);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label labelPesel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxViewTeachers;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.Button buttonDeleteTeacher;
    }
}
