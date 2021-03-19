using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Karebase.WinFormsUI.Controls;
using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class StudentUserProfilePage : Form
	{
		public StudentUserProfilePage()
		{
			InitializeComponent();
			LoadUserInformation();
		}
		byte[] arr;
		IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
		IUserService _userService = InstanceFactory.GetInstance<IUserService>();
		IStudentIntakeService _studentIntakeService = InstanceFactory.GetInstance<IStudentIntakeService>();
		User user;
		Student student;
	

		private void LoadUserInformation()
		{
			student = _studentService.GetStudentByID(Program.student);
			user = _userService.GetUserByID(Program.student.StudentID);
			txtUserName.Text = user.UserName;
			txtPassword.Text = user.Password;
			txtFirstName.Text = student.StudentFirstName;
			txtMiddleName.Text = student.StudentMiddleName;
			txtLastName.Text = student.StudentLastName;
			txtIntake.Text = _studentIntakeService.GetIntakeByStudentID(Program.student).ToString();
			dtpDateOfBirth.Value = student.StudentBirthDate;
			txtEmail.Text = student.StudentEmail; 
			if (student.Photo != null)
				pbxUserPicture.Image = byteArrayToImage((byte[])student.Photo);
			else pbxUserPicture.Image = pbxUserPicture.ErrorImage;

		}

		public void imageToByteArray()
		{
			if (pbxUserPicture.Image == pbxUserPicture.ErrorImage)
			{
				return;
			}
			MemoryStream ms = new MemoryStream();
			pbxUserPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
			arr = ms.ToArray();
		}

		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
			Image returnImage = Image.FromStream(ms);
			return returnImage;
		}


		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			ChangeUserPassword changeUserPassword = new ChangeUserPassword();
			changeUserPassword.user = user;
			changeUserPassword.ShowDialog();
			LoadUserInformation();
		}

		private void btnRemoveUserPictureBoxImage_Click(object sender, EventArgs e)
		{
			RemoveUserPicture();
		}
		private void SetPictureBoxImage()
		{
			if (pbxUserPicture.Image == null)
			{
				RemoveUserPicture();
			}
		}
		private void RemoveUserPicture()
		{
			pbxUserPicture.Image = pbxUserPicture.ErrorImage;
		}

		private void pbxUserPicture_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					pbxUserPicture.Image = Image.FromFile(ofd.FileName);
				}
			}
			ImageBoxRemoveButtonController();
		}
		private void ImageBoxRemoveButtonController()
		{
			if (pbxUserPicture.Image == pbxUserPicture.ErrorImage)
				btnRemoveUserPictureBoxImage.Enabled = false;
			else
				btnRemoveUserPictureBoxImage.Enabled = true;
		}

		private void pbxUserPicture_MouseEnter(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.FromArgb(12, 56, 73);
		}

		private void pbxUserPicture_MouseLeave(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.FromArgb(1, 44, 61);
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(UpdateUser);
		}

		private void UpdateUser()
		{
				imageToByteArray();
				_studentService.Update(new Student
				{
					StudentID = student.StudentID,
					StudentFirstName = txtFirstName.Text,
					StudentMiddleName = txtMiddleName.Text,
					StudentLastName = txtLastName.Text,
					StudentBirthDate = Convert.ToDateTime(dtpDateOfBirth.Value.ToString("yyyy-MM-dd")),
					StudentEmail = txtEmail.Text,
					Photo = arr == null ? null : arr
				});
				MMessageBox.ShowMessage("Successfully updated record.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);		
		}
	}
}
