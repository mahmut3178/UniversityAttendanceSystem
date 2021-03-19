using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.UI.UI
{
	public partial class LecturerMainPage : Form
	{
		private Form currentChildForm;
		private Button currentButton;
		public LecturerMainPage()
		{
			InitializeComponent();
			PopulateUserInformationBox();
			pbxAPU.Anchor = AnchorStyles.None;
		}
		Lecturer lecturer;
		ILecturerService _lecturerService = InstanceFactory.GetInstance<ILecturerService>();
		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			FunctionBase.ReleaseCapture();
			FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void pbxSlider_Click(object sender, EventArgs e)
		{
			if (pnlMenu.Width == 250)
				pnlMenu.Width = 88;

			else
				pnlMenu.Width = 250;
		}

		private void PopulateUserInformationBox()
		{
			lecturer = _lecturerService.GetLecturerByID(Program.lecturer);
			if(lecturer.Photo==null)
			{
				pbxUserPicture.Image = pbxUserPicture.ErrorImage;

			}
			else
			{
			pbxUserPicture.Image = byteArrayToImage((byte[])lecturer.Photo);
			}
			lblUserFullName.Text = lecturer.FirstName + " " + (lecturer.MiddleName.Equals("") ? "" : lecturer.MiddleName + " ")  + lecturer.LastName;
		}
		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			Image returnImage = Image.FromStream(ms);
			return returnImage;
		}
		private void OpenChildForm(Form childForm, string buttonText)
		{
			if (currentChildForm != null)
				currentChildForm.Close();

			currentChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			pnlContainer.Controls.Add(childForm);
			pnlContainer.Tag = childForm;

			childForm.BringToFront();
			childForm.Show();
			childForm.FormClosed += ChildFormClosed;
			lblCurrenFormTitle.Text = buttonText;
		}

		private void ChildFormClosed(object sender, FormClosedEventArgs e)
		{
			DisableButton();
		}

		private void Reset()
		{
			DisableButton();
			if (currentChildForm != null)
			{
				currentChildForm.Close();
			}
			lblCurrenFormTitle.Text = "HomePage";
			pbxCurrenFormIcon.Image = btnHome.ErrorImage;
		}
		private void ActivateButton(object senderBtn)
		{
			DisableButton();
			if (senderBtn != null)
			{
				currentButton = (Button)senderBtn;
				currentButton.BackColor = Color.FromArgb(248, 68, 79);
				pbxCurrenFormIcon.Image = currentButton.Image;
			}
		}

		private void DisableButton()
		{
			if (currentButton != null)
			{
				currentButton.BackColor = Color.Transparent;
			}
		}

		private void Main_SizeChanged(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Normal)
			{
				btnMaximized.Visible = true;
				btnRestorized.Visible = false;
				if (currentChildForm != null)
					currentChildForm.Size = pnlContainer.Size;
			}
			else if (this.WindowState == FormWindowState.Maximized)
			{
				btnMaximized.Visible = false;
				btnRestorized.Visible = true;
				if (currentChildForm != null)
					currentChildForm.Size = pnlContainer.Size;
			}
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMaximized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
		private void btnRestorized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void btnHome_Click(object sender, EventArgs e)
		{
			Reset();
		}

		private void btnMyTimeTable_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			ActivateButton(sender);
			OpenChildForm(new LecturerStudentAttendancePage(), button.Text);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
