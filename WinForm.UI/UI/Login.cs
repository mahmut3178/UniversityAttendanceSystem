using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		IUserService _userService = InstanceFactory.GetInstance<IUserService>();
		private void txtUserName_Enter(object sender, EventArgs e)
		{
			if (txtUserName.Text == "USERNAME")
			{
				txtUserName.Text = "";
				txtUserName.ForeColor = Color.White;
			}
		}

		private void txtUserName_Leave(object sender, EventArgs e)
		{
			if (txtUserName.Text == "")
			{
				txtUserName.Text = "USERNAME";
				txtUserName.ForeColor = Color.DimGray;
			}
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text == "PASSWORD")
			{
				txtPassword.Text = "";
				txtPassword.ForeColor = Color.White;
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text == "")
			{
				txtPassword.Text = "PASSWORD";
				txtPassword.ForeColor = Color.DimGray;
				txtPassword.UseSystemPasswordChar = false;
			}
		}


		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			FunctionBase.ReleaseCapture();
			FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			UserLogin(txtUserName.Text, txtPassword.Text);
		}

		private void UserLogin(string UserName, string Password)
		{
			DelegateAction.RunMethod(LoginUser);
		}

		private void LoginUser()
		{
				var userItem = _userService.UserLogin(new User { UserName = txtUserName.Text, Password = txtPassword.Text });
				if (userItem.UserTypeID == 1)
				{
					AdminMainPage adminMainPage = new AdminMainPage();
					adminMainPage.Show();
					adminMainPage.FormClosed += Logout;
					this.Hide();
				}
				else if (userItem.UserTypeID == 2)
				{
					Program.lecturer = new Lecturer { LecturerID = userItem.UserName };
					LecturerMainPage lecturerMainPage = new LecturerMainPage();
					lecturerMainPage.Show();
					lecturerMainPage.FormClosed += Logout;
					this.Hide();
				}
				else if (userItem.UserTypeID == 3)
				{
					Program.student = new Student { StudentID = userItem.UserName };
					StudentMainPage studentMainPage = new StudentMainPage();
					studentMainPage.Show();
					studentMainPage.FormClosed += Logout;
					this.Hide();
				}		

		}

		private void Logout(object sender, FormClosedEventArgs e)
		{
			txtUserName.Clear();
			txtUserName.Text = "USERNAME";
			txtUserName.ForeColor = Color.DimGray;

			txtPassword.Clear();
			txtPassword.Text = "PASSWORD";
			txtPassword.ForeColor = Color.DimGray;
			txtPassword.UseSystemPasswordChar = false;

			lblException.Text = "";
			this.Show();
		}
	}
}
