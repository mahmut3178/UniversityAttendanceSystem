using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Karebase.WinFormsUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.Properties;

namespace WinForm.UI.UI
{
	public partial class ChangeUserPassword : Form
	{
		public ChangeUserPassword()
		{
			InitializeComponent();
		}

		public User user = new User();
		IUserService _userService = InstanceFactory.GetInstance<IUserService>();
		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			FunctionBase.ReleaseCapture();
			FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			if (user.Password.Equals(txtOldPassword.Text))
			{
				if (txtNewPassword.Text.Equals(txtReNewPassword.Text))
				{
					user.Password = txtReNewPassword.Text;
					_userService.Update(user);
					this.Close();
					MMessageBox.ShowMessage("Password Has successfully Changed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MMessageBox.ShowMessage("New Passwords do not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MMessageBox.ShowMessage("Current Password does not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void txtNewPassword_TextChanged(object sender, EventArgs e)
		{
			if (txtNewPassword.Text == "")
				HidePasswordStrengthTool();
			else
				lblPasswordStrength.Visible = true;

			int charCount = txtNewPassword.Text.Distinct().Count();
			if (charCount < 4)
			{
				lblPasswordStrength.Image = Properties.Resources.bubbleRed;
				lblPasswordStrength.ForeColor = Color.DarkRed;
				lblPasswordStrength.Text = "Bad Password";
			}
			else if (charCount < 6)
			{
				lblPasswordStrength.Image = Properties.Resources.bubbleRed;
				lblPasswordStrength.ForeColor = Color.Red;
				lblPasswordStrength.Text = "Okay Password";
			}
			else
			{
				lblPasswordStrength.Image = Properties.Resources.greenBubble;
				lblPasswordStrength.ForeColor = Color.Green;
				lblPasswordStrength.Text = "Password is Strong!";
			}
		}

		private void txtNewPassword_Leave(object sender, EventArgs e)
		{
			if (txtNewPassword.Text == "")
			{
				HidePasswordStrengthTool();
			}
		}

		private void HidePasswordStrengthTool()
		{
			lblPasswordStrength.Visible = false;
		}

	}
}
