namespace WinForm.UI.UI
{
	partial class LecturerAllAttendancePage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.cbxClassSchedule = new System.Windows.Forms.ComboBox();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvStudentAttendance = new System.Windows.Forms.DataGridView();
			this.SidePanel = new System.Windows.Forms.Panel();
			this.pnlGetApiOrders = new System.Windows.Forms.Panel();
			this.btnPublishStudentAttendance = new System.Windows.Forms.Button();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).BeginInit();
			this.SidePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
			this.pnlTop.Controls.Add(this.cbxClassSchedule);
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(800, 45);
			this.pnlTop.TabIndex = 0;
			this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// cbxClassSchedule
			// 
			this.cbxClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxClassSchedule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxClassSchedule.FormattingEnabled = true;
			this.cbxClassSchedule.Location = new System.Drawing.Point(13, 10);
			this.cbxClassSchedule.Name = "cbxClassSchedule";
			this.cbxClassSchedule.Size = new System.Drawing.Size(489, 24);
			this.cbxClassSchedule.TabIndex = 14;
			this.cbxClassSchedule.SelectionChangeCommitted += new System.EventHandler(this.cbxClassSchedule_SelectionChangeCommitted);
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(780, 3);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 4;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 455);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 45);
			this.panel1.TabIndex = 1;
			// 
			// dgvStudentAttendance
			// 
			this.dgvStudentAttendance.AllowUserToAddRows = false;
			this.dgvStudentAttendance.AllowUserToDeleteRows = false;
			this.dgvStudentAttendance.AllowUserToOrderColumns = true;
			this.dgvStudentAttendance.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvStudentAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStudentAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudentAttendance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvStudentAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.dgvStudentAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStudentAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStudentAttendance.ColumnHeadersHeight = 30;
			this.dgvStudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvStudentAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvStudentAttendance.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStudentAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStudentAttendance.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dgvStudentAttendance.EnableHeadersVisualStyles = false;
			this.dgvStudentAttendance.Location = new System.Drawing.Point(0, 45);
			this.dgvStudentAttendance.MultiSelect = false;
			this.dgvStudentAttendance.Name = "dgvStudentAttendance";
			this.dgvStudentAttendance.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStudentAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvStudentAttendance.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvStudentAttendance.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvStudentAttendance.RowTemplate.Height = 35;
			this.dgvStudentAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudentAttendance.Size = new System.Drawing.Size(599, 410);
			this.dgvStudentAttendance.TabIndex = 6;
			// 
			// SidePanel
			// 
			this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
			this.SidePanel.Controls.Add(this.pnlGetApiOrders);
			this.SidePanel.Controls.Add(this.btnPublishStudentAttendance);
			this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.SidePanel.Location = new System.Drawing.Point(599, 45);
			this.SidePanel.Name = "SidePanel";
			this.SidePanel.Size = new System.Drawing.Size(201, 410);
			this.SidePanel.TabIndex = 2;
			// 
			// pnlGetApiOrders
			// 
			this.pnlGetApiOrders.BackColor = System.Drawing.Color.Gray;
			this.pnlGetApiOrders.Location = new System.Drawing.Point(195, 2);
			this.pnlGetApiOrders.Name = "pnlGetApiOrders";
			this.pnlGetApiOrders.Size = new System.Drawing.Size(5, 60);
			this.pnlGetApiOrders.TabIndex = 7;
			// 
			// btnPublishStudentAttendance
			// 
			this.btnPublishStudentAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPublishStudentAttendance.FlatAppearance.BorderSize = 0;
			this.btnPublishStudentAttendance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnPublishStudentAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnPublishStudentAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPublishStudentAttendance.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnPublishStudentAttendance.ForeColor = System.Drawing.Color.White;
			this.btnPublishStudentAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPublishStudentAttendance.Location = new System.Drawing.Point(1, 2);
			this.btnPublishStudentAttendance.Name = "btnPublishStudentAttendance";
			this.btnPublishStudentAttendance.Size = new System.Drawing.Size(200, 60);
			this.btnPublishStudentAttendance.TabIndex = 8;
			this.btnPublishStudentAttendance.Text = "&Publish Attendance";
			this.btnPublishStudentAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnPublishStudentAttendance.UseVisualStyleBackColor = true;
			this.btnPublishStudentAttendance.Click += new System.EventHandler(this.btnPublishStudentAttendance_Click);
			// 
			// LecturerAllAttendancePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.dgvStudentAttendance);
			this.Controls.Add(this.SidePanel);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LecturerAllAttendancePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Manage Attendance";
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).EndInit();
			this.SidePanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.ComboBox cbxClassSchedule;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvStudentAttendance;
		private System.Windows.Forms.Panel SidePanel;
		private System.Windows.Forms.Panel pnlGetApiOrders;
		private System.Windows.Forms.Button btnPublishStudentAttendance;
	}
}