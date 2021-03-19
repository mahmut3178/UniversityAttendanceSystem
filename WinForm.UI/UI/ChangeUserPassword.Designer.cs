namespace WinForm.UI.UI
{
	partial class ChangeUserPassword
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
			this.txtOldPassword = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReNewPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			this.lblPasswordStrength = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOldPassword
			// 
			this.txtOldPassword.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOldPassword.Location = new System.Drawing.Point(184, 59);
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.PasswordChar = '*';
			this.txtOldPassword.Size = new System.Drawing.Size(131, 23);
			this.txtOldPassword.TabIndex = 0;
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblUserName.Location = new System.Drawing.Point(8, 62);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(170, 16);
			this.lblUserName.TabIndex = 15;
			this.lblUserName.Text = "Current Password :";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(80, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 21);
			this.label1.TabIndex = 16;
			this.label1.Text = "Password Change";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClosed);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(349, 43);
			this.panel1.TabIndex = 17;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(330, 3);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 22;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNewPassword.Location = new System.Drawing.Point(184, 100);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(131, 23);
			this.txtNewPassword.TabIndex = 1;
			this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
			this.txtNewPassword.Leave += new System.EventHandler(this.txtNewPassword_Leave);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(8, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "New Password :";
			// 
			// txtReNewPassword
			// 
			this.txtReNewPassword.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtReNewPassword.Location = new System.Drawing.Point(184, 141);
			this.txtReNewPassword.Name = "txtReNewPassword";
			this.txtReNewPassword.PasswordChar = '*';
			this.txtReNewPassword.Size = new System.Drawing.Size(131, 23);
			this.txtReNewPassword.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(8, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(161, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Re New Password :";
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateUser.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdateUser.Location = new System.Drawing.Point(0, 194);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(345, 27);
			this.btnUpdateUser.TabIndex = 3;
			this.btnUpdateUser.Text = "Set New Password";
			this.btnUpdateUser.UseVisualStyleBackColor = false;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// lblPasswordStrength
			// 
			this.lblPasswordStrength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPasswordStrength.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPasswordStrength.Image = global::WinForm.UI.Properties.Resources.greenBubble;
			this.lblPasswordStrength.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPasswordStrength.Location = new System.Drawing.Point(186, 169);
			this.lblPasswordStrength.Name = "lblPasswordStrength";
			this.lblPasswordStrength.Size = new System.Drawing.Size(159, 13);
			this.lblPasswordStrength.TabIndex = 27;
			this.lblPasswordStrength.Text = "Strong";
			this.lblPasswordStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblPasswordStrength.Visible = false;
			// 
			// ChangeUserPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(349, 233);
			this.Controls.Add(this.lblPasswordStrength);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.txtReNewPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txtOldPassword);
			this.Controls.Add(this.lblUserName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChangeUserPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChangeUserPassword";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtOldPassword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtReNewPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Button btnUpdateUser;
		private System.Windows.Forms.Label lblPasswordStrength;
	}
}