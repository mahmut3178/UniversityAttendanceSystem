using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation;
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
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class CRUDSubjectPage : Form
	{
		public CRUDSubjectPage()
		{
			InitializeComponent();
			SetGridProperties();
			PopulateGridSubjects();
		}
		ISubjectService _subjectService = InstanceFactory.GetInstance<ISubjectService>();
		private void SetGridProperties()
		{
			dgvSubjects.DefaultCellStyle.ForeColor = Color.Black;
		}
		private void PopulateGridSubjects()
		{
			dgvSubjects.DataSource = _subjectService.GetBySubject(txtSearchSubject.Text);
			dgvSubjects.Columns["SubjectID"].Visible = false;
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtSearchSubject_TextChanged(object sender, EventArgs e)
		{
			txtSubject.Text = dgvSubjects.CurrentRow.Cells["SubjectName"].Value.ToString();
			if (txtSearchSubject.Text.Equals(""))
				txtSubject.Text = "";
			PopulateGridSubjects();
		}

		private void btnInsertSubject_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertSubject);
		}

		private void InsertSubject()
		{
			_subjectService.Insert(new Subject { SubjectName = txtSubject.Text });
			PopulateGridSubjects();
		}

		private void btnDeleteSubject_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteSubject);
		}

		private void DeleteSubject()
		{
			_subjectService.Delete(new Subject { SubjectID = (int)dgvSubjects.CurrentRow.Cells["SubjectID"].Value });
			PopulateGridSubjects();
			MMessageBox.ShowMessage("Data Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdateSubject_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(UpdateSubject);
		}

		private void UpdateSubject()
		{
			_subjectService.Update(new Subject { SubjectID = (int)dgvSubjects.CurrentRow.Cells["SubjectID"].Value, SubjectName = txtSubject.Text });
			PopulateGridSubjects();
		}

		private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtSubject.Text = dgvSubjects.CurrentRow.Cells["SubjectName"].Value.ToString();
		}
	}
}
