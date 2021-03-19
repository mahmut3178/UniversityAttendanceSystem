using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using FluentValidation;
using Karebase.WinFormsUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class ManageIntake : Form
	{
		public ManageIntake()
		{
			InitializeComponent();
			PopulateGridIntake();
			PopulateGridCourse();
			SetGridProperties();
		}
		IIntakeService _intakeService = InstanceFactory.GetInstance<IIntakeService>();
		ICourseService _courseService = InstanceFactory.GetInstance<ICourseService>();
		IIntakeCourseService _intakeCourseService = InstanceFactory.GetInstance<IIntakeCourseService>();
		int globalCourseID = 0;
		public void PopulateGridIntake()
		{
			try
			{
				var intakeList = _intakeService.GetByIntake(txtSearchIntake.Text, chbxUsed.Checked == true);
				dgvListIntake.DataSource = intakeList;
				if (intakeList.Count > 0)
					dgvListIntake.Columns["IsIntakeActive"].Visible = false;
			}
			catch (Exception)
			{
				throw;
			}
		}
		private void SetGridProperties()
		{
			dgvListIntake.DefaultCellStyle.ForeColor = Color.Black;
			dgvListCourse.DefaultCellStyle.ForeColor = Color.Black;
		}
		private void PopulateCombobBoxIsUsed()
		{
			ComboBoxItem[] comboBoxItem = new ComboBoxItem[] { new ComboBoxItem { Text = "Enrolled Intakes", Value = true }, new ComboBoxItem() { Text = "New Intakes", Value = false } };

		}
		public void PopulateGridCourse()
		{
			DelegateAction.RunMethod(PopulateGridCourseAction);
		}

		private void PopulateGridCourseAction()
		{
			dgvListCourse.DataSource = _courseService.GetByCourse(txtSearchCourse.Text);
			if (dgvListCourse.ColumnCount > 0)
				dgvListCourse.Columns["CourseID"].Visible = false;
			dgvListCourse.Columns["IsCourseActive"].Visible = false;
		}

		private void txtSearchCourse_TextChanged(object sender, EventArgs e)
		{
			PopulateGridCourse();
		}
		private void txtSearchIntake_TextChanged(object sender, EventArgs e)
		{
			PopulateGridIntake();
		}

		private void btnInsertIntake_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertIntake);
		}
		private void InsertIntake()
		{
			_intakeService.Insert(new Intake { IntakeID = txtIntake.Text, IsIntakeActive = true });
			PopulateGridIntake();
		}
		private void btnDeleteIntake_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteIntake);
		}
		private void DeleteIntake()
		{
			_intakeService.InactivateIntake(new Intake { IntakeID = txtIntake.Text, IsIntakeActive = false });
			PopulateGridIntake();
		}
		private void btnInsertCourse_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertCourse);
		}

		private void InsertCourse()
		{
			_courseService.Insert(new Course { CourseName = txtCourse.Text });
			PopulateGridCourse();
		}

		private void btnDeleteCourse_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteCourse);
		}

		private void DeleteCourse()
		{
			_courseService.InactivateCourse(new Course { CourseID = globalCourseID, CourseName = txtCourse.Text, IsCourseActive = false });
			PopulateGridCourse();
			MMessageBox.ShowMessage("Course Removed Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		private void btnUpdateCourse_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(UpdateCourse);
		}

		private void UpdateCourse()
		{
			_courseService.Update(new Course { CourseID = globalCourseID, CourseName = txtCourse.Text });
			PopulateGridCourse();
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			FunctionBase.ReleaseCapture();
			FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void dgvListCourse_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCourse.Text = dgvListCourse.CurrentRow.Cells["CourseName"].Value.ToString();
			globalCourseID = (int)dgvListCourse.CurrentRow.Cells["CourseID"].Value;
		}

		private void dgvListIntake_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvListIntake.RowCount > 0)
				txtIntake.Text = dgvListIntake.CurrentRow.Cells["IntakeID"].Value.ToString();

		}

		private void dgvListIntake_CellEnter(object sender, DataGridViewCellEventArgs e)
		{

			txtIntake.Text = dgvListIntake.CurrentRow.Cells["IntakeID"].Value.ToString();
		}

		private void dgvListCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			globalCourseID = (int)dgvListCourse.CurrentRow.Cells["CourseID"].Value;
			txtCourse.Text = dgvListCourse.CurrentRow.Cells["CourseName"].Value.ToString();
		}

		private void chbxUsed_CheckedChanged(object sender, EventArgs e)
		{
			if (chbxUsed.Checked == true)
				btnLinkIntakeCourse.Enabled = false;
			else
				btnLinkIntakeCourse.Enabled = true;

			PopulateGridIntake();
		}
		private void btnLinkIntakeCourse_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(LinkIntake);
		}
		private void LinkIntake()
		{
			_intakeCourseService.Insert(new IntakeCourse { CourseID = globalCourseID, IntakeID = txtIntake.Text, IsIntakeCourseActive = true });
			PopulateGridIntake();
			PopulateGridCourse();
			MMessageBox.ShowMessage("Successfully Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
