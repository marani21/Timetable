namespace Timetable.Controls
{
	partial class CellControl
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
			this.labelTeacher = new System.Windows.Forms.Label();
			this.labelClassroom = new System.Windows.Forms.Label();
			this.labelSubject = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTeacher
			// 
			this.labelTeacher.Location = new System.Drawing.Point(3, 23);
			this.labelTeacher.Name = "labelTeacher";
			this.labelTeacher.Size = new System.Drawing.Size(121, 13);
			this.labelTeacher.TabIndex = 1;
			this.labelTeacher.Text = "Adam Zielonka";
			this.labelTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTeacher.Click += new System.EventHandler(this.labelTeacher_Click);
			// 
			// labelClassroom
			// 
			this.labelClassroom.CausesValidation = false;
			this.labelClassroom.Location = new System.Drawing.Point(37, 36);
			this.labelClassroom.Name = "labelClassroom";
			this.labelClassroom.Size = new System.Drawing.Size(50, 18);
			this.labelClassroom.TabIndex = 2;
			this.labelClassroom.Text = "101";
			this.labelClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelClassroom.Click += new System.EventHandler(this.labelClassroom_Click);
			// 
			// labelSubject
			// 
			this.labelSubject.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelSubject.Location = new System.Drawing.Point(4, 2);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(121, 17);
			this.labelSubject.TabIndex = 3;
			this.labelSubject.Text = "Matematyka";
			this.labelSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSubject.Click += new System.EventHandler(this.labelSubject_Click);
			// 
			// cellControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add(this.labelClassroom);
			this.Controls.Add(this.labelTeacher);
			this.Controls.Add(this.labelSubject);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "cellControl";
			this.Size = new System.Drawing.Size(128, 55);
			this.Click += new System.EventHandler(this.CellControl_Click);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label labelTeacher;
		private System.Windows.Forms.Label labelSubject;
		private System.Windows.Forms.Label labelClassroom;
	}
}
