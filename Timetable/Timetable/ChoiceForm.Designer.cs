namespace Timetable
{
	partial class ChoiceForm
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
			this.buttonViewSchedules = new System.Windows.Forms.Button();
			this.buttonCreateSchedules = new System.Windows.Forms.Button();
			this.buttonAssignSubjects = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonViewSchedules
			// 
			this.buttonViewSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonViewSchedules.Location = new System.Drawing.Point(12, 12);
			this.buttonViewSchedules.Name = "buttonViewSchedules";
			this.buttonViewSchedules.Size = new System.Drawing.Size(260, 64);
			this.buttonViewSchedules.TabIndex = 0;
			this.buttonViewSchedules.Text = "Przeglądaj plany";
			this.buttonViewSchedules.UseVisualStyleBackColor = true;
			this.buttonViewSchedules.Click += new System.EventHandler(this.buttonViewSchedules_Click);
			// 
			// buttonCreateSchedules
			// 
			this.buttonCreateSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonCreateSchedules.Location = new System.Drawing.Point(12, 82);
			this.buttonCreateSchedules.Name = "buttonCreateSchedules";
			this.buttonCreateSchedules.Size = new System.Drawing.Size(260, 64);
			this.buttonCreateSchedules.TabIndex = 1;
			this.buttonCreateSchedules.Text = "Ułóż plan dla klasy";
			this.buttonCreateSchedules.UseVisualStyleBackColor = true;
			this.buttonCreateSchedules.Click += new System.EventHandler(this.buttonCreateSchedules_Click);
			// 
			// buttonAssignSubjects
			// 
			this.buttonAssignSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonAssignSubjects.Location = new System.Drawing.Point(12, 152);
			this.buttonAssignSubjects.Name = "buttonAssignSubjects";
			this.buttonAssignSubjects.Size = new System.Drawing.Size(260, 64);
			this.buttonAssignSubjects.TabIndex = 2;
			this.buttonAssignSubjects.Text = "Dodaj dane do bazy";
			this.buttonAssignSubjects.UseVisualStyleBackColor = true;
			this.buttonAssignSubjects.Click += new System.EventHandler(this.buttonAssignSubjects_Click);
			// 
			// ChoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 232);
			this.Controls.Add(this.buttonAssignSubjects);
			this.Controls.Add(this.buttonCreateSchedules);
			this.Controls.Add(this.buttonViewSchedules);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.Name = "ChoiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Manager planów lekcji";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonViewSchedules;
		private System.Windows.Forms.Button buttonCreateSchedules;
		private System.Windows.Forms.Button buttonAssignSubjects;
	}
}

