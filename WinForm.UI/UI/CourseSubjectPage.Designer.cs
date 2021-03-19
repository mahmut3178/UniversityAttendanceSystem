namespace WinForm.UI.UI
{
	partial class CourseSubjectPage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.gbxCourse = new System.Windows.Forms.GroupBox();
			this.dgvListCourse = new System.Windows.Forms.DataGridView();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtSearchCourse = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnManageSubjects = new System.Windows.Forms.Button();
			this.lstBoxSubject = new System.Windows.Forms.ListBox();
			this.txtSearchSubject = new System.Windows.Forms.TextBox();
			this.btnRemoveSubject = new System.Windows.Forms.Button();
			this.btnInsertSubject = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dgvListCourseSubject = new System.Windows.Forms.DataGridView();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.gbxCourse.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourseSubject)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 396);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(984, 65);
			this.pnlBottom.TabIndex = 14;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(984, 30);
			this.pnlTop.TabIndex = 12;
			this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(960, 6);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 3;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// gbxCourse
			// 
			this.gbxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.gbxCourse.Controls.Add(this.dgvListCourse);
			this.gbxCourse.Controls.Add(this.pictureBox2);
			this.gbxCourse.Controls.Add(this.txtSearchCourse);
			this.gbxCourse.Dock = System.Windows.Forms.DockStyle.Left;
			this.gbxCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.gbxCourse.Location = new System.Drawing.Point(0, 30);
			this.gbxCourse.Name = "gbxCourse";
			this.gbxCourse.Size = new System.Drawing.Size(317, 366);
			this.gbxCourse.TabIndex = 17;
			this.gbxCourse.TabStop = false;
			this.gbxCourse.Text = "Courses";
			// 
			// dgvListCourse
			// 
			this.dgvListCourse.AllowUserToAddRows = false;
			this.dgvListCourse.AllowUserToDeleteRows = false;
			this.dgvListCourse.AllowUserToOrderColumns = true;
			this.dgvListCourse.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
			this.dgvListCourse.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListCourse.ColumnHeadersHeight = 30;
			this.dgvListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListCourse.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListCourse.EnableHeadersVisualStyles = false;
			this.dgvListCourse.Location = new System.Drawing.Point(18, 58);
			this.dgvListCourse.MultiSelect = false;
			this.dgvListCourse.Name = "dgvListCourse";
			this.dgvListCourse.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListCourse.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvListCourse.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvListCourse.RowTemplate.Height = 35;
			this.dgvListCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListCourse.Size = new System.Drawing.Size(275, 280);
			this.dgvListCourse.TabIndex = 8;
			this.dgvListCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCourse_CellClick);
			this.dgvListCourse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCourse_CellEnter);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pictureBox2.Location = new System.Drawing.Point(18, 25);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// txtSearchCourse
			// 
			this.txtSearchCourse.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.txtSearchCourse.Location = new System.Drawing.Point(52, 28);
			this.txtSearchCourse.Name = "txtSearchCourse";
			this.txtSearchCourse.Size = new System.Drawing.Size(150, 24);
			this.txtSearchCourse.TabIndex = 9;
			this.txtSearchCourse.TextChanged += new System.EventHandler(this.txtSearchCourse_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.groupBox1.Controls.Add(this.btnManageSubjects);
			this.groupBox1.Controls.Add(this.lstBoxSubject);
			this.groupBox1.Controls.Add(this.txtSearchSubject);
			this.groupBox1.Controls.Add(this.btnRemoveSubject);
			this.groupBox1.Controls.Add(this.btnInsertSubject);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.dgvListCourseSubject);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new System.Drawing.Point(382, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(602, 366);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Subjects";
			// 
			// btnManageSubjects
			// 
			this.btnManageSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnManageSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageSubjects.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageSubjects.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnManageSubjects.Location = new System.Drawing.Point(504, 239);
			this.btnManageSubjects.Name = "btnManageSubjects";
			this.btnManageSubjects.Size = new System.Drawing.Size(86, 27);
			this.btnManageSubjects.TabIndex = 14;
			this.btnManageSubjects.Text = "Subjects";
			this.btnManageSubjects.UseVisualStyleBackColor = false;
			this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click);
			// 
			// lstBoxSubject
			// 
			this.lstBoxSubject.BackColor = System.Drawing.Color.White;
			this.lstBoxSubject.FormattingEnabled = true;
			this.lstBoxSubject.HorizontalScrollbar = true;
			this.lstBoxSubject.ItemHeight = 16;
			this.lstBoxSubject.Location = new System.Drawing.Point(360, 57);
			this.lstBoxSubject.Name = "lstBoxSubject";
			this.lstBoxSubject.Size = new System.Drawing.Size(233, 164);
			this.lstBoxSubject.TabIndex = 13;
			// 
			// txtSearchSubject
			// 
			this.txtSearchSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSearchSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSearchSubject.Location = new System.Drawing.Point(393, 28);
			this.txtSearchSubject.Name = "txtSearchSubject";
			this.txtSearchSubject.Size = new System.Drawing.Size(156, 23);
			this.txtSearchSubject.TabIndex = 12;
			this.txtSearchSubject.TextChanged += new System.EventHandler(this.txtSearchSubject_TextChanged);
			// 
			// btnRemoveSubject
			// 
			this.btnRemoveSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnRemoveSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRemoveSubject.Location = new System.Drawing.Point(6, 239);
			this.btnRemoveSubject.Name = "btnRemoveSubject";
			this.btnRemoveSubject.Size = new System.Drawing.Size(138, 27);
			this.btnRemoveSubject.TabIndex = 11;
			this.btnRemoveSubject.Text = "Remove Subject";
			this.btnRemoveSubject.UseVisualStyleBackColor = false;
			this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
			// 
			// btnInsertSubject
			// 
			this.btnInsertSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertSubject.Location = new System.Drawing.Point(360, 239);
			this.btnInsertSubject.Name = "btnInsertSubject";
			this.btnInsertSubject.Size = new System.Drawing.Size(138, 27);
			this.btnInsertSubject.TabIndex = 10;
			this.btnInsertSubject.Text = "Insert Subject";
			this.btnInsertSubject.UseVisualStyleBackColor = false;
			this.btnInsertSubject.Click += new System.EventHandler(this.btnInsertSubject_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pictureBox1.Location = new System.Drawing.Point(359, 26);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// dgvListCourseSubject
			// 
			this.dgvListCourseSubject.AllowUserToAddRows = false;
			this.dgvListCourseSubject.AllowUserToDeleteRows = false;
			this.dgvListCourseSubject.AllowUserToOrderColumns = true;
			this.dgvListCourseSubject.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListCourseSubject.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvListCourseSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListCourseSubject.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListCourseSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourseSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvListCourseSubject.ColumnHeadersHeight = 30;
			this.dgvListCourseSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListCourseSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListCourseSubject.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvListCourseSubject.EnableHeadersVisualStyles = false;
			this.dgvListCourseSubject.Location = new System.Drawing.Point(6, 58);
			this.dgvListCourseSubject.MultiSelect = false;
			this.dgvListCourseSubject.Name = "dgvListCourseSubject";
			this.dgvListCourseSubject.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourseSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvListCourseSubject.RowHeadersVisible = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.dgvListCourseSubject.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvListCourseSubject.RowTemplate.Height = 35;
			this.dgvListCourseSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListCourseSubject.Size = new System.Drawing.Size(339, 163);
			this.dgvListCourseSubject.TabIndex = 8;
			// 
			// CourseSubjectPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxCourse);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CourseSubjectPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CourseSubjectPage";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.gbxCourse.ResumeLayout(false);
			this.gbxCourse.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourseSubject)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.GroupBox gbxCourse;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DataGridView dgvListCourse;
		private System.Windows.Forms.TextBox txtSearchCourse;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvListCourseSubject;
		private System.Windows.Forms.TextBox txtSearchSubject;
		private System.Windows.Forms.Button btnRemoveSubject;
		private System.Windows.Forms.Button btnInsertSubject;
		private System.Windows.Forms.ListBox lstBoxSubject;
		private System.Windows.Forms.Button btnManageSubjects;
	}
}