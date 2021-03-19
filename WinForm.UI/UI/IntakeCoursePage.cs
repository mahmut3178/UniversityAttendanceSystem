using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
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
	public partial class IntakeCoursePage : Form
	{
		IIntakeCourseService _intakeCourseService = InstanceFactory.GetInstance<IIntakeCourseService>();
		IIntakeService _intakeService = InstanceFactory.GetInstance<IIntakeService>();
		public IntakeCoursePage()
		{
			InitializeComponent();
			PopulateListIntakeCourse();
		}
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			PopulateListIntakeCourse();
		}
		public void PopulateListIntakeCourse()
		{
			grdListIntakeCourses.DataSource = FunctionBase.ToDataTable(_intakeCourseService.GetIntakeCourses(txtSearch.Text));
			if (grdListIntakeCourses.ColumnCount > 0)
			{
				grdListIntakeCourses.Columns["IntakeCourseID"].Visible = false;
				grdListIntakeCourses.Columns["CourseID"].Visible = false;
			}
		}
		private void IntakeCourse_Resize(object sender, EventArgs e)
		{
			if (grdListIntakeCourses.Width > 800)
				grdListIntakeCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnIntakeCourse_Click(object sender, EventArgs e)
		{
			ManageIntake manageIntake = new ManageIntake();
			manageIntake.Location = this.Location;
			manageIntake.ShowDialog();
			PopulateListIntakeCourse();
		}

		private void btnDeleteIntakeCourse_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteIntakeCourse);
		}

		private void DeleteIntakeCourse()
		{
			int intakeCourseID = Convert.ToInt32(grdListIntakeCourses.CurrentRow.Cells["IntakeCourseID"].Value);
			string intakeID = grdListIntakeCourses.CurrentRow.Cells["Intake"].Value.ToString();
			int courseID = Convert.ToInt32(grdListIntakeCourses.CurrentRow.Cells["CourseID"].Value);
			IntakeCourse intakeCourse = new IntakeCourse { IntakeCourseID = intakeCourseID, IntakeID = intakeID, CourseID = courseID };
			_intakeCourseService.InActivateIntakeCourse(intakeCourse);
			_intakeService.InactivateIntake(new Intake { IntakeID = intakeID });
			PopulateListIntakeCourse();
		}

		private void btnCourseSubject_Click(object sender, EventArgs e)
		{
			CourseSubjectPage courseSubject = new CourseSubjectPage();
			courseSubject.Location = this.Location;
			courseSubject.ShowDialog();
			PopulateListIntakeCourse();
		}
	}
}
