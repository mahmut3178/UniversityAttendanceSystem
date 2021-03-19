namespace WinForm.UI.UI
{
	partial class StudentTimeTablePage
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
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblDay = new System.Windows.Forms.Label();
			this.cbxDays = new System.Windows.Forms.ComboBox();
			this.flpTimeTable = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlTop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.pnlTop.Controls.Add(this.lblDay);
			this.pnlTop.Controls.Add(this.cbxDays);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(734, 52);
			this.pnlTop.TabIndex = 0;
			// 
			// lblDay
			// 
			this.lblDay.AutoSize = true;
			this.lblDay.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblDay.Location = new System.Drawing.Point(12, 18);
			this.lblDay.Name = "lblDay";
			this.lblDay.Size = new System.Drawing.Size(42, 19);
			this.lblDay.TabIndex = 2;
			this.lblDay.Text = "Day";
			// 
			// cbxDays
			// 
			this.cbxDays.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbxDays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.cbxDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxDays.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxDays.ForeColor = System.Drawing.SystemColors.Menu;
			this.cbxDays.FormattingEnabled = true;
			this.cbxDays.Location = new System.Drawing.Point(60, 15);
			this.cbxDays.Name = "cbxDays";
			this.cbxDays.Size = new System.Drawing.Size(179, 27);
			this.cbxDays.TabIndex = 3;
			this.cbxDays.SelectedIndexChanged += new System.EventHandler(this.cbxDays_SelectedIndexChanged_1);
			// 
			// flpTimeTable
			// 
			this.flpTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpTimeTable.Location = new System.Drawing.Point(0, 52);
			this.flpTimeTable.Name = "flpTimeTable";
			this.flpTimeTable.Size = new System.Drawing.Size(734, 439);
			this.flpTimeTable.TabIndex = 1;
			// 
			// StudentTimeTablePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(734, 491);
			this.Controls.Add(this.flpTimeTable);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "StudentTimeTablePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "My TimeTable";
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.FlowLayoutPanel flpTimeTable;
		private System.Windows.Forms.Label lblDay;
		private System.Windows.Forms.ComboBox cbxDays;
	}
}