namespace WinForm.UI.UI
{
	partial class AdminTimeTablePage
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
			this.cbxIntake = new System.Windows.Forms.ComboBox();
			this.pnlBottom = new System.Windows.Forms.Panel();
			this.gbxTimeTable = new System.Windows.Forms.GroupBox();
			this.nudDuration = new System.Windows.Forms.NumericUpDown();
			this.lblTime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpSubjectTime = new System.Windows.Forms.DateTimePicker();
			this.lblSubjectDay = new System.Windows.Forms.Label();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lblLecturer = new System.Windows.Forms.Label();
			this.cbxSubject = new System.Windows.Forms.ComboBox();
			this.lblIntake = new System.Windows.Forms.Label();
			this.btnInsertTimeTable = new System.Windows.Forms.Button();
			this.cbxLecturer = new System.Windows.Forms.ComboBox();
			this.cbxDayOfWeek = new System.Windows.Forms.ComboBox();
			this.btnDeleteTimeTable = new System.Windows.Forms.Button();
			this.btnUpdateTimeTable = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlTimeTable = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbxClassRoom = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvListIntakeTimeTable = new System.Windows.Forms.DataGridView();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cbxSearchIntake = new System.Windows.Forms.ComboBox();
			this.cbxSearchLecturer = new System.Windows.Forms.ComboBox();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cbxSearchDay = new System.Windows.Forms.ComboBox();
			this.pnlBottom.SuspendLayout();
			this.gbxTimeTable.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListIntakeTimeTable)).BeginInit();
			this.pnlMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxIntake
			// 
			this.cbxIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxIntake.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxIntake.FormattingEnabled = true;
			this.cbxIntake.Location = new System.Drawing.Point(113, 34);
			this.cbxIntake.Name = "cbxIntake";
			this.cbxIntake.Size = new System.Drawing.Size(140, 25);
			this.cbxIntake.TabIndex = 3;
			this.cbxIntake.SelectedIndexChanged += new System.EventHandler(this.cbxIntake_SelectedIndexChanged);
			// 
			// pnlBottom
			// 
			this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlBottom.Controls.Add(this.gbxTimeTable);
			this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlBottom.Location = new System.Drawing.Point(0, 403);
			this.pnlBottom.Name = "pnlBottom";
			this.pnlBottom.Size = new System.Drawing.Size(800, 179);
			this.pnlBottom.TabIndex = 14;
			// 
			// gbxTimeTable
			// 
			this.gbxTimeTable.Controls.Add(this.nudDuration);
			this.gbxTimeTable.Controls.Add(this.lblTime);
			this.gbxTimeTable.Controls.Add(this.label2);
			this.gbxTimeTable.Controls.Add(this.dtpSubjectTime);
			this.gbxTimeTable.Controls.Add(this.lblSubjectDay);
			this.gbxTimeTable.Controls.Add(this.lblSubject);
			this.gbxTimeTable.Controls.Add(this.lblLecturer);
			this.gbxTimeTable.Controls.Add(this.cbxSubject);
			this.gbxTimeTable.Controls.Add(this.lblIntake);
			this.gbxTimeTable.Controls.Add(this.btnInsertTimeTable);
			this.gbxTimeTable.Controls.Add(this.cbxLecturer);
			this.gbxTimeTable.Controls.Add(this.cbxDayOfWeek);
			this.gbxTimeTable.Controls.Add(this.cbxIntake);
			this.gbxTimeTable.Controls.Add(this.btnDeleteTimeTable);
			this.gbxTimeTable.Controls.Add(this.btnUpdateTimeTable);
			this.gbxTimeTable.Controls.Add(this.panel2);
			this.gbxTimeTable.Controls.Add(this.pnlTimeTable);
			this.gbxTimeTable.Controls.Add(this.panel1);
			this.gbxTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbxTimeTable.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxTimeTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.gbxTimeTable.Location = new System.Drawing.Point(0, 0);
			this.gbxTimeTable.Name = "gbxTimeTable";
			this.gbxTimeTable.Size = new System.Drawing.Size(800, 179);
			this.gbxTimeTable.TabIndex = 12;
			this.gbxTimeTable.TabStop = false;
			this.gbxTimeTable.Text = "TimeTable";
			// 
			// nudDuration
			// 
			this.nudDuration.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDuration.Location = new System.Drawing.Point(412, 99);
			this.nudDuration.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
			this.nudDuration.Name = "nudDuration";
			this.nudDuration.Size = new System.Drawing.Size(140, 28);
			this.nudDuration.TabIndex = 18;
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(276, 101);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(130, 21);
			this.lblTime.TabIndex = 17;
			this.lblTime.Text = "Duration(Mins)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(276, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 21);
			this.label2.TabIndex = 15;
			this.label2.Text = "Time";
			// 
			// dtpSubjectTime
			// 
			this.dtpSubjectTime.CustomFormat = "";
			this.dtpSubjectTime.Location = new System.Drawing.Point(412, 65);
			this.dtpSubjectTime.Name = "dtpSubjectTime";
			this.dtpSubjectTime.Size = new System.Drawing.Size(140, 28);
			this.dtpSubjectTime.TabIndex = 11;
			this.dtpSubjectTime.Value = new System.DateTime(2021, 1, 10, 11, 15, 0, 0);
			// 
			// lblSubjectDay
			// 
			this.lblSubjectDay.AutoSize = true;
			this.lblSubjectDay.Location = new System.Drawing.Point(276, 36);
			this.lblSubjectDay.Name = "lblSubjectDay";
			this.lblSubjectDay.Size = new System.Drawing.Size(43, 21);
			this.lblSubjectDay.TabIndex = 14;
			this.lblSubjectDay.Text = "Day";
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Location = new System.Drawing.Point(29, 123);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(72, 21);
			this.lblSubject.TabIndex = 13;
			this.lblSubject.Text = "Subject";
			// 
			// lblLecturer
			// 
			this.lblLecturer.AutoSize = true;
			this.lblLecturer.Location = new System.Drawing.Point(29, 81);
			this.lblLecturer.Name = "lblLecturer";
			this.lblLecturer.Size = new System.Drawing.Size(78, 21);
			this.lblLecturer.TabIndex = 12;
			this.lblLecturer.Text = "Lecturer";
			// 
			// cbxSubject
			// 
			this.cbxSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxSubject.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxSubject.FormattingEnabled = true;
			this.cbxSubject.Location = new System.Drawing.Point(113, 121);
			this.cbxSubject.Name = "cbxSubject";
			this.cbxSubject.Size = new System.Drawing.Size(140, 25);
			this.cbxSubject.TabIndex = 5;
			// 
			// lblIntake
			// 
			this.lblIntake.AutoSize = true;
			this.lblIntake.Location = new System.Drawing.Point(29, 36);
			this.lblIntake.Name = "lblIntake";
			this.lblIntake.Size = new System.Drawing.Size(64, 21);
			this.lblIntake.TabIndex = 11;
			this.lblIntake.Text = "Intake";
			// 
			// btnInsertTimeTable
			// 
			this.btnInsertTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertTimeTable.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertTimeTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertTimeTable.Location = new System.Drawing.Point(590, 41);
			this.btnInsertTimeTable.Name = "btnInsertTimeTable";
			this.btnInsertTimeTable.Size = new System.Drawing.Size(178, 27);
			this.btnInsertTimeTable.TabIndex = 8;
			this.btnInsertTimeTable.Text = "Insert TimeTable";
			this.btnInsertTimeTable.UseVisualStyleBackColor = false;
			this.btnInsertTimeTable.Click += new System.EventHandler(this.btnInsertTimeTable_Click);
			// 
			// cbxLecturer
			// 
			this.cbxLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxLecturer.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxLecturer.FormattingEnabled = true;
			this.cbxLecturer.Location = new System.Drawing.Point(113, 79);
			this.cbxLecturer.Name = "cbxLecturer";
			this.cbxLecturer.Size = new System.Drawing.Size(140, 25);
			this.cbxLecturer.TabIndex = 4;
			// 
			// cbxDayOfWeek
			// 
			this.cbxDayOfWeek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxDayOfWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxDayOfWeek.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxDayOfWeek.FormattingEnabled = true;
			this.cbxDayOfWeek.Location = new System.Drawing.Point(412, 34);
			this.cbxDayOfWeek.Name = "cbxDayOfWeek";
			this.cbxDayOfWeek.Size = new System.Drawing.Size(140, 25);
			this.cbxDayOfWeek.TabIndex = 10;
			// 
			// btnDeleteTimeTable
			// 
			this.btnDeleteTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnDeleteTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteTimeTable.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteTimeTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDeleteTimeTable.Location = new System.Drawing.Point(590, 85);
			this.btnDeleteTimeTable.Name = "btnDeleteTimeTable";
			this.btnDeleteTimeTable.Size = new System.Drawing.Size(178, 27);
			this.btnDeleteTimeTable.TabIndex = 7;
			this.btnDeleteTimeTable.Text = "Remove TimeTable";
			this.btnDeleteTimeTable.UseVisualStyleBackColor = false;
			this.btnDeleteTimeTable.Click += new System.EventHandler(this.btnDeleteTimeTable_Click);
			// 
			// btnUpdateTimeTable
			// 
			this.btnUpdateTimeTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnUpdateTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateTimeTable.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateTimeTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdateTimeTable.Location = new System.Drawing.Point(590, 127);
			this.btnUpdateTimeTable.Name = "btnUpdateTimeTable";
			this.btnUpdateTimeTable.Size = new System.Drawing.Size(178, 27);
			this.btnUpdateTimeTable.TabIndex = 9;
			this.btnUpdateTimeTable.Text = "Update TimeTable";
			this.btnUpdateTimeTable.UseVisualStyleBackColor = false;
			this.btnUpdateTimeTable.Click += new System.EventHandler(this.btnUpdateTimeTable_Click);
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(567, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(230, 152);
			this.panel2.TabIndex = 20;
			// 
			// pnlTimeTable
			// 
			this.pnlTimeTable.Location = new System.Drawing.Point(9, 24);
			this.pnlTimeTable.Name = "pnlTimeTable";
			this.pnlTimeTable.Size = new System.Drawing.Size(261, 143);
			this.pnlTimeTable.TabIndex = 19;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbxClassRoom);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(794, 152);
			this.panel1.TabIndex = 20;
			// 
			// cbxClassRoom
			// 
			this.cbxClassRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxClassRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxClassRoom.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxClassRoom.FormattingEnabled = true;
			this.cbxClassRoom.Location = new System.Drawing.Point(409, 112);
			this.cbxClassRoom.Name = "cbxClassRoom";
			this.cbxClassRoom.Size = new System.Drawing.Size(140, 25);
			this.cbxClassRoom.TabIndex = 23;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(273, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 21);
			this.label1.TabIndex = 22;
			this.label1.Text = "Class";
			// 
			// dgvListIntakeTimeTable
			// 
			this.dgvListIntakeTimeTable.AllowUserToAddRows = false;
			this.dgvListIntakeTimeTable.AllowUserToDeleteRows = false;
			this.dgvListIntakeTimeTable.AllowUserToOrderColumns = true;
			this.dgvListIntakeTimeTable.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListIntakeTimeTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListIntakeTimeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvListIntakeTimeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dgvListIntakeTimeTable.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListIntakeTimeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListIntakeTimeTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListIntakeTimeTable.ColumnHeadersHeight = 30;
			this.dgvListIntakeTimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListIntakeTimeTable.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListIntakeTimeTable.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListIntakeTimeTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvListIntakeTimeTable.EnableHeadersVisualStyles = false;
			this.dgvListIntakeTimeTable.Location = new System.Drawing.Point(5, 5);
			this.dgvListIntakeTimeTable.MultiSelect = false;
			this.dgvListIntakeTimeTable.Name = "dgvListIntakeTimeTable";
			this.dgvListIntakeTimeTable.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListIntakeTimeTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListIntakeTimeTable.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvListIntakeTimeTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvListIntakeTimeTable.RowTemplate.Height = 35;
			this.dgvListIntakeTimeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListIntakeTimeTable.Size = new System.Drawing.Size(790, 337);
			this.dgvListIntakeTimeTable.TabIndex = 5;
			this.dgvListIntakeTimeTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListIntakeTimeTable_CellClick);
			// 
			// pnlMain
			// 
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlMain.Controls.Add(this.dgvListIntakeTimeTable);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 56);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
			this.pnlMain.Size = new System.Drawing.Size(800, 347);
			this.pnlMain.TabIndex = 15;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(774, -129);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 3;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// pbxSearch
			// 
			this.pbxSearch.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pbxSearch.Location = new System.Drawing.Point(2, 11);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(28, 28);
			this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxSearch.TabIndex = 5;
			this.pbxSearch.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.pictureBox1.Location = new System.Drawing.Point(782, -28);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(15, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// cbxSearchIntake
			// 
			this.cbxSearchIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxSearchIntake.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxSearchIntake.FormattingEnabled = true;
			this.cbxSearchIntake.Location = new System.Drawing.Point(36, 13);
			this.cbxSearchIntake.Name = "cbxSearchIntake";
			this.cbxSearchIntake.Size = new System.Drawing.Size(140, 25);
			this.cbxSearchIntake.TabIndex = 11;
			this.cbxSearchIntake.SelectedIndexChanged += new System.EventHandler(this.cbxSearchIntake_SelectedIndexChanged);
			// 
			// cbxSearchLecturer
			// 
			this.cbxSearchLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxSearchLecturer.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxSearchLecturer.FormattingEnabled = true;
			this.cbxSearchLecturer.Location = new System.Drawing.Point(183, 13);
			this.cbxSearchLecturer.Name = "cbxSearchLecturer";
			this.cbxSearchLecturer.Size = new System.Drawing.Size(140, 25);
			this.cbxSearchLecturer.TabIndex = 12;
			this.cbxSearchLecturer.SelectedIndexChanged += new System.EventHandler(this.cbxSearchLecturer_SelectedIndexChanged);
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTop.Controls.Add(this.pictureBox2);
			this.pnlTop.Controls.Add(this.cbxSearchDay);
			this.pnlTop.Controls.Add(this.cbxSearchLecturer);
			this.pnlTop.Controls.Add(this.cbxSearchIntake);
			this.pnlTop.Controls.Add(this.pictureBox1);
			this.pnlTop.Controls.Add(this.pbxSearch);
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(800, 56);
			this.pnlTop.TabIndex = 12;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.pictureBox2.Location = new System.Drawing.Point(774, 11);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(15, 16);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 14;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// cbxSearchDay
			// 
			this.cbxSearchDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxSearchDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxSearchDay.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxSearchDay.FormattingEnabled = true;
			this.cbxSearchDay.Location = new System.Drawing.Point(329, 13);
			this.cbxSearchDay.Name = "cbxSearchDay";
			this.cbxSearchDay.Size = new System.Drawing.Size(140, 25);
			this.cbxSearchDay.TabIndex = 13;
			this.cbxSearchDay.SelectedIndexChanged += new System.EventHandler(this.cbxSearchDay_SelectedIndexChanged);
			// 
			// AdminTimeTablePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 582);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlBottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminTimeTablePage";
			this.Text = "AdminTimeTablePage";
			this.SizeChanged += new System.EventHandler(this.AdminTimeTablePage_SizeChanged);
			this.pnlBottom.ResumeLayout(false);
			this.gbxTimeTable.ResumeLayout(false);
			this.gbxTimeTable.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListIntakeTimeTable)).EndInit();
			this.pnlMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox cbxIntake;
		private System.Windows.Forms.Panel pnlBottom;
		private System.Windows.Forms.DataGridView dgvListIntakeTimeTable;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.ComboBox cbxSubject;
		private System.Windows.Forms.ComboBox cbxLecturer;
		private System.Windows.Forms.Button btnUpdateTimeTable;
		private System.Windows.Forms.Button btnInsertTimeTable;
		private System.Windows.Forms.Button btnDeleteTimeTable;
		private System.Windows.Forms.ComboBox cbxDayOfWeek;
		private System.Windows.Forms.DateTimePicker dtpSubjectTime;
		private System.Windows.Forms.GroupBox gbxTimeTable;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSubjectDay;
		private System.Windows.Forms.Label lblSubject;
		private System.Windows.Forms.Label lblLecturer;
		private System.Windows.Forms.Label lblIntake;
		private System.Windows.Forms.NumericUpDown nudDuration;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cbxSearchIntake;
		private System.Windows.Forms.ComboBox cbxSearchLecturer;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Panel pnlTimeTable;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ComboBox cbxSearchDay;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxClassRoom;
	}
}