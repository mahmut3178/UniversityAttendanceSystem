namespace WinForm.UI.UI
{
	partial class IntakeCoursePage
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
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pnlPrintBill = new System.Windows.Forms.Panel();
			this.btnPrintBill = new System.Windows.Forms.Button();
			this.pnlPrintWaybill = new System.Windows.Forms.Panel();
			this.btnCourseSubject = new System.Windows.Forms.Button();
			this.pnlGetApiOrders = new System.Windows.Forms.Panel();
			this.btnIntakeCourse = new System.Windows.Forms.Button();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.btnDeleteIntakeCourse = new System.Windows.Forms.Button();
			this.pnRight = new System.Windows.Forms.Panel();
			this.grdListIntakeCourses = new System.Windows.Forms.DataGridView();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.pnlBottom.SuspendLayout();
			this.pnRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdListIntakeCourses)).BeginInit();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.txtSearch.Location = new System.Drawing.Point(46, 15);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(150, 24);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTop.Controls.Add(this.txtSearch);
			this.pnlTop.Controls.Add(this.pbxSearch);
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(1000, 50);
			this.pnlTop.TabIndex = 8;
			this.pnlTop.SizeChanged += new System.EventHandler(this.IntakeCourse_Resize);
			// 
			// pbxSearch
			// 
			this.pbxSearch.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pbxSearch.Location = new System.Drawing.Point(12, 14);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(28, 28);
			this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxSearch.TabIndex = 5;
			this.pbxSearch.TabStop = false;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(976, 19);
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
			this.pnlPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
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
			this.btnPrintBill.Text = "Under Development";
			this.btnPrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintBill.UseVisualStyleBackColor = true;
			// 
			// pnlPrintWaybill
			// 
			this.pnlPrintWaybill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.pnlPrintWaybill.Location = new System.Drawing.Point(195, 72);
			this.pnlPrintWaybill.Name = "pnlPrintWaybill";
			this.pnlPrintWaybill.Size = new System.Drawing.Size(5, 60);
			this.pnlPrintWaybill.TabIndex = 12;
			// 
			// btnCourseSubject
			// 
			this.btnCourseSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCourseSubject.FlatAppearance.BorderSize = 0;
			this.btnCourseSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnCourseSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnCourseSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCourseSubject.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnCourseSubject.ForeColor = System.Drawing.Color.White;
			this.btnCourseSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCourseSubject.Location = new System.Drawing.Point(1, 72);
			this.btnCourseSubject.Name = "btnCourseSubject";
			this.btnCourseSubject.Size = new System.Drawing.Size(200, 60);
			this.btnCourseSubject.TabIndex = 7;
			this.btnCourseSubject.Text = "Manage Course Subjects";
			this.btnCourseSubject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCourseSubject.UseVisualStyleBackColor = true;
			this.btnCourseSubject.Click += new System.EventHandler(this.btnCourseSubject_Click);
			// 
			// pnlGetApiOrders
			// 
			this.pnlGetApiOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.pnlGetApiOrders.Location = new System.Drawing.Point(195, 6);
			this.pnlGetApiOrders.Name = "pnlGetApiOrders";
			this.pnlGetApiOrders.Size = new System.Drawing.Size(5, 60);
			this.pnlGetApiOrders.TabIndex = 6;
			// 
			// btnIntakeCourse
			// 
			this.btnIntakeCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIntakeCourse.FlatAppearance.BorderSize = 0;
			this.btnIntakeCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnIntakeCourse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnIntakeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIntakeCourse.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnIntakeCourse.ForeColor = System.Drawing.Color.White;
			this.btnIntakeCourse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIntakeCourse.Location = new System.Drawing.Point(1, 6);
			this.btnIntakeCourse.Name = "btnIntakeCourse";
			this.btnIntakeCourse.Size = new System.Drawing.Size(200, 60);
			this.btnIntakeCourse.TabIndex = 6;
			this.btnIntakeCourse.Text = "Manage Intake Courses";
			this.btnIntakeCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnIntakeCourse.UseVisualStyleBackColor = true;
			this.btnIntakeCourse.Click += new System.EventHandler(this.btnIntakeCourse_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlBottom.Controls.Add(this.btnDeleteIntakeCourse);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 400);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(1000, 100);
			this.pnlBottom.TabIndex = 10;
			// 
			// btnDeleteIntakeCourse
			// 
			this.btnDeleteIntakeCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnDeleteIntakeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteIntakeCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteIntakeCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDeleteIntakeCourse.Location = new System.Drawing.Point(5, 15);
			this.btnDeleteIntakeCourse.Name = "btnDeleteIntakeCourse";
			this.btnDeleteIntakeCourse.Size = new System.Drawing.Size(211, 27);
			this.btnDeleteIntakeCourse.TabIndex = 6;
			this.btnDeleteIntakeCourse.Text = "Remove Intake Course";
			this.btnDeleteIntakeCourse.UseVisualStyleBackColor = false;
			this.btnDeleteIntakeCourse.Click += new System.EventHandler(this.btnDeleteIntakeCourse_Click);
			// 
			// pnRight
			// 
			this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnRight.Controls.Add(this.pnlPrintBill);
			this.pnRight.Controls.Add(this.btnPrintBill);
			this.pnRight.Controls.Add(this.pnlPrintWaybill);
			this.pnRight.Controls.Add(this.btnCourseSubject);
			this.pnRight.Controls.Add(this.pnlGetApiOrders);
			this.pnRight.Controls.Add(this.btnIntakeCourse);
			this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.pnRight.Location = new System.Drawing.Point(798, 50);
			this.pnRight.Name = "pnRight";
			this.pnRight.Size = new System.Drawing.Size(202, 350);
			this.pnRight.TabIndex = 9;
			// 
			// grdListIntakeCourses
			// 
			this.grdListIntakeCourses.AllowUserToAddRows = false;
			this.grdListIntakeCourses.AllowUserToDeleteRows = false;
			this.grdListIntakeCourses.AllowUserToOrderColumns = true;
			this.grdListIntakeCourses.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grdListIntakeCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.grdListIntakeCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdListIntakeCourses.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdListIntakeCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdListIntakeCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.grdListIntakeCourses.ColumnHeadersHeight = 30;
			this.grdListIntakeCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.grdListIntakeCourses.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdListIntakeCourses.DefaultCellStyle = dataGridViewCellStyle3;
			this.grdListIntakeCourses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdListIntakeCourses.EnableHeadersVisualStyles = false;
			this.grdListIntakeCourses.Location = new System.Drawing.Point(5, 5);
			this.grdListIntakeCourses.MultiSelect = false;
			this.grdListIntakeCourses.Name = "grdListIntakeCourses";
			this.grdListIntakeCourses.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grdListIntakeCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.grdListIntakeCourses.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.grdListIntakeCourses.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.grdListIntakeCourses.RowTemplate.Height = 35;
			this.grdListIntakeCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdListIntakeCourses.Size = new System.Drawing.Size(788, 340);
			this.grdListIntakeCourses.TabIndex = 5;
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlMain.Controls.Add(this.grdListIntakeCourses);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 50);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
			this.pnlMain.Size = new System.Drawing.Size(798, 350);
			this.pnlMain.TabIndex = 11;
			// 
			// IntakeCoursePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 500);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnRight);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "IntakeCoursePage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IntakeCoursePage";
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.pnlBottom.ResumeLayout(false);
			this.pnRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdListIntakeCourses)).EndInit();
			this.pnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlPrintBill;
		private System.Windows.Forms.Button btnPrintBill;
		private System.Windows.Forms.Panel pnlPrintWaybill;
		private System.Windows.Forms.Button btnCourseSubject;
		private System.Windows.Forms.Panel pnlGetApiOrders;
		private System.Windows.Forms.Button btnIntakeCourse;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnRight;
		private System.Windows.Forms.DataGridView grdListIntakeCourses;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Button btnDeleteIntakeCourse;
	}
}