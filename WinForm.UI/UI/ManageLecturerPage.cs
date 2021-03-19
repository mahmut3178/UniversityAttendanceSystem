using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes.ParameterItems;
using FluentValidation;
using Karebase.WinFormsUI.Controls;
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
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class ManageLecturerPage : Form
	{
		public ManageLecturerPage()
		{
			InitializeComponent();
			SetGridProperties();
			SetPictureBoxImage();
			ImageBoxRemoveButtonController();
			PopulateListLecturer();
			formIsLoaded = true;
		}
		bool formIsLoaded = false;
		IUserService _userService = InstanceFactory.GetInstance<IUserService>();
		ILecturerService _lecturerService = InstanceFactory.GetInstance<ILecturerService>();

		User user = new User();
		Lecturer lecturer = new Lecturer();
		byte[] arr;
		private void PopulateListLecturer()
		{
			dgvListLecturer.DataSource = _userService.GetLecturerByIDAndName(txtSearchLecturer.Text);
			dgvListLecturer.Columns["UserID"].Visible = false;
			dgvListLecturer.Columns["Photo"].Visible = false;
			dgvListLecturer.Columns["LecturerID"].Visible = false;
			dgvListLecturer.Columns["Password"].Visible = false;
			ImageBoxRemoveButtonController();
		}
		private void SetGridProperties()
		{
			dgvListLecturer.DefaultCellStyle.ForeColor = Color.Black;
			dgvListLecturer.DefaultCellStyle.ForeColor = Color.Black;
		}
		private void SetPictureBoxImage()
		{
			if (pbxUserPicture.Image == null)
			{
				RemoveUserPicture();
			}
		}
		private void ImageBoxRemoveButtonController()
		{
			if (pbxUserPicture.Image == pbxUserPicture.ErrorImage)
				btnRemoveUserPictureBoxImage.Enabled = false;
			else
				btnRemoveUserPictureBoxImage.Enabled = true;
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
		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void pbxUserPicture_LoadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			if (pbxUserPicture.Image == null)
			{
				RemoveUserPicture();
			}
		}

		private void btnInsertUser_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertUser);
		}
		private void InsertUser()
		{
			imageToByteArray();

			_userService.ValidateUser(new User
			{
				UserName = txtUserName.Text,
				Password = txtPassword.Text,
				UserTypeID = 2
			});
			_lecturerService.InsertLecturer(new LecturerQueryItem
			{
				UserName = txtUserName.Text,
				Password = txtPassword.Text,
				UserTypeID = 2,
				LecturerID = txtUserName.Text,
				FirstName = txtFirstName.Text,
				MiddleName = txtMiddleName.Text,
				LastName = txtLastName.Text,
				Address = txtAddress.Text,
				Phone = txtPhone.Text,
				Photo = arr == null ? null : arr
			});
			MMessageBox.ShowMessage("Successfully enrolled a new staff", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateListLecturer();
		}
		
		private void btnUpdateUser_Click(object sender, EventArgs e)
		{			
			DelegateAction.RunMethod(UpdateUser);
		}

		private void UpdateUser()
		{
			imageToByteArray();
			_lecturerService.Update(new Lecturer
			{
				LecturerID = lecturer.LecturerID,
				FirstName = txtFirstName.Text,
				MiddleName = txtMiddleName.Text,
				LastName = txtLastName.Text,
				Address = txtAddress.Text,
				Phone = txtPhone.Text,
				Photo = arr == null ? null : arr
			});
			MMessageBox.ShowMessage("Successfully updated record", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateListLecturer();
		}

		private void btnRemoveUser_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(RemoveUser);
		}

		private void RemoveUser()
		{
			_userService.Delete(user);
			_lecturerService.Delete(lecturer);
			PopulateListLecturer();
			MMessageBox.ShowMessage("Deleted Staff From system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void imageToByteArray()
		{
			if (pbxUserPicture.Image == pbxUserPicture.ErrorImage)
			{
				return;
			}
			arr = null;
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


		private void dgvListLecturers_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (formIsLoaded)
			{
				btnUpdateUser.Enabled = true;

				if ((byte[])dgvListLecturer.CurrentRow.Cells["Photo"].Value != null)
				{
					ImageConverter converter = new ImageConverter();
					pbxUserPicture.Image = byteArrayToImage((byte[])dgvListLecturer.CurrentRow.Cells["Photo"].Value);
				}
				else
				{
					pbxUserPicture.Image = pbxUserPicture.ErrorImage;
				}
			}
			txtUserName.Enabled = false;
			txtPassword.Enabled = false;

			user.UserID = (int)dgvListLecturer.CurrentRow.Cells["UserID"].Value;
			user.UserName = dgvListLecturer.CurrentRow.Cells["UserName"].Value.ToString();
			user.Password = dgvListLecturer.CurrentRow.Cells["Password"].Value.ToString();
			lecturer.LecturerID = dgvListLecturer.CurrentRow.Cells["LecturerID"].Value.ToString();
			lecturer.FirstName = dgvListLecturer.CurrentRow.Cells["FirstName"].Value.ToString();
			lecturer.MiddleName = dgvListLecturer.CurrentRow.Cells["MiddleName"].Value.ToString();
			lecturer.LastName = dgvListLecturer.CurrentRow.Cells["LastName"].Value.ToString();
			lecturer.Phone = dgvListLecturer.CurrentRow.Cells["Phone"].Value.ToString();
			lecturer.Address = dgvListLecturer.CurrentRow.Cells["Address"].Value.ToString();
			ImageBoxRemoveButtonController();

			txtUserName.Text = user.UserName;
			txtPassword.Text = user.Password;
			txtFirstName.Text = lecturer.FirstName;
			txtMiddleName.Text = lecturer.MiddleName;
			txtLastName.Text = lecturer.LastName;
			txtPhone.Text = lecturer.Phone;
			txtAddress.Text = lecturer.Address;
		}

		private void ControlColorOnHoverEvent(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.FromArgb(12, 56, 73);
		}
		private void pbxUserPicture_MouseLeave(object sender, EventArgs e)
		{
			((Control)sender).BackColor = Color.FromArgb(1, 44, 61);
		}

		public void ClearControls()
		{
			txtUserName.Enabled = true;
			txtPassword.Enabled = true;
			txtUserName.Text = txtPassword.Text = txtFirstName.Text = txtMiddleName.Text = txtLastName.Text = txtAddress.Text = txtPhone.Text = "";
		}

		private void txtSearchLecturer_TextChanged(object sender, EventArgs e)
		{
			PopulateListLecturer();
		}

		private void btnNewUser_Click(object sender, EventArgs e)
		{
			btnUpdateUser.Enabled = false;
			ClearControls();
			RemoveUserPicture();
		}

		private void btnRemoveUserPictureBoxImage_Click(object sender, EventArgs e)
		{
			RemoveUserPicture();
			ImageBoxRemoveButtonController();
		}

		private void RemoveUserPicture()
		{
			pbxUserPicture.Image = pbxUserPicture.ErrorImage;
		}

	}
}
