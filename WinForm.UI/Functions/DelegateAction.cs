using Business.Exceptions;
using Karebase.WinFormsUI.Controls;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinForm.UI.UI.AdminTimeTablePage;

namespace WinForm.UI.Functions
{
	public struct DelegateAction
	{
		public static void RunMethod(Action action)
		{
			try
			{
				action();
			}
			catch (ValidationException ex)
			{
				MMessageBox.ShowMessage(ex.Message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (DataUsedException ex)
			{

				MMessageBox.ShowMessage(ex.Message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (DataExistException ex)
			{

				MMessageBox.ShowMessage(ex.Message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (LoginFailedException ex)
			{

				MMessageBox.ShowMessage(ex.Message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (TransactionFailedException ex)
			{

				MMessageBox.ShowMessage(ex.Message.ToString(), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (DbUpdateException)
			{
				MMessageBox.ShowMessage("Data Already Exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception)
			{
				MMessageBox.ShowMessage("Something Went Wrong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


	}
}
