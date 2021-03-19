namespace WinForm.UI.UI
{
	partial class ManageIntake
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
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.txtIntake = new System.Windows.Forms.TextBox();
			this.lblIntake = new System.Windows.Forms.Label();
			this.btnInsertIntake = new System.Windows.Forms.Button();
			this.btnDeleteIntake = new System.Windows.Forms.Button();
			this.gbxIntake = new System.Windows.Forms.GroupBox();
			this.chbxUsed = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtSearchIntake = new System.Windows.Forms.TextBox();
			this.dgvListIntake = new System.Windows.Forms.DataGridView();
			this.gbxCourse = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.dgvListCourse = new System.Windows.Forms.DataGridView();
			this.txtSearchCourse = new System.Windows.Forms.TextBox();
			this.btnUpdateCourse = new System.Windows.Forms.Button();
			this.btnDeleteCourse = new System.Windows.Forms.Button();
			this.btnInsertCourse = new System.Windows.Forms.Button();
			this.lblCourse = new System.Windows.Forms.Label();
			this.txtCourse = new System.Windows.Forms.TextBox();
			this.btnLinkIntakeCourse = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.pnlTop.SuspendLayout();
			this.gbxIntake.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListIntake)).BeginInit();
			this.gbxCourse.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourse)).BeginInit();
			this.SuspendLayout();
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(960, 9);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 3;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 426);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(984, 35);
			this.pnlBottom.TabIndex = 14;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(984, 40);
			this.pnlTop.TabIndex = 12;
			this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// txtIntake
			// 
			this.txtIntake.Location = new System.Drawing.Point(79, 220);
			this.txtIntake.Name = "txtIntake";
			this.txtIntake.Size = new System.Drawing.Size(255, 23);
			this.txtIntake.TabIndex = 1;
			// 
			// lblIntake
			// 
			this.lblIntake.AutoSize = true;
			this.lblIntake.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIntake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblIntake.Location = new System.Drawing.Point(17, 184);
			this.lblIntake.Name = "lblIntake";
			this.lblIntake.Size = new System.Drawing.Size(49, 16);
			this.lblIntake.TabIndex = 2;
			this.lblIntake.Text = "Intake";
			// 
			// btnInsertIntake
			// 
			this.btnInsertIntake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertIntake.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertIntake.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertIntake.Location = new System.Drawing.Point(19, 260);
			this.btnInsertIntake.Name = "btnInsertIntake";
			this.btnInsertIntake.Size = new System.Drawing.Size(138, 27);
			this.btnInsertIntake.TabIndex = 3;
			this.btnInsertIntake.Text = "Insert Intake";
			this.btnInsertIntake.UseVisualStyleBackColor = false;
			this.btnInsertIntake.Click += new System.EventHandler(this.btnInsertIntake_Click);
			// 
			// btnDeleteIntake
			// 
			this.btnDeleteIntake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnDeleteIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteIntake.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteIntake.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDeleteIntake.Location = new System.Drawing.Point(19, 293);
			this.btnDeleteIntake.Name = "btnDeleteIntake";
			this.btnDeleteIntake.Size = new System.Drawing.Size(138, 27);
			this.btnDeleteIntake.TabIndex = 5;
			this.btnDeleteIntake.Text = "Remove Intake";
			this.btnDeleteIntake.UseVisualStyleBackColor = false;
			this.btnDeleteIntake.Click += new System.EventHandler(this.btnDeleteIntake_Click);
			// 
			// gbxIntake
			// 
			this.gbxIntake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.gbxIntake.Controls.Add(this.chbxUsed);
			this.gbxIntake.Controls.Add(this.label1);
			this.gbxIntake.Controls.Add(this.pictureBox1);
			this.gbxIntake.Controls.Add(this.txtSearchIntake);
			this.gbxIntake.Controls.Add(this.dgvListIntake);
			this.gbxIntake.Controls.Add(this.btnDeleteIntake);
			this.gbxIntake.Controls.Add(this.btnInsertIntake);
			this.gbxIntake.Controls.Add(this.lblIntake);
			this.gbxIntake.Controls.Add(this.txtIntake);
			this.gbxIntake.Dock = System.Windows.Forms.DockStyle.Left;
			this.gbxIntake.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxIntake.ForeColor = System.Drawing.SystemColors.Control;
			this.gbxIntake.Location = new System.Drawing.Point(0, 40);
			this.gbxIntake.Name = "gbxIntake";
			this.gbxIntake.Size = new System.Drawing.Size(342, 386);
			this.gbxIntake.TabIndex = 15;
			this.gbxIntake.TabStop = false;
			this.gbxIntake.Text = "Intakes";
			// 
			// chbxUsed
			// 
			this.chbxUsed.AutoSize = true;
			this.chbxUsed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chbxUsed.Font = new System.Drawing.Font("MS Gothic", 13F);
			this.chbxUsed.Location = new System.Drawing.Point(202, 28);
			this.chbxUsed.Name = "chbxUsed";
			this.chbxUsed.Size = new System.Drawing.Size(132, 22);
			this.chbxUsed.TabIndex = 17;
			this.chbxUsed.Text = "Display Used";
			this.chbxUsed.UseVisualStyleBackColor = true;
			this.chbxUsed.CheckedChanged += new System.EventHandler(this.chbxUsed_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(22, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Intake";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pictureBox1.Location = new System.Drawing.Point(12, 23);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// txtSearchIntake
			// 
			this.txtSearchIntake.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.txtSearchIntake.Location = new System.Drawing.Point(46, 26);
			this.txtSearchIntake.Name = "txtSearchIntake";
			this.txtSearchIntake.Size = new System.Drawing.Size(150, 24);
			this.txtSearchIntake.TabIndex = 6;
			this.txtSearchIntake.TextChanged += new System.EventHandler(this.txtSearchIntake_TextChanged);
			// 
			// dgvListIntake
			// 
			this.dgvListIntake.AllowUserToAddRows = false;
			this.dgvListIntake.AllowUserToDeleteRows = false;
			this.dgvListIntake.AllowUserToOrderColumns = true;
			this.dgvListIntake.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListIntake.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListIntake.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListIntake.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListIntake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListIntake.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListIntake.ColumnHeadersHeight = 30;
			this.dgvListIntake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListIntake.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListIntake.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListIntake.EnableHeadersVisualStyles = false;
			this.dgvListIntake.Location = new System.Drawing.Point(12, 57);
			this.dgvListIntake.MultiSelect = false;
			this.dgvListIntake.Name = "dgvListIntake";
			this.dgvListIntake.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListIntake.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListIntake.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvListIntake.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvListIntake.RowTemplate.Height = 35;
			this.dgvListIntake.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListIntake.Size = new System.Drawing.Size(321, 143);
			this.dgvListIntake.TabIndex = 7;
			this.dgvListIntake.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListIntake_CellClick);
			this.dgvListIntake.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListIntake_CellEnter);
			// 
			// gbxCourse
			// 
			this.gbxCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.gbxCourse.Controls.Add(this.pictureBox2);
			this.gbxCourse.Controls.Add(this.dgvListCourse);
			this.gbxCourse.Controls.Add(this.txtSearchCourse);
			this.gbxCourse.Controls.Add(this.btnUpdateCourse);
			this.gbxCourse.Controls.Add(this.btnDeleteCourse);
			this.gbxCourse.Controls.Add(this.btnInsertCourse);
			this.gbxCourse.Controls.Add(this.lblCourse);
			this.gbxCourse.Controls.Add(this.txtCourse);
			this.gbxCourse.Dock = System.Windows.Forms.DockStyle.Right;
			this.gbxCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.gbxCourse.Location = new System.Drawing.Point(642, 40);
			this.gbxCourse.Name = "gbxCourse";
			this.gbxCourse.Size = new System.Drawing.Size(342, 386);
			this.gbxCourse.TabIndex = 16;
			this.gbxCourse.TabStop = false;
			this.gbxCourse.Text = "Courses";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pictureBox2.Location = new System.Drawing.Point(12, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 8;
			this.pictureBox2.TabStop = false;
			// 
			// dgvListCourse
			// 
			this.dgvListCourse.AllowUserToAddRows = false;
			this.dgvListCourse.AllowUserToDeleteRows = false;
			this.dgvListCourse.AllowUserToOrderColumns = true;
			this.dgvListCourse.AllowUserToResizeRows = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvListCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListCourse.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListCourse.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvListCourse.ColumnHeadersHeight = 30;
			this.dgvListCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListCourse.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListCourse.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvListCourse.EnableHeadersVisualStyles = false;
			this.dgvListCourse.Location = new System.Drawing.Point(12, 57);
			this.dgvListCourse.MultiSelect = false;
			this.dgvListCourse.Name = "dgvListCourse";
			this.dgvListCourse.ReadOnly = true;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvListCourse.RowHeadersVisible = false;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
			this.dgvListCourse.RowsDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvListCourse.RowTemplate.Height = 35;
			this.dgvListCourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListCourse.Size = new System.Drawing.Size(321, 143);
			this.dgvListCourse.TabIndex = 8;
			this.dgvListCourse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCourse_CellClick);
			this.dgvListCourse.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCourse_CellEnter);
			// 
			// txtSearchCourse
			// 
			this.txtSearchCourse.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.txtSearchCourse.Location = new System.Drawing.Point(46, 27);
			this.txtSearchCourse.Name = "txtSearchCourse";
			this.txtSearchCourse.Size = new System.Drawing.Size(150, 24);
			this.txtSearchCourse.TabIndex = 9;
			this.txtSearchCourse.TextChanged += new System.EventHandler(this.txtSearchCourse_TextChanged);
			// 
			// btnUpdateCourse
			// 
			this.btnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdateCourse.Location = new System.Drawing.Point(21, 326);
			this.btnUpdateCourse.Name = "btnUpdateCourse";
			this.btnUpdateCourse.Size = new System.Drawing.Size(138, 27);
			this.btnUpdateCourse.TabIndex = 6;
			this.btnUpdateCourse.Text = "Update Course";
			this.btnUpdateCourse.UseVisualStyleBackColor = false;
			this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
			// 
			// btnDeleteCourse
			// 
			this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDeleteCourse.Location = new System.Drawing.Point(21, 293);
			this.btnDeleteCourse.Name = "btnDeleteCourse";
			this.btnDeleteCourse.Size = new System.Drawing.Size(138, 27);
			this.btnDeleteCourse.TabIndex = 5;
			this.btnDeleteCourse.Text = "Remove Course";
			this.btnDeleteCourse.UseVisualStyleBackColor = false;
			this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
			// 
			// btnInsertCourse
			// 
			this.btnInsertCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertCourse.Location = new System.Drawing.Point(21, 260);
			this.btnInsertCourse.Name = "btnInsertCourse";
			this.btnInsertCourse.Size = new System.Drawing.Size(138, 27);
			this.btnInsertCourse.TabIndex = 3;
			this.btnInsertCourse.Text = "Insert Course";
			this.btnInsertCourse.UseVisualStyleBackColor = false;
			this.btnInsertCourse.Click += new System.EventHandler(this.btnInsertCourse_Click);
			// 
			// lblCourse
			// 
			this.lblCourse.AutoSize = true;
			this.lblCourse.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCourse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblCourse.Location = new System.Drawing.Point(18, 221);
			this.lblCourse.Name = "lblCourse";
			this.lblCourse.Size = new System.Drawing.Size(56, 16);
			this.lblCourse.TabIndex = 2;
			this.lblCourse.Text = "Course";
			// 
			// txtCourse
			// 
			this.txtCourse.Location = new System.Drawing.Point(80, 218);
			this.txtCourse.Name = "txtCourse";
			this.txtCourse.Size = new System.Drawing.Size(253, 23);
			this.txtCourse.TabIndex = 1;
			// 
			// btnLinkIntakeCourse
			// 
			this.btnLinkIntakeCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnLinkIntakeCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLinkIntakeCourse.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLinkIntakeCourse.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnLinkIntakeCourse.Location = new System.Drawing.Point(388, 193);
			this.btnLinkIntakeCourse.Name = "btnLinkIntakeCourse";
			this.btnLinkIntakeCourse.Size = new System.Drawing.Size(201, 47);
			this.btnLinkIntakeCourse.TabIndex = 11;
			this.btnLinkIntakeCourse.Text = "Link Intake And Course";
			this.btnLinkIntakeCourse.UseVisualStyleBackColor = false;
			this.btnLinkIntakeCourse.Click += new System.EventHandler(this.btnLinkIntakeCourse_Click);
			// 
			// ManageIntake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.btnLinkIntakeCourse);
			this.Controls.Add(this.gbxCourse);
			this.Controls.Add(this.gbxIntake);
			this.Controls.Add(this.pnlBottom);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageIntake";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageIntakes";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.pnlTop.ResumeLayout(false);
			this.gbxIntake.ResumeLayout(false);
			this.gbxIntake.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListIntake)).EndInit();
			this.gbxCourse.ResumeLayout(false);
			this.gbxCourse.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCourse)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.TextBox txtIntake;
		private System.Windows.Forms.Label lblIntake;
		private System.Windows.Forms.Button btnInsertIntake;
		private System.Windows.Forms.Button btnDeleteIntake;
		private System.Windows.Forms.GroupBox gbxIntake;
		private System.Windows.Forms.GroupBox gbxCourse;
		private System.Windows.Forms.Button btnDeleteCourse;
		private System.Windows.Forms.Button btnInsertCourse;
		private System.Windows.Forms.Label lblCourse;
		private System.Windows.Forms.TextBox txtCourse;
		private System.Windows.Forms.Button btnUpdateCourse;
		private System.Windows.Forms.DataGridView dgvListIntake;
		private System.Windows.Forms.DataGridView dgvListCourse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtSearchIntake;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtSearchCourse;
		private System.Windows.Forms.Button btnLinkIntakeCourse;
		private System.Windows.Forms.CheckBox chbxUsed;
	}
}