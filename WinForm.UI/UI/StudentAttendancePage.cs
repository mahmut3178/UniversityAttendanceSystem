using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.UI.UI
{
	public partial class StudentAttendancePage : Form
	{
		public StudentAttendancePage()
		{
			InitializeComponent();
			PopulateComboBoxIntake();
			SetFlpProperties();
			PopulateFlpAttendance();
			isFormLoad = true;
		}
		bool isFormLoad = false;
		Random r = new Random();
		IStudentIntakeService _studentIntakeService = InstanceFactory.GetInstance<IStudentIntakeService>();
		ICourseSubjectService _courseSubjectService = InstanceFactory.GetInstance<ICourseSubjectService>();
		IStudentAttendanceService _studentAttendanceService = InstanceFactory.GetInstance<IStudentAttendanceService>();
		private void SetFlpProperties()
		{
			flpAttendance.AutoScroll = true;
		}
		private void PopulateComboBoxIntake()
		{
			List<StudentIntake> studentIntake = _studentIntakeService.GetAll().Where(x => x.StudentID.Equals(Program.student.StudentID)).ToList();
			studentIntake.Insert(0, new StudentIntake { IntakeID = "Select Intake" });
			cbxIntake.DataSource = studentIntake;
			cbxIntake.DisplayMember = "IntakeID";
			cbxIntake.ValueMember = "IntakeID";
		}
		private void cbxIntake_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!isFormLoad)
				return;

			PopulateFlpAttendance();
		}
		private void PopulateFlpAttendance()
		{
			List<CourseSubjectItem> courseSubjects = _courseSubjectService.GetStudentCourseByStudentID(Program.student.StudentID);
			flpAttendance.Controls.Clear();
			foreach (var courseSubject in courseSubjects)
			{
				StudentAttendanceParameter parameter = new StudentAttendanceParameter { IntakeID = cbxIntake.SelectedValue.ToString(), StudentID = Program.student.StudentID, SubjectID = courseSubject.SubjectID };

				StudentAttendanceItem studentAttendanceItem = _studentAttendanceService.GetStudentAttendance(parameter);
				if (studentAttendanceItem != null)
				{
					Panel holderPanel = new Panel();

					holderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
					holderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					holderPanel.Dock = System.Windows.Forms.DockStyle.Top;
					holderPanel.Anchor = AnchorStyles.None;
					holderPanel.Name = "holderPanel";
					holderPanel.Size = new System.Drawing.Size(320, 95);
					holderPanel.TabIndex = 0;

					Label lblSubjectName = new Label();
					lblSubjectName.Dock = DockStyle.Fill;
					lblSubjectName.Font = new System.Drawing.Font("MS Gothic", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					lblSubjectName.ForeColor = System.Drawing.SystemColors.ButtonFace;
					lblSubjectName.Name = "lblSubjectName";
					lblSubjectName.Size = new System.Drawing.Size(holderPanel.ClientSize.Width, 20);
					lblSubjectName.TabIndex = 0;
					lblSubjectName.TextAlign = ContentAlignment.MiddleCenter;
					lblSubjectName.Text = studentAttendanceItem.SubjectName;

					Panel panelTop = new Panel();
					panelTop.BackColor = System.Drawing.Color.DimGray;
					panelTop.Controls.Add(lblSubjectName);
					panelTop.Dock = System.Windows.Forms.DockStyle.Top;
					panelTop.Location = new System.Drawing.Point(0, 0);
					panelTop.Name = "panelTop";
					panelTop.Size = new System.Drawing.Size(300, 18);
					panelTop.TabIndex = 1;

					Label lblAttendance = new Label();
					lblAttendance.Anchor = System.Windows.Forms.AnchorStyles.None;
					lblAttendance.Font = new System.Drawing.Font("MS Gothic", 14.25F, FontStyle.Bold);
					lblAttendance.ForeColor = System.Drawing.SystemColors.ButtonFace;
					lblAttendance.Location = new System.Drawing.Point(-1, 60);
					lblAttendance.Name = "lblAttendance";
					lblAttendance.Size = new System.Drawing.Size(holderPanel.ClientSize.Width, 17);
					lblAttendance.TabIndex = 2;
					lblAttendance.Text = "Attendance: " + studentAttendanceItem.Attendance;
					lblAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

					if (studentAttendanceItem.isAttendancePassed)
						lblAttendance.ForeColor = Color.DarkRed;


					Label lblLecturerName = new Label();
					lblLecturerName.Font = new System.Drawing.Font("MS Gothic", 14.25F, FontStyle.Bold);
					lblLecturerName.ForeColor = System.Drawing.SystemColors.ButtonFace;
					lblLecturerName.Location = new System.Drawing.Point(3, 32);
					lblLecturerName.Name = "lblLecturerName";
					lblLecturerName.Size = new System.Drawing.Size(holderPanel.ClientSize.Width, 17);
					lblLecturerName.TabIndex = 1;
					lblLecturerName.Text = "Lecturer: " + studentAttendanceItem.LecturerName;
					lblLecturerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;



					holderPanel.Controls.Add(lblAttendance);
					holderPanel.Controls.Add(lblLecturerName);
					holderPanel.Controls.Add(panelTop);
					flpAttendance.Controls.Add(holderPanel);
				}
			}
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
