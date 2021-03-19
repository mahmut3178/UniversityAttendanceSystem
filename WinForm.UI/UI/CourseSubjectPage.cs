using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
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
using WinForm.UI.Functions;

namespace WinForm.UI.UI
{
	public partial class CourseSubjectPage : Form
	{
		public CourseSubjectPage()
		{
			InitializeComponent();
			PopulateGridCourses();
			SetGridProperties();
			PopulateListBoxSubjects();
		}
		ICourseSubjectService _courseSubjectService = InstanceFactory.GetInstance<ICourseSubjectService>();
		ICourseService _courseService = InstanceFactory.GetInstance<ICourseService>();
		ISubjectService _subjectService = InstanceFactory.GetInstance<ISubjectService>();

		private void txtSearchCourse_TextChanged(object sender, EventArgs e)
		{
			PopulateGridCourses();
		}
		private void txtSearchSubject_TextChanged(object sender, EventArgs e)
		{
			PopulateListBoxSubjects();
		}
		private void SetGridProperties()
		{
			dgvListCourseSubject.DefaultCellStyle.ForeColor = Color.Black;
			dgvListCourse.DefaultCellStyle.ForeColor = Color.Black;
		}
		public void PopulateGridCourses()
		{
			dgvListCourse.DataSource = _courseService.GetByCourse(txtSearchCourse.Text);
			dgvListCourse.Columns["CourseID"].Visible = false;
			dgvListCourse.Columns["IsCourseActive"].Visible = false;
		}
		public void PopulateGridCourseSubjects()
		{
			dgvListCourseSubject.DataSource = _courseSubjectService.GetCourseSubjects((int)dgvListCourse.CurrentRow.Cells["CourseID"].Value);
			dgvListCourseSubject.Columns["CourseSubjectID"].Visible = false;
			dgvListCourseSubject.Columns["CourseID"].Visible = false;
			dgvListCourseSubject.Columns["SubjectID"].Visible = false;
			dgvListCourseSubject.Columns["CourseName"].Visible = false;
		}

		private void PopulateListBoxSubjects()
		{
			lstBoxSubject.DataSource = _subjectService.GetBySubject(txtSearchSubject.Text);
			lstBoxSubject.DisplayMember = "SubjectName";
			lstBoxSubject.ValueMember = "SubjectID";
		}
		private void btnInsertSubject_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertSubject);
		}

		private void InsertSubject()
		{
			_courseSubjectService.Insert(new CourseSubject {CourseID =(int)dgvListCourse.CurrentRow.Cells["CourseID"].Value, SubjectID = (int)lstBoxSubject.SelectedValue} );
				PopulateGridCourseSubjects();
		}

		private void btnRemoveSubject_Click(object sender, EventArgs e)
		{
			int courseSubjectID = (int)dgvListCourseSubject.CurrentRow.Cells["CourseSubjectID"].Value;
			_courseSubjectService.Delete(new CourseSubject { CourseSubjectID = courseSubjectID });
			PopulateGridCourseSubjects();
		}

		private void dgvListCourse_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			PopulateGridCourseSubjects();
		}
		private void dgvListCourse_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			PopulateGridCourseSubjects();
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

		private void btnManageSubjects_Click(object sender, EventArgs e)
		{
			CRUDSubjectPage subject = new CRUDSubjectPage();
			subject.Location = this.Location;
			subject.ShowDialog();
			PopulateListBoxSubjects();
		}
	}
}
