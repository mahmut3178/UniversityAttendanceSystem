namespace WinForm.UI.UI
{
	partial class Login
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
			this.pnlLogo = new System.Windows.Forms.Panel();
			this.pbxLogo = new System.Windows.Forms.PictureBox();
			this.pnlLogin = new System.Windows.Forms.Panel();
			this.lblException = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.chbRememberUser = new System.Windows.Forms.CheckBox();
			this.lblPasswordLine = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblUserNameLine = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUserLogin = new System.Windows.Forms.Label();
			this.btnMinimized = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
			this.pnlLogin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlLogo
			// 
			this.pnlLogo.BackColor = System.Drawing.Color.White;
			this.pnlLogo.Controls.Add(this.pbxLogo);
			this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlLogo.Location = new System.Drawing.Point(0, 0);
			this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
			this.pnlLogo.Name = "pnlLogo";
			this.pnlLogo.Size = new System.Drawing.Size(188, 280);
			this.pnlLogo.TabIndex = 2;
			this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// pbxLogo
			// 
			this.pbxLogo.Image = global::WinForm.UI.Properties.Resources.AsiaPacificUniversityOfTechnology_Innovation_svg;
			this.pbxLogo.Location = new System.Drawing.Point(11, 42);
			this.pbxLogo.Margin = new System.Windows.Forms.Padding(2);
			this.pbxLogo.Name = "pbxLogo";
			this.pbxLogo.Size = new System.Drawing.Size(165, 179);
			this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbxLogo.TabIndex = 0;
			this.pbxLogo.TabStop = false;
			// 
			// pnlLogin
			// 
			this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.pnlLogin.Controls.Add(this.lblException);
			this.pnlLogin.Controls.Add(this.btnLogin);
			this.pnlLogin.Controls.Add(this.chbRememberUser);
			this.pnlLogin.Controls.Add(this.lblPasswordLine);
			this.pnlLogin.Controls.Add(this.txtPassword);
			this.pnlLogin.Controls.Add(this.lblUserNameLine);
			this.pnlLogin.Controls.Add(this.txtUserName);
			this.pnlLogin.Controls.Add(this.pictureBox1);
			this.pnlLogin.Controls.Add(this.lblUserLogin);
			this.pnlLogin.Controls.Add(this.btnMinimized);
			this.pnlLogin.Controls.Add(this.btnClose);
			this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlLogin.Location = new System.Drawing.Point(188, 0);
			this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
			this.pnlLogin.Name = "pnlLogin";
			this.pnlLogin.Size = new System.Drawing.Size(412, 280);
			this.pnlLogin.TabIndex = 3;
			this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
			// 
			// lblException
			// 
			this.lblException.AutoSize = true;
			this.lblException.Font = new System.Drawing.Font("Century Gothic", 10.8F);
			this.lblException.ForeColor = System.Drawing.Color.Red;
			this.lblException.Location = new System.Drawing.Point(41, 234);
			this.lblException.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblException.Name = "lblException";
			this.lblException.Size = new System.Drawing.Size(0, 20);
			this.lblException.TabIndex = 10;
			// 
			// btnLogin
			// 
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(41, 199);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(338, 32);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// chbRememberUser
			// 
			this.chbRememberUser.AutoSize = true;
			this.chbRememberUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chbRememberUser.Font = new System.Drawing.Font("Century Gothic", 10.2F);
			this.chbRememberUser.ForeColor = System.Drawing.Color.White;
			this.chbRememberUser.Location = new System.Drawing.Point(41, 153);
			this.chbRememberUser.Margin = new System.Windows.Forms.Padding(2);
			this.chbRememberUser.Name = "chbRememberUser";
			this.chbRememberUser.Size = new System.Drawing.Size(135, 23);
			this.chbRememberUser.TabIndex = 3;
			this.chbRememberUser.Text = "Remember User";
			this.chbRememberUser.UseVisualStyleBackColor = true;
			// 
			// lblPasswordLine
			// 
			this.lblPasswordLine.BackColor = System.Drawing.Color.White;
			this.lblPasswordLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPasswordLine.Enabled = false;
			this.lblPasswordLine.Location = new System.Drawing.Point(41, 137);
			this.lblPasswordLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPasswordLine.Name = "lblPasswordLine";
			this.lblPasswordLine.Size = new System.Drawing.Size(338, 1);
			this.lblPasswordLine.TabIndex = 7;
			// 
			// txtPassword
			// 
			this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
			this.txtPassword.Location = new System.Drawing.Point(41, 111);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(338, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Text = "PASSWORD";
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
			// 
			// lblUserNameLine
			// 
			this.lblUserNameLine.BackColor = System.Drawing.Color.White;
			this.lblUserNameLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblUserNameLine.Enabled = false;
			this.lblUserNameLine.Location = new System.Drawing.Point(41, 100);
			this.lblUserNameLine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUserNameLine.Name = "lblUserNameLine";
			this.lblUserNameLine.Size = new System.Drawing.Size(338, 1);
			this.lblUserNameLine.TabIndex = 5;
			// 
			// txtUserName
			// 
			this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.txtUserName.ForeColor = System.Drawing.Color.DimGray;
			this.txtUserName.Location = new System.Drawing.Point(41, 74);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(338, 20);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Text = "USERNAME";
			this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
			this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinForm.UI.Properties.Resources.lock_ico;
			this.pictureBox1.Location = new System.Drawing.Point(101, 25);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(19, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// lblUserLogin
			// 
			this.lblUserLogin.AutoSize = true;
			this.lblUserLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F);
			this.lblUserLogin.ForeColor = System.Drawing.Color.White;
			this.lblUserLogin.Location = new System.Drawing.Point(125, 25);
			this.lblUserLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblUserLogin.Name = "lblUserLogin";
			this.lblUserLogin.Size = new System.Drawing.Size(120, 22);
			this.lblUserLogin.TabIndex = 2;
			this.lblUserLogin.Text = "USER LOGIN";
			// 
			// btnMinimized
			// 
			this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMinimized.Image = global::WinForm.UI.Properties.Resources.minimize_ico;
			this.btnMinimized.Location = new System.Drawing.Point(362, 10);
			this.btnMinimized.Margin = new System.Windows.Forms.Padding(2);
			this.btnMinimized.Name = "btnMinimized";
			this.btnMinimized.Size = new System.Drawing.Size(15, 16);
			this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMinimized.TabIndex = 1;
			this.btnMinimized.TabStop = false;
			this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClose.Location = new System.Drawing.Point(388, 10);
			this.btnClose.Margin = new System.Windows.Forms.Padding(2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(15, 16);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 0;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 280);
			this.Controls.Add(this.pnlLogin);
			this.Controls.Add(this.pnlLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
			this.pnlLogin.ResumeLayout(false);
			this.pnlLogin.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlLogo;
		private System.Windows.Forms.PictureBox pbxLogo;
		private System.Windows.Forms.Panel pnlLogin;
		private System.Windows.Forms.Label lblException;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox chbRememberUser;
		private System.Windows.Forms.Label lblPasswordLine;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblUserNameLine;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblUserLogin;
		private System.Windows.Forms.PictureBox btnMinimized;
		private System.Windows.Forms.PictureBox btnClose;
	}
}