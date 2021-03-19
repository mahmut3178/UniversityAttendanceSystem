namespace WinForm.UI.UI
{
	partial class ManageStudentPage
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.lblDateOfBirth = new System.Windows.Forms.Label();
			this.btnNewUser = new System.Windows.Forms.Button();
			this.btnRemoveUser = new System.Windows.Forms.Button();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.btnInsertUser = new System.Windows.Forms.Button();
			this.lblEmail = new System.Windows.Forms.Label();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSearchLecturer = new System.Windows.Forms.TextBox();
			this.dgvListStudent = new System.Windows.Forms.DataGridView();
			this.pbxSearch = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbxStudentIntake = new System.Windows.Forms.ComboBox();
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.pbxUserPicture = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRemoveUserPictureBoxImage = new System.Windows.Forms.Button();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pnlMain.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxUserPicture)).BeginInit();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(310, 313);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(131, 23);
			this.txtEmail.TabIndex = 22;
			// 
			// lblDateOfBirth
			// 
			this.lblDateOfBirth.AutoSize = true;
			this.lblDateOfBirth.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDateOfBirth.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblDateOfBirth.Location = new System.Drawing.Point(197, 280);
			this.lblDateOfBirth.Name = "lblDateOfBirth";
			this.lblDateOfBirth.Size = new System.Drawing.Size(98, 16);
			this.lblDateOfBirth.TabIndex = 29;
			this.lblDateOfBirth.Text = "Birth Date";
			// 
			// btnNewUser
			// 
			this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewUser.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnNewUser.Location = new System.Drawing.Point(372, 19);
			this.btnNewUser.Name = "btnNewUser";
			this.btnNewUser.Size = new System.Drawing.Size(69, 27);
			this.btnNewUser.TabIndex = 27;
			this.btnNewUser.Text = "New";
			this.btnNewUser.UseVisualStyleBackColor = false;
			this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
			// 
			// btnRemoveUser
			// 
			this.btnRemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveUser.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRemoveUser.Location = new System.Drawing.Point(6, 366);
			this.btnRemoveUser.Name = "btnRemoveUser";
			this.btnRemoveUser.Size = new System.Drawing.Size(128, 27);
			this.btnRemoveUser.TabIndex = 26;
			this.btnRemoveUser.Text = "Remove User";
			this.btnRemoveUser.UseVisualStyleBackColor = false;
			this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateUser.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdateUser.Location = new System.Drawing.Point(158, 366);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(128, 27);
			this.btnUpdateUser.TabIndex = 25;
			this.btnUpdateUser.Text = "Update User";
			this.btnUpdateUser.UseVisualStyleBackColor = false;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// btnInsertUser
			// 
			this.btnInsertUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertUser.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertUser.Location = new System.Drawing.Point(310, 366);
			this.btnInsertUser.Name = "btnInsertUser";
			this.btnInsertUser.Size = new System.Drawing.Size(128, 27);
			this.btnInsertUser.TabIndex = 24;
			this.btnInsertUser.Text = "Insert User";
			this.btnInsertUser.UseVisualStyleBackColor = false;
			this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblEmail.Location = new System.Drawing.Point(197, 316);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(53, 16);
			this.lblEmail.TabIndex = 23;
			this.lblEmail.Text = "Email";
			// 
			// pnlMain
			// 
			this.pnlMain.AutoScroll = true;
			this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlMain.Controls.Add(this.groupBox2);
			this.pnlMain.Controls.Add(this.groupBox1);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 50);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
			this.pnlMain.Size = new System.Drawing.Size(978, 427);
			this.pnlMain.TabIndex = 17;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.groupBox2.Controls.Add(this.txtSearchLecturer);
			this.groupBox2.Controls.Add(this.dgvListStudent);
			this.groupBox2.Controls.Add(this.pbxSearch);
			this.groupBox2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox2.Location = new System.Drawing.Point(468, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(508, 399);
			this.groupBox2.TabIndex = 27;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Students List";
			// 
			// txtSearchLecturer
			// 
			this.txtSearchLecturer.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.txtSearchLecturer.Location = new System.Drawing.Point(40, 22);
			this.txtSearchLecturer.Name = "txtSearchLecturer";
			this.txtSearchLecturer.Size = new System.Drawing.Size(150, 24);
			this.txtSearchLecturer.TabIndex = 0;
			this.txtSearchLecturer.TextChanged += new System.EventHandler(this.txtSearchLecturer_TextChanged);
			// 
			// dgvListStudent
			// 
			this.dgvListStudent.AllowUserToAddRows = false;
			this.dgvListStudent.AllowUserToDeleteRows = false;
			this.dgvListStudent.AllowUserToOrderColumns = true;
			this.dgvListStudent.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvListStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvListStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvListStudent.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvListStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListStudent.ColumnHeadersHeight = 30;
			this.dgvListStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListStudent.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListStudent.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListStudent.EnableHeadersVisualStyles = false;
			this.dgvListStudent.Location = new System.Drawing.Point(6, 52);
			this.dgvListStudent.MultiSelect = false;
			this.dgvListStudent.Name = "dgvListStudent";
			this.dgvListStudent.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListStudent.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvListStudent.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvListStudent.RowTemplate.Height = 35;
			this.dgvListStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListStudent.Size = new System.Drawing.Size(494, 328);
			this.dgvListStudent.TabIndex = 23;
			this.dgvListStudent.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStudent_CellEnter);
			// 
			// pbxSearch
			// 
			this.pbxSearch.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pbxSearch.Location = new System.Drawing.Point(6, 21);
			this.pbxSearch.Name = "pbxSearch";
			this.pbxSearch.Size = new System.Drawing.Size(28, 28);
			this.pbxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxSearch.TabIndex = 5;
			this.pbxSearch.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.cbxStudentIntake);
			this.groupBox1.Controls.Add(this.dtpDateOfBirth);
			this.groupBox1.Controls.Add(this.lblDateOfBirth);
			this.groupBox1.Controls.Add(this.btnNewUser);
			this.groupBox1.Controls.Add(this.btnRemoveUser);
			this.groupBox1.Controls.Add(this.btnUpdateUser);
			this.groupBox1.Controls.Add(this.btnInsertUser);
			this.groupBox1.Controls.Add(this.lblEmail);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.pbxUserPicture);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnRemoveUserPictureBoxImage);
			this.groupBox1.Controls.Add(this.txtLastName);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.lblUserName);
			this.groupBox1.Controls.Add(this.txtMiddleName);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblPassword);
			this.groupBox1.Controls.Add(this.txtFirstName);
			this.groupBox1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.groupBox1.Location = new System.Drawing.Point(8, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(454, 399);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Student";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(195, 239);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 16);
			this.label4.TabIndex = 32;
			this.label4.Text = "Intake";
			// 
			// cbxStudentIntake
			// 
			this.cbxStudentIntake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbxStudentIntake.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.cbxStudentIntake.FormattingEnabled = true;
			this.cbxStudentIntake.Location = new System.Drawing.Point(310, 234);
			this.cbxStudentIntake.Name = "cbxStudentIntake";
			this.cbxStudentIntake.Size = new System.Drawing.Size(131, 25);
			this.cbxStudentIntake.TabIndex = 31;
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.Location = new System.Drawing.Point(310, 275);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(131, 23);
			this.dtpDateOfBirth.TabIndex = 30;
			// 
			// pbxUserPicture
			// 
			this.pbxUserPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbxUserPicture.ErrorImage = global::WinForm.UI.Properties.Resources.image;
			this.pbxUserPicture.Location = new System.Drawing.Point(19, 38);
			this.pbxUserPicture.Name = "pbxUserPicture";
			this.pbxUserPicture.Size = new System.Drawing.Size(169, 200);
			this.pbxUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxUserPicture.TabIndex = 0;
			this.pbxUserPicture.TabStop = false;
			this.pbxUserPicture.Click += new System.EventHandler(this.pbxUserPicture_Click);
			this.pbxUserPicture.MouseEnter += new System.EventHandler(this.ControlColorOnHoverEvent);
			this.pbxUserPicture.MouseLeave += new System.EventHandler(this.pbxUserPicture_MouseLeave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(197, 199);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "LastName";
			// 
			// btnRemoveUserPictureBoxImage
			// 
			this.btnRemoveUserPictureBoxImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnRemoveUserPictureBoxImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemoveUserPictureBoxImage.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoveUserPictureBoxImage.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRemoveUserPictureBoxImage.Location = new System.Drawing.Point(19, 244);
			this.btnRemoveUserPictureBoxImage.Name = "btnRemoveUserPictureBoxImage";
			this.btnRemoveUserPictureBoxImage.Size = new System.Drawing.Size(169, 27);
			this.btnRemoveUserPictureBoxImage.TabIndex = 11;
			this.btnRemoveUserPictureBoxImage.Text = "Remove Picture";
			this.btnRemoveUserPictureBoxImage.UseVisualStyleBackColor = false;
			this.btnRemoveUserPictureBoxImage.Click += new System.EventHandler(this.btnRemoveUserPictureBoxImage_Click);
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(310, 196);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(131, 23);
			this.txtLastName.TabIndex = 20;
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(310, 52);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(131, 23);
			this.txtUserName.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(197, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "Middle Name";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblUserName.Location = new System.Drawing.Point(197, 55);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(80, 16);
			this.lblUserName.TabIndex = 13;
			this.lblUserName.Text = "Username";
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMiddleName.Location = new System.Drawing.Point(310, 160);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(131, 23);
			this.txtMiddleName.TabIndex = 18;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(310, 88);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(131, 23);
			this.txtPassword.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(197, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 16);
			this.label1.TabIndex = 17;
			this.label1.Text = "First Name";
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblPassword.Location = new System.Drawing.Point(197, 91);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(80, 16);
			this.lblPassword.TabIndex = 15;
			this.lblPassword.Text = "Password";
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(310, 124);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(131, 23);
			this.txtFirstName.TabIndex = 16;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(978, 50);
			this.pnlTop.TabIndex = 16;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(954, 19);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 3;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click_1);
			// 
			// ManageStudentPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(978, 477);
			this.Controls.Add(this.pnlMain);
			this.Controls.Add(this.pnlTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageStudentPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageStudentPage";
			this.pnlMain.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListStudent)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxSearch)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxUserPicture)).EndInit();
			this.pnlTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.PictureBox pbxSearch;
		private System.Windows.Forms.Label lblDateOfBirth;
		private System.Windows.Forms.Button btnNewUser;
		private System.Windows.Forms.Button btnRemoveUser;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Button btnInsertUser;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.PictureBox pbxUserPicture;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtSearchLecturer;
		private System.Windows.Forms.DataGridView dgvListStudent;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnRemoveUserPictureBoxImage;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbxStudentIntake;
	}
}