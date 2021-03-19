namespace WinForm.UI.UI
{
	partial class AdminMainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.btnMaximized = new System.Windows.Forms.PictureBox();
			this.btnMinimized = new System.Windows.Forms.PictureBox();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.lblCurrenFormTitle = new System.Windows.Forms.Label();
			this.pbxCurrenFormIcon = new System.Windows.Forms.PictureBox();
			this.btnRestorized = new System.Windows.Forms.PictureBox();
			this.pnlShadow = new System.Windows.Forms.Panel();
			this.pnlContainer = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pbxAPU = new System.Windows.Forms.PictureBox();
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.pnlAccounting = new System.Windows.Forms.Panel();
			this.btnStudent = new System.Windows.Forms.Button();
			this.pnlReport = new System.Windows.Forms.Panel();
			this.btnReport = new System.Windows.Forms.Button();
			this.pnlDelivery = new System.Windows.Forms.Panel();
			this.btnLecturer = new System.Windows.Forms.Button();
			this.pnlProduct = new System.Windows.Forms.Panel();
			this.btnTimeTable = new System.Windows.Forms.Button();
			this.pnOrder = new System.Windows.Forms.Panel();
			this.btnIntakeCourses = new System.Windows.Forms.Button();
			this.pbxSlider = new System.Windows.Forms.PictureBox();
			this.pnlLayout = new System.Windows.Forms.Panel();
			this.pnlLogout = new System.Windows.Forms.Panel();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.btnHome = new System.Windows.Forms.PictureBox();
			this.pnlTitle.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCurrenFormIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRestorized)).BeginInit();
			this.pnlContainer.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxAPU)).BeginInit();
			this.pnlMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).BeginInit();
			this.pnlLayout.SuspendLayout();
			this.pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTitle
			// 
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlTitle.Controls.Add(this.btnMaximized);
			this.pnlTitle.Controls.Add(this.btnMinimized);
			this.pnlTitle.Controls.Add(this.btnClosed);
			this.pnlTitle.Controls.Add(this.lblCurrenFormTitle);
			this.pnlTitle.Controls.Add(this.pbxCurrenFormIcon);
			this.pnlTitle.Controls.Add(this.btnRestorized);
			this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitle.Location = new System.Drawing.Point(250, 0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(734, 65);
			this.pnlTitle.TabIndex = 4;
			this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// btnMaximized
			// 
			this.btnMaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMaximized.Image = global::WinForm.UI.Properties.Resources.maximize_ico;
			this.btnMaximized.Location = new System.Drawing.Point(684, 26);
			this.btnMaximized.Margin = new System.Windows.Forms.Padding(2);
			this.btnMaximized.Name = "btnMaximized";
			this.btnMaximized.Size = new System.Drawing.Size(15, 16);
			this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMaximized.TabIndex = 4;
			this.btnMaximized.TabStop = false;
			this.btnMaximized.Click += new System.EventHandler(this.btnMaximized_Click);
			// 
			// btnMinimized
			// 
			this.btnMinimized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimized.Image = global::WinForm.UI.Properties.Resources.minimize_ico;
			this.btnMinimized.Location = new System.Drawing.Point(660, 26);
			this.btnMinimized.Margin = new System.Windows.Forms.Padding(2);
			this.btnMinimized.Name = "btnMinimized";
			this.btnMinimized.Size = new System.Drawing.Size(15, 16);
			this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimized.TabIndex = 3;
			this.btnMinimized.TabStop = false;
			this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(708, 26);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 2;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// lblCurrenFormTitle
			// 
			this.lblCurrenFormTitle.AutoSize = true;
			this.lblCurrenFormTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrenFormTitle.ForeColor = System.Drawing.Color.White;
			this.lblCurrenFormTitle.Location = new System.Drawing.Point(77, 20);
			this.lblCurrenFormTitle.Name = "lblCurrenFormTitle";
			this.lblCurrenFormTitle.Size = new System.Drawing.Size(165, 33);
			this.lblCurrenFormTitle.TabIndex = 1;
			this.lblCurrenFormTitle.Text = "HomePage";
			// 
			// pbxCurrenFormIcon
			// 
			this.pbxCurrenFormIcon.Image = global::WinForm.UI.Properties.Resources.btn_home_ico;
			this.pbxCurrenFormIcon.Location = new System.Drawing.Point(6, 20);
			this.pbxCurrenFormIcon.Name = "pbxCurrenFormIcon";
			this.pbxCurrenFormIcon.Size = new System.Drawing.Size(65, 35);
			this.pbxCurrenFormIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxCurrenFormIcon.TabIndex = 0;
			this.pbxCurrenFormIcon.TabStop = false;
			// 
			// btnRestorized
			// 
			this.btnRestorized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRestorized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRestorized.Image = global::WinForm.UI.Properties.Resources.maximize_ico;
			this.btnRestorized.Location = new System.Drawing.Point(684, 26);
			this.btnRestorized.Margin = new System.Windows.Forms.Padding(2);
			this.btnRestorized.Name = "btnRestorized";
			this.btnRestorized.Size = new System.Drawing.Size(15, 16);
			this.btnRestorized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnRestorized.TabIndex = 5;
			this.btnRestorized.TabStop = false;
			this.btnRestorized.Click += new System.EventHandler(this.btnRestorized_Click);
			// 
			// pnlShadow
			// 
			this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlShadow.Location = new System.Drawing.Point(0, 0);
			this.pnlShadow.Name = "pnlShadow";
			this.pnlShadow.Size = new System.Drawing.Size(734, 5);
			this.pnlShadow.TabIndex = 3;
			// 
			// pnlContainer
			// 
			this.pnlContainer.BackColor = System.Drawing.Color.Gray;
			this.pnlContainer.Controls.Add(this.panel1);
			this.pnlContainer.Controls.Add(this.pnlShadow);
			this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContainer.Location = new System.Drawing.Point(250, 65);
			this.pnlContainer.Name = "pnlContainer";
			this.pnlContainer.Size = new System.Drawing.Size(734, 496);
			this.pnlContainer.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(734, 491);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.pbxAPU);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(734, 491);
			this.panel2.TabIndex = 5;
			// 
			// pbxAPU
			// 
			this.pbxAPU.Image = global::WinForm.UI.Properties.Resources.AsiaPacificUniversityOfTechnology_Innovation_svg;
			this.pbxAPU.Location = new System.Drawing.Point(150, 80);
			this.pbxAPU.Name = "pbxAPU";
			this.pbxAPU.Size = new System.Drawing.Size(421, 315);
			this.pbxAPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxAPU.TabIndex = 4;
			this.pbxAPU.TabStop = false;
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.pnlMenu.Controls.Add(this.pnlAccounting);
			this.pnlMenu.Controls.Add(this.btnStudent);
			this.pnlMenu.Controls.Add(this.pnlReport);
			this.pnlMenu.Controls.Add(this.btnReport);
			this.pnlMenu.Controls.Add(this.pnlDelivery);
			this.pnlMenu.Controls.Add(this.btnLecturer);
			this.pnlMenu.Controls.Add(this.pnlProduct);
			this.pnlMenu.Controls.Add(this.btnTimeTable);
			this.pnlMenu.Controls.Add(this.pnOrder);
			this.pnlMenu.Controls.Add(this.btnIntakeCourses);
			this.pnlMenu.Controls.Add(this.pbxSlider);
			this.pnlMenu.Controls.Add(this.pnlLayout);
			this.pnlMenu.Controls.Add(this.pnlLogo);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(250, 561);
			this.pnlMenu.TabIndex = 3;
			this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// pnlAccounting
			// 
			this.pnlAccounting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlAccounting.Location = new System.Drawing.Point(0, 300);
			this.pnlAccounting.Name = "pnlAccounting";
			this.pnlAccounting.Size = new System.Drawing.Size(5, 60);
			this.pnlAccounting.TabIndex = 16;
			// 
			// btnStudent
			// 
			this.btnStudent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStudent.FlatAppearance.BorderSize = 0;
			this.btnStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStudent.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnStudent.ForeColor = System.Drawing.Color.White;
			this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
			this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStudent.Location = new System.Drawing.Point(0, 300);
			this.btnStudent.Name = "btnStudent";
			this.btnStudent.Size = new System.Drawing.Size(250, 60);
			this.btnStudent.TabIndex = 15;
			this.btnStudent.Text = "Manage Students";
			this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnStudent.UseVisualStyleBackColor = true;
			this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
			// 
			// pnlReport
			// 
			this.pnlReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlReport.Location = new System.Drawing.Point(0, 366);
			this.pnlReport.Name = "pnlReport";
			this.pnlReport.Size = new System.Drawing.Size(5, 60);
			this.pnlReport.TabIndex = 14;
			// 
			// btnReport
			// 
			this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReport.FlatAppearance.BorderSize = 0;
			this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReport.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnReport.ForeColor = System.Drawing.Color.White;
			this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReport.Location = new System.Drawing.Point(0, 366);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(250, 60);
			this.btnReport.TabIndex = 13;
			this.btnReport.Text = "Under Development";
			this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnReport.UseVisualStyleBackColor = true;
			// 
			// pnlDelivery
			// 
			this.pnlDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlDelivery.Location = new System.Drawing.Point(0, 234);
			this.pnlDelivery.Name = "pnlDelivery";
			this.pnlDelivery.Size = new System.Drawing.Size(5, 60);
			this.pnlDelivery.TabIndex = 8;
			// 
			// btnLecturer
			// 
			this.btnLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLecturer.FlatAppearance.BorderSize = 0;
			this.btnLecturer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnLecturer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLecturer.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnLecturer.ForeColor = System.Drawing.Color.White;
			this.btnLecturer.Image = global::WinForm.UI.Properties.Resources.Lecturer;
			this.btnLecturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLecturer.Location = new System.Drawing.Point(0, 234);
			this.btnLecturer.Name = "btnLecturer";
			this.btnLecturer.Size = new System.Drawing.Size(250, 60);
			this.btnLecturer.TabIndex = 7;
			this.btnLecturer.Text = "Manage Lecturers";
			this.btnLecturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLecturer.UseVisualStyleBackColor = true;
			this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
			// 
			// pnlProduct
			// 
			this.pnlProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlProduct.Location = new System.Drawing.Point(0, 168);
			this.pnlProduct.Name = "pnlProduct";
			this.pnlProduct.Size = new System.Drawing.Size(5, 60);
			this.pnlProduct.TabIndex = 6;
			// 
			// btnTimeTable
			// 
			this.btnTimeTable.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTimeTable.FlatAppearance.BorderSize = 0;
			this.btnTimeTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnTimeTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimeTable.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnTimeTable.ForeColor = System.Drawing.Color.White;
			this.btnTimeTable.Image = global::WinForm.UI.Properties.Resources.TimeTable;
			this.btnTimeTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTimeTable.Location = new System.Drawing.Point(0, 168);
			this.btnTimeTable.Name = "btnTimeTable";
			this.btnTimeTable.Size = new System.Drawing.Size(250, 60);
			this.btnTimeTable.TabIndex = 5;
			this.btnTimeTable.Text = "Manage TimeTables";
			this.btnTimeTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnTimeTable.UseVisualStyleBackColor = true;
			this.btnTimeTable.Click += new System.EventHandler(this.btnTimeTable_Click);
			// 
			// pnOrder
			// 
			this.pnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnOrder.Location = new System.Drawing.Point(0, 102);
			this.pnOrder.Name = "pnOrder";
			this.pnOrder.Size = new System.Drawing.Size(5, 60);
			this.pnOrder.TabIndex = 4;
			// 
			// btnIntakeCourses
			// 
			this.btnIntakeCourses.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIntakeCourses.FlatAppearance.BorderSize = 0;
			this.btnIntakeCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnIntakeCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnIntakeCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIntakeCourses.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIntakeCourses.ForeColor = System.Drawing.Color.White;
			this.btnIntakeCourses.Image = global::WinForm.UI.Properties.Resources.bookybook;
			this.btnIntakeCourses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnIntakeCourses.Location = new System.Drawing.Point(0, 105);
			this.btnIntakeCourses.Name = "btnIntakeCourses";
			this.btnIntakeCourses.Size = new System.Drawing.Size(250, 60);
			this.btnIntakeCourses.TabIndex = 1;
			this.btnIntakeCourses.Text = "Manage Intake && Courses";
			this.btnIntakeCourses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIntakeCourses.UseVisualStyleBackColor = true;
			this.btnIntakeCourses.Click += new System.EventHandler(this.btnIntakeCourses_Click);
			// 
			// pbxSlider
			// 
			this.pbxSlider.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbxSlider.Image = ((System.Drawing.Image)(resources.GetObject("pbxSlider.Image")));
			this.pbxSlider.Location = new System.Drawing.Point(0, 61);
			this.pbxSlider.Name = "pbxSlider";
			this.pbxSlider.Size = new System.Drawing.Size(250, 35);
			this.pbxSlider.TabIndex = 3;
			this.pbxSlider.TabStop = false;
			this.pbxSlider.Click += new System.EventHandler(this.PbxSlider_Click);
			// 
			// pnlLayout
			// 
			this.pnlLayout.Controls.Add(this.pnlLogout);
			this.pnlLayout.Controls.Add(this.btnLogout);
			this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlLayout.Location = new System.Drawing.Point(0, 491);
			this.pnlLayout.Name = "pnlLayout";
			this.pnlLayout.Size = new System.Drawing.Size(250, 70);
			this.pnlLayout.TabIndex = 2;
			// 
			// pnlLogout
			// 
			this.pnlLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.pnlLogout.Location = new System.Drawing.Point(0, 2);
			this.pnlLogout.Name = "pnlLogout";
			this.pnlLogout.Size = new System.Drawing.Size(5, 60);
			this.pnlLogout.TabIndex = 16;
			// 
			// btnLogout
			// 
			this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
			this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Image = global::WinForm.UI.Properties.Resources.btn_logout_ico;
			this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLogout.Location = new System.Drawing.Point(3, 2);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(250, 60);
			this.btnLogout.TabIndex = 15;
			this.btnLogout.Text = "Logout";
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pnlLogo
			// 
			this.pnlLogo.Controls.Add(this.btnHome);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(250, 65);
			this.pnlLogo.TabIndex = 1;
			// 
			// btnHome
			// 
			this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHome.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnHome.ErrorImage")));
			this.btnHome.Image = global::WinForm.UI.Properties.Resources.AsiaPacificUniversityOfTechnology_Innovation_svg;
			this.btnHome.Location = new System.Drawing.Point(5, 10);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(239, 47);
			this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnHome.TabIndex = 0;
			this.btnHome.TabStop = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// AdminMainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.pnlContainer);
			this.Controls.Add(this.pnlTitle);
			this.Controls.Add(this.pnlMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminMainPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminMainPage";
			this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
			this.pnlTitle.ResumeLayout(false);
			this.pnlTitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxCurrenFormIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnRestorized)).EndInit();
			this.pnlContainer.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbxAPU)).EndInit();
			this.pnlMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbxSlider)).EndInit();
			this.pnlLayout.ResumeLayout(false);
			this.pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox btnRestorized;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.PictureBox btnMaximized;
		private System.Windows.Forms.PictureBox btnMinimized;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Label lblCurrenFormTitle;
		private System.Windows.Forms.PictureBox pbxCurrenFormIcon;
		private System.Windows.Forms.Panel pnlShadow;
		private System.Windows.Forms.PictureBox btnHome;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Panel pnlAccounting;
		private System.Windows.Forms.Button btnStudent;
		private System.Windows.Forms.Panel pnlReport;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Panel pnlDelivery;
		private System.Windows.Forms.Button btnLecturer;
		private System.Windows.Forms.Panel pnlProduct;
		private System.Windows.Forms.Button btnTimeTable;
		private System.Windows.Forms.Panel pnOrder;
		private System.Windows.Forms.Button btnIntakeCourses;
		private System.Windows.Forms.PictureBox pbxSlider;
		private System.Windows.Forms.Panel pnlLayout;
		private System.Windows.Forms.Panel pnlLogout;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pbxAPU;
		private System.Windows.Forms.Panel panel2;
	}
}