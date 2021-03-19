namespace WinForm.UI.UI
{
	partial class CRUDSubjectPage
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
			this.gbxSubject = new System.Windows.Forms.GroupBox();
			this.txtSubject = new System.Windows.Forms.TextBox();
			this.btnUpdateSubject = new System.Windows.Forms.Button();
			this.btnDeleteSubject = new System.Windows.Forms.Button();
			this.txtSearchSubject = new System.Windows.Forms.TextBox();
			this.btnInsertSubject = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dgvSubjects = new System.Windows.Forms.DataGridView();
			this.btnClosed = new System.Windows.Forms.PictureBox();
			this.gbxSubject.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxSubject
			// 
			this.gbxSubject.Controls.Add(this.txtSubject);
			this.gbxSubject.Controls.Add(this.btnUpdateSubject);
			this.gbxSubject.Controls.Add(this.btnDeleteSubject);
			this.gbxSubject.Controls.Add(this.txtSearchSubject);
			this.gbxSubject.Controls.Add(this.btnInsertSubject);
			this.gbxSubject.Controls.Add(this.pictureBox1);
			this.gbxSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gbxSubject.Location = new System.Drawing.Point(19, 203);
			this.gbxSubject.Name = "gbxSubject";
			this.gbxSubject.Size = new System.Drawing.Size(424, 212);
			this.gbxSubject.TabIndex = 1;
			this.gbxSubject.TabStop = false;
			this.gbxSubject.Text = "Subject";
			// 
			// txtSubject
			// 
			this.txtSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSubject.Location = new System.Drawing.Point(40, 67);
			this.txtSubject.Name = "txtSubject";
			this.txtSubject.Size = new System.Drawing.Size(350, 23);
			this.txtSubject.TabIndex = 16;
			// 
			// btnUpdateSubject
			// 
			this.btnUpdateSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnUpdateSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdateSubject.Location = new System.Drawing.Point(236, 117);
			this.btnUpdateSubject.Name = "btnUpdateSubject";
			this.btnUpdateSubject.Size = new System.Drawing.Size(154, 30);
			this.btnUpdateSubject.TabIndex = 15;
			this.btnUpdateSubject.Text = "Update Subject";
			this.btnUpdateSubject.UseVisualStyleBackColor = false;
			this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
			// 
			// btnDeleteSubject
			// 
			this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDeleteSubject.Location = new System.Drawing.Point(133, 162);
			this.btnDeleteSubject.Name = "btnDeleteSubject";
			this.btnDeleteSubject.Size = new System.Drawing.Size(154, 30);
			this.btnDeleteSubject.TabIndex = 14;
			this.btnDeleteSubject.Text = "Remove Subject";
			this.btnDeleteSubject.UseVisualStyleBackColor = false;
			this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
			// 
			// txtSearchSubject
			// 
			this.txtSearchSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.txtSearchSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSearchSubject.Location = new System.Drawing.Point(40, 22);
			this.txtSearchSubject.Name = "txtSearchSubject";
			this.txtSearchSubject.Size = new System.Drawing.Size(107, 23);
			this.txtSearchSubject.TabIndex = 13;
			this.txtSearchSubject.TextChanged += new System.EventHandler(this.txtSearchSubject_TextChanged);
			// 
			// btnInsertSubject
			// 
			this.btnInsertSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.btnInsertSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsertSubject.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInsertSubject.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnInsertSubject.Location = new System.Drawing.Point(40, 117);
			this.btnInsertSubject.Name = "btnInsertSubject";
			this.btnInsertSubject.Size = new System.Drawing.Size(154, 30);
			this.btnInsertSubject.TabIndex = 12;
			this.btnInsertSubject.Text = "Insert Subject";
			this.btnInsertSubject.UseVisualStyleBackColor = false;
			this.btnInsertSubject.Click += new System.EventHandler(this.btnInsertSubject_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WinForm.UI.Properties.Resources.search_ico;
			this.pictureBox1.Location = new System.Drawing.Point(6, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(28, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// dgvSubjects
			// 
			this.dgvSubjects.AllowUserToAddRows = false;
			this.dgvSubjects.AllowUserToDeleteRows = false;
			this.dgvSubjects.AllowUserToOrderColumns = true;
			this.dgvSubjects.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.dgvSubjects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSubjects.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSubjects.ColumnHeadersHeight = 30;
			this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(68)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSubjects.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSubjects.EnableHeadersVisualStyles = false;
			this.dgvSubjects.Location = new System.Drawing.Point(22, 32);
			this.dgvSubjects.MultiSelect = false;
			this.dgvSubjects.Name = "dgvSubjects";
			this.dgvSubjects.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSubjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSubjects.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			this.dgvSubjects.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSubjects.RowTemplate.Height = 35;
			this.dgvSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSubjects.Size = new System.Drawing.Size(421, 159);
			this.dgvSubjects.TabIndex = 14;
			this.dgvSubjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellClick);
			// 
			// btnClosed
			// 
			this.btnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosed.Image = global::WinForm.UI.Properties.Resources.close_ico;
			this.btnClosed.Location = new System.Drawing.Point(444, 6);
			this.btnClosed.Margin = new System.Windows.Forms.Padding(2);
			this.btnClosed.Name = "btnClosed";
			this.btnClosed.Size = new System.Drawing.Size(15, 16);
			this.btnClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClosed.TabIndex = 15;
			this.btnClosed.TabStop = false;
			this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
			// 
			// CRUDSubjectPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(44)))), ((int)(((byte)(61)))));
			this.ClientSize = new System.Drawing.Size(465, 427);
			this.Controls.Add(this.btnClosed);
			this.Controls.Add(this.dgvSubjects);
			this.Controls.Add(this.gbxSubject);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CRUDSubjectPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CRUDSubjectPage";
			this.gbxSubject.ResumeLayout(false);
			this.gbxSubject.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClosed)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox gbxSubject;
		private System.Windows.Forms.Button btnInsertSubject;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtSearchSubject;
		private System.Windows.Forms.DataGridView dgvSubjects;
		private System.Windows.Forms.PictureBox btnClosed;
		private System.Windows.Forms.TextBox txtSubject;
		private System.Windows.Forms.Button btnUpdateSubject;
		private System.Windows.Forms.Button btnDeleteSubject;
	}
}