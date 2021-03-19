namespace WinForm.UI.UI
{
	partial class StudentAttendancePage
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
			this.flpAttendance = new System.Windows.Forms.FlowLayoutPanel();
			this.lblIntake = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.cbxIntake = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.SuspendLayout();
			// 
			// flpAttendance
			// 
			this.flpAttendance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.flpAttendance.Location = new System.Drawing.Point(243, 41);
			this.flpAttendance.Name = "flpAttendance";
			this.flpAttendance.Padding = new System.Windows.Forms.Padding(10);
			this.flpAttendance.Size = new System.Drawing.Size(342, 406);
			this.flpAttendance.TabIndex = 1;
			// 
			// lblIntake
			// 
			this.lblIntake.AutoSize = true;
			this.lblIntake.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntake.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblIntake.Location = new System.Drawing.Point(12, 9);
			this.lblIntake.Name = "lblIntake";
			this.lblIntake.Size = new System.Drawing.Size(75, 19);
			this.lblIntake.TabIndex = 2;
			this.lblIntake.Text = "Intake";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClosed);
			this.panel1.Controls.Add(this.cbxIntake);
			this.panel1.Controls.Add(this.lblIntake);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 39);
			this.panel1.TabIndex = 4;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(780, 2);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 4;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// cbxIntake
			// 
			this.cbxIntake.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.cbxIntake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxIntake.FormattingEnabled = true;
			this.cbxIntake.Location = new System.Drawing.Point(93, 9);
			this.cbxIntake.Name = "cbxIntake";
			this.cbxIntake.Size = new System.Drawing.Size(121, 21);
			this.cbxIntake.TabIndex = 0;
			this.cbxIntake.SelectedIndexChanged += new System.EventHandler(this.cbxIntake_SelectedIndexChanged);
			// 
			// StudentAttendancePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flpAttendance);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentAttendancePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StudentAttendancePage";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpAttendance;
		private System.Windows.Forms.Label lblIntake;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbxIntake;
		private System.Windows.Forms.PictureBox btnClosed;
	}
}