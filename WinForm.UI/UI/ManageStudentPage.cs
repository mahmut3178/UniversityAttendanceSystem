using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using Karebase.WinFormsUI.Controls;
using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class ManageStudentPage : Form
	{
		public ManageStudentPage()
		{
			InitializeComponent();
			SetDtpProperties();
			SetGridProperties();
			SetPictureBoxImage();
			ImageBoxRemoveButtonController();
			PopulateListLecturer();
			PopulateComboBoxIntake();
			formIsLoaded = true;
		}
		bool formIsLoaded = false;
		IUserService _userService = InstanceFactory.GetInstance<IUserService>();
		IStudentService _studentService = InstanceFactory.GetInstance<IStudentService>();
		IStudentIntakeService _studentIntakeService = InstanceFactory.GetInstance<IStudentIntakeService>();
		IIntakeService _intakeService = InstanceFactory.GetInstance<IIntakeService>();

		User user = new User();
		Student student = new Student();
		StudentIntake studentIntake = new StudentIntake();
		byte[] arr;

		private void PopulateListLecturer()
		{
			dgvListStudent.DataSource = _userService.GetStudentByIDAndName(txtSearchLecturer.Text);
			dgvListStudent.Columns["StudentIntakeID"].Visible = false;
			dgvListStudent.Columns["UserID"].Visible = false;
			dgvListStudent.Columns["Photo"].Visible = false;
			dgvListStudent.Columns["UserName"].Visible = false;
			dgvListStudent.Columns["Password"].Visible = false;
			ImageBoxRemoveButtonController();
		}

		private void SetDtpProperties()
		{
			dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
			dtpDateOfBirth.CustomFormat = "yyyy:MM:dd";
			dtpDateOfBirth.ShowUpDown = false;
		}

		private void PopulateComboBoxIntake()
		{
			List<Intake> intake = _intakeService.GetAllIntake();
			intake.Insert(0, new Intake { IntakeID = "Select Intake" });
			cbxStudentIntake.DataSource = intake;
			cbxStudentIntake.ValueMember = "IntakeID";
			cbxStudentIntake.DisplayMember = "IntakeID";
			cbxStudentIntake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbxStudentIntake.AutoCompleteSource = AutoCompleteSource.ListItems;
		}

		private void SetGridProperties()
		{
			dgvListStudent.DefaultCellStyle.ForeColor = Color.Black;
			dgvListStudent.DefaultCellStyle.ForeColor = Color.Black;
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
			_userService.ValidateUser(new User {
				UserName = txtUserName.Text,
				Password = txtPassword.Text,
				UserTypeID = 3
			});
			_studentService.InsertStudent(new StudentQueryItem
			{
				StudentID = txtUserName.Text,
				StudentFirstName = txtFirstName.Text,
				StudentMiddleName = txtMiddleName.Text,
				StudentLastName = txtLastName.Text,
				StudentBirthDate = dtpDateOfBirth.Value.Date,
				StudentEmail = txtEmail.Text,
				Photo = arr == null ? null : arr,
				IntakeID = cbxStudentIntake.SelectedValue.ToString(),
				IsStudentIntakeActive = true,
				UserName = txtUserName.Text,
				Password = txtPassword.Text,
				UserTypeID = 3
			});
			MMessageBox.ShowMessage("Successfully enrolled a new student.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateListLecturer();
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
				StudentBirthDate = dtpDateOfBirth.Value.Date,
				StudentEmail = txtEmail.Text,
				Photo = arr == null ? null : arr
			});

			_studentIntakeService.Update(new StudentIntake { StudentIntakeID = studentIntake.StudentIntakeID, StudentID = txtUserName.Text, IntakeID = cbxStudentIntake.SelectedValue.ToString(), IsStudentIntakeActive = true });
			MMessageBox.ShowMessage("Successfully updated record.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			PopulateListLecturer();
			
		}

		private void btnRemoveUser_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteUser);
		}

		private void DeleteUser()
		{
			_userService.Delete(user);
			_studentService.Delete(student);
			_studentIntakeService.Delete(studentIntake);
			PopulateListLecturer();
			MMessageBox.ShowMessage("Removed Student From system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dgvListStudent_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (formIsLoaded)
			{
				btnUpdateUser.Enabled = true;

				if ((byte[])dgvListStudent.CurrentRow.Cells["Photo"].Value != null)
				{
					ImageConverter converter = new ImageConverter();
					pbxUserPicture.Image = byteArrayToImage((byte[])dgvListStudent.CurrentRow.Cells["Photo"].Value);
				}
				else
				{
					pbxUserPicture.Image = pbxUserPicture.ErrorImage;
				}
			}
			txtUserName.Enabled = false;
			txtPassword.Enabled = false;
			user.UserID = (int)dgvListStudent.CurrentRow.Cells["UserID"].Value;
			user.UserName = dgvListStudent.CurrentRow.Cells["UserName"].Value.ToString();
			user.Password = dgvListStudent.CurrentRow.Cells["Password"].Value.ToString();
			student.StudentID = dgvListStudent.CurrentRow.Cells["StudentID"].Value.ToString();
			student.StudentFirstName = dgvListStudent.CurrentRow.Cells["StudentFirstName"].Value.ToString();
			student.StudentMiddleName = dgvListStudent.CurrentRow.Cells["StudentMiddleName"].Value.ToString();
			student.StudentLastName = dgvListStudent.CurrentRow.Cells["StudentLastName"].Value.ToString();
			student.StudentBirthDate = ((DateTime)dgvListStudent.CurrentRow.Cells["StudentBirthDate"].Value).Date;
			student.StudentEmail = dgvListStudent.CurrentRow.Cells["StudentEmail"].Value.ToString();
			ImageBoxRemoveButtonController();

			studentIntake.StudentIntakeID = (int)dgvListStudent.CurrentRow.Cells["StudentIntakeID"].Value;


			txtUserName.Text = user.UserName;
			txtPassword.Text = user.Password;
			txtFirstName.Text = student.StudentFirstName;
			txtMiddleName.Text = student.StudentMiddleName;
			txtLastName.Text = student.StudentLastName;
			txtEmail.Text = student.StudentEmail;
			dtpDateOfBirth.Value = ((DateTime)dgvListStudent.CurrentRow.Cells["StudentBirthDate"].Value).Date;
			cbxStudentIntake.Text = dgvListStudent.CurrentRow.Cells["Intake"].Value.ToString();
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
			txtUserName.Text = txtPassword.Text = txtFirstName.Text = txtMiddleName.Text = txtLastName.Text = txtEmail.Text = dtpDateOfBirth.Text = "";
			cbxStudentIntake.SelectedIndex = 0;
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

		private void btnClosed_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
