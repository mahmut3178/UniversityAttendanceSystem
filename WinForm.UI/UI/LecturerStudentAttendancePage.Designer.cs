namespace WinForm.UI.UI
{
	partial class LecturerStudentAttendancePage
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
			this.cbxOnlyToday = new System.Windows.Forms.CheckBox();
			this.cbxClassSchedule = new System.Windows.Forms.ComboBox();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pnlPrintBill = new System.Windows.Forms.Panel();
			this.btnPrintBill = new System.Windows.Forms.Button();
			this.pnlPrintWaybill = new System.Windows.Forms.Panel();
			this.btnManageAtendances = new System.Windows.Forms.Button();
			this.pnlGetApiOrders = new System.Windows.Forms.Panel();
			this.btnPublishStudentAttendance = new System.Windows.Forms.Button();
			this.pnRight = new System.Windows.Forms.Panel();
			this.dgvStudentAttendance = new System.Windows.Forms.DataGridView();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.pnRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).BeginInit();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
			this.pnlTop.Controls.Add(this.cbxOnlyToday);
			this.pnlTop.Controls.Add(this.cbxClassSchedule);
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(984, 50);
			this.pnlTop.TabIndex = 12;
			// 
			// cbxOnlyToday
			// 
			this.cbxOnlyToday.AutoSize = true;
			this.cbxOnlyToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxOnlyToday.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxOnlyToday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cbxOnlyToday.Location = new System.Drawing.Point(500, 22);
			this.cbxOnlyToday.Name = "cbxOnlyToday";
			this.cbxOnlyToday.Size = new System.Drawing.Size(144, 20);
			this.cbxOnlyToday.TabIndex = 14;
			this.cbxOnlyToday.Text = "Today\'s Classes";
			this.cbxOnlyToday.UseVisualStyleBackColor = true;
			this.cbxOnlyToday.CheckedChanged += new System.EventHandler(this.cbxOnlyToday_CheckedChanged);
			this.cbxOnlyToday.CheckStateChanged += new System.EventHandler(this.cbxOnlyToday_CheckStateChanged);
			// 
			// cbxClassSchedule
			// 
			this.cbxClassSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxClassSchedule.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxClassSchedule.FormattingEnabled = true;
			this.cbxClassSchedule.Location = new System.Drawing.Point(5, 19);
			this.cbxClassSchedule.Name = "cbxClassSchedule";
			this.cbxClassSchedule.Size = new System.Drawing.Size(489, 24);
			this.cbxClassSchedule.TabIndex = 13;
			this.cbxClassSchedule.SelectedIndexChanged += new System.EventHandler(this.cbxClassSchedule_SelectedIndexChanged);
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(961, 7);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 3;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// pnlPrintBill
			// 
			this.pnlPrintBill.BackColor = System.Drawing.Color.Gray;
			this.pnlPrintBill.Location = new System.Drawing.Point(195, 138);
			this.pnlPrintBill.Name = "pnlPrintBill";
			this.pnlPrintBill.Size = new System.Drawing.Size(5, 60);
			this.pnlPrintBill.TabIndex = 14;
			// 
			// btnPrintBill
			// 
			this.btnPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrintBill.FlatAppearance.BorderSize = 0;
			this.btnPrintBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnPrintBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnPrintBill.ForeColor = System.Drawing.Color.White;
			this.btnPrintBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrintBill.Location = new System.Drawing.Point(1, 138);
			this.btnPrintBill.Name = "btnPrintBill";
			this.btnPrintBill.Size = new System.Drawing.Size(200, 60);
			this.btnPrintBill.TabIndex = 8;
			this.btnPrintBill.Text = "&Under Development";
			this.btnPrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintBill.UseVisualStyleBackColor = true;
			// 
			// pnlPrintWaybill
			// 
			this.pnlPrintWaybill.BackColor = System.Drawing.Color.Gray;
			this.pnlPrintWaybill.Location = new System.Drawing.Point(195, 72);
			this.pnlPrintWaybill.Name = "pnlPrintWaybill";
			this.pnlPrintWaybill.Size = new System.Drawing.Size(5, 60);
			this.pnlPrintWaybill.TabIndex = 12;
			// 
			// btnManageAtendances
			// 
			this.btnManageAtendances.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnManageAtendances.FlatAppearance.BorderSize = 0;
			this.btnManageAtendances.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnManageAtendances.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnManageAtendances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageAtendances.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnManageAtendances.ForeColor = System.Drawing.Color.White;
			this.btnManageAtendances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnManageAtendances.Location = new System.Drawing.Point(1, 72);
			this.btnManageAtendances.Name = "btnManageAtendances";
			this.btnManageAtendances.Size = new System.Drawing.Size(200, 60);
			this.btnManageAtendances.TabIndex = 7;
			this.btnManageAtendances.Text = "&Manage Attendance";
			this.btnManageAtendances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnManageAtendances.UseVisualStyleBackColor = true;
			this.btnManageAtendances.Click += new System.EventHandler(this.btnManageAtendances_Click);
			// 
			// pnlGetApiOrders
			// 
			this.pnlGetApiOrders.BackColor = System.Drawing.Color.Gray;
			this.pnlGetApiOrders.Location = new System.Drawing.Point(195, 6);
			this.pnlGetApiOrders.Name = "pnlGetApiOrders";
			this.pnlGetApiOrders.Size = new System.Drawing.Size(5, 60);
			this.pnlGetApiOrders.TabIndex = 6;
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
			this.btnPublishStudentAttendance.Location = new System.Drawing.Point(1, 6);
			this.btnPublishStudentAttendance.Name = "btnPublishStudentAttendance";
			this.btnPublishStudentAttendance.Size = new System.Drawing.Size(200, 60);
			this.btnPublishStudentAttendance.TabIndex = 6;
			this.btnPublishStudentAttendance.Text = "&Publish Attendance";
			this.btnPublishStudentAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnPublishStudentAttendance.UseVisualStyleBackColor = true;
			this.btnPublishStudentAttendance.Click += new System.EventHandler(this.btnPublishStudentAttendance_Click);
			// 
			// pnRight
			// 
			this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
			this.pnRight.Controls.Add(this.pnlPrintBill);
			this.pnRight.Controls.Add(this.btnPrintBill);
			this.pnRight.Controls.Add(this.pnlPrintWaybill);
			this.pnRight.Controls.Add(this.btnManageAtendances);
			this.pnRight.Controls.Add(this.pnlGetApiOrders);
			this.pnRight.Controls.Add(this.btnPublishStudentAttendance);
			this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnRight.Location = new System.Drawing.Point(782, 50);
			this.pnRight.Name = "pnRight";
			this.pnRight.Size = new System.Drawing.Size(202, 411);
			this.pnRight.TabIndex = 13;
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
			this.dgvStudentAttendance.Location = new System.Drawing.Point(5, 5);
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
			this.dgvStudentAttendance.Size = new System.Drawing.Size(772, 401);
			this.dgvStudentAttendance.TabIndex = 5;
			this.dgvStudentAttendance.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvStudentAttendance_DataError);
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.pnlMain.Controls.Add(this.dgvStudentAttendance);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 50);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
			this.pnlMain.Size = new System.Drawing.Size(782, 411);
			this.pnlMain.TabIndex = 15;
			// 
			// LecturerStudentAttendancePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnRight);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LecturerStudentAttendancePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "  ";
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.pnRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).EndInit();
			this.pnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Panel pnlPrintBill;
		private System.Windows.Forms.Button btnPrintBill;
		private System.Windows.Forms.Panel pnlPrintWaybill;
		private System.Windows.Forms.Button btnManageAtendances;
		private System.Windows.Forms.Panel pnlGetApiOrders;
		private System.Windows.Forms.Button btnPublishStudentAttendance;
		private System.Windows.Forms.Panel pnRight;
		private System.Windows.Forms.DataGridView dgvStudentAttendance;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ComboBox cbxClassSchedule;
		private System.Windows.Forms.CheckBox cbxOnlyToday;
	}
}