namespace WinForm.UI.UI.Controls
{
	partial class MessageOk
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
			this.lblMessage = new System.Windows.Forms.Label();
			this.pnlOk = new System.Windows.Forms.Panel();
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lblText = new System.Windows.Forms.Label();
			this.pnlShadow = new System.Windows.Forms.Panel();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 10.8F);
			this.lblMessage.ForeColor = System.Drawing.Color.White;
			this.lblMessage.Location = new System.Drawing.Point(109, 84);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(375, 72);
			this.lblMessage.TabIndex = 12;
			this.lblMessage.Text = "label1";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlOk
			// 
			this.pnlOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.pnlOk.Location = new System.Drawing.Point(318, 169);
			this.pnlOk.Name = "pnlOk";
			this.pnlOk.Size = new System.Drawing.Size(5, 60);
			this.pnlOk.TabIndex = 13;
			// 
			// pnlTop
			// 
			this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
			this.pnlTop.Controls.Add(this.btnClosed);
			this.pnlTop.Controls.Add(this.lblText);
			this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(500, 50);
			this.pnlTop.TabIndex = 14;
			// 
			// lblText
			// 
			this.lblText.AutoSize = true;
			this.lblText.Font = new System.Drawing.Font("Century Gothic", 10.8F);
			this.lblText.ForeColor = System.Drawing.Color.White;
			this.lblText.Location = new System.Drawing.Point(12, 14);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(76, 20);
			this.lblText.TabIndex = 4;
			this.lblText.Text = "Message";
			// 
			// pnlShadow
			// 
			this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			this.pnlShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlShadow.Location = new System.Drawing.Point(0, 50);
			this.pnlShadow.Name = "pnlShadow";
			this.pnlShadow.Size = new System.Drawing.Size(500, 5);
			this.pnlShadow.TabIndex = 15;
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(469, 18);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 5;
			this.btnClosed.TabStop = false;
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(8, 84);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(72, 72);
			this.pictureBox.TabIndex = 11;
			this.pictureBox.TabStop = false;
			// 
			// btnOk
			// 
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
			this.btnOk.FlatAppearance.BorderSize = 0;
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(171)))), ((int)(((byte)(180)))));
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(189)))), ((int)(((byte)(196)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.btnOk.ForeColor = System.Drawing.Color.White;
			this.btnOk.Image = global::WinForm.UI.Properties.Resources.btn_ok_ico;
			this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOk.Location = new System.Drawing.Point(318, 169);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(170, 60);
			this.btnOk.TabIndex = 10;
			this.btnOk.Text = "&Okay";
			this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// MessageOk
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
			this.ClientSize = new System.Drawing.Size(500, 250);
			this.Controls.Add(this.pnlShadow);
			this.Controls.Add(this.pnlTop);
			this.Controls.Add(this.pnlOk);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnOk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MessageOk";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MessageOk";
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Panel pnlOk;
		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.Label lblText;
		private System.Windows.Forms.Panel pnlShadow;
	}
}