using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
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

namespace WinForm.UI.UI
{
	public partial class LecturerAllAttendancePage : Form
	{
		public LecturerAllAttendancePage()
		{
			isFormLoaded = true;
			InitializeComponent();
			PopulateCbxLecturerTimeTable();
		}
		bool isFormLoaded = false;

		IClassRoomService _classRoomService = InstanceFactory.GetInstance<IClassRoomService>();
		IStudentAttendanceService _studentAttendanceService = InstanceFactory.GetInstance<IStudentAttendanceService>();
		ITimeTableService _timeTableservice = InstanceFactory.GetInstance<ITimeTableService>();
		IPresenceStatusService _presenceStatus = InstanceFactory.GetInstance<IPresenceStatusService>();
		private void Move_MouseDown(object sender, MouseEventArgs e)
		{
			FunctionBase.ReleaseCapture();
			FunctionBase.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void PopulateCbxLecturerTimeTable()
		{
			var lecturerPastClasses = _timeTableservice.GetPastClasses(Program.lecturer.LecturerID);
			if (lecturerPastClasses.Count == 0)
				return;

			cbxClassSchedule.DataSource = lecturerPastClasses;
			cbxClassSchedule.DisplayMember = "ClassDetails";
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PublishStudentAttedance()
		{
			List<StudentAttendance> studentAttendances = new List<StudentAttendance>();

			foreach (DataGridViewRow row in dgvStudentAttendance.Rows)
			{
				StudentAttendance studentAttendance = new StudentAttendance();
				studentAttendance.StudentAttendanceID = Convert.ToInt32(row.Cells["StudentAttendanceID"].Value);
				studentAttendance.StudentID = row.Cells["StudentID"].Value.ToString();
				studentAttendance.IntakeID = row.Cells["IntakeID"].Value.ToString();
				studentAttendance.SubjectID = Convert.ToInt32(row.Cells["SubjectID"].Value);
				studentAttendance.LecturerID = row.Cells["LecturerID"].Value.ToString();
				studentAttendance.PresenceStatusID = Convert.ToInt32(row.Cells["PresenceStatus"].Value);
				studentAttendance.DayOfWeek = row.Cells["DayOfWeek"].Value == null ? Convert.ToInt32(DateTime.Now.DayOfWeek) : Convert.ToInt32(row.Cells["DayOfWeek"].Value);
				studentAttendance.WeekOfYear = row.Cells["WeekOfYear"].Value == null ? DateTime.Now.DayOfYear + 3 / 7 : Convert.ToInt32(row.Cells["WeekOfYear"].Value);
				studentAttendance.Date = DateTime.Today;

				studentAttendances.Add(studentAttendance);
			}
			_studentAttendanceService.PublishNewStudentAttendance(studentAttendances);
			MMessageBox.ShowMessage("Attendance Published Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}

		private void btnPublishStudentAttendance_Click(object sender, EventArgs e)
		{
			PublishStudentAttedance();
		}
		private void PopulateListStudentAttendance()
		{
			if (!isFormLoaded)
				return;

			if (cbxClassSchedule.SelectedValue != null)
			{
				LecturerTimeTableItem tt = (LecturerTimeTableItem)cbxClassSchedule.SelectedItem;
				List<LecturerStudentAttendanceItem> studentAttendanceItems = _studentAttendanceService.GetLecturerStudentAttendance(Program.lecturer.LecturerID, tt.IntakeID, tt.SubjectID, tt.SubjectDayID, tt.WeekOfYear);

				DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
				var presenceStatuses = _presenceStatus.GetAll();
				presenceStatuses.Insert(0, new PresenceStatus { PresenceStatusID = 0, PresenceStatusName = "Select Status" });
				cmb.DataSource = presenceStatuses;
				cmb.DisplayMember = "PresenceStatusName";
				cmb.ValueMember = "PresenceStatusID";
				cmb.HeaderText = "PresenceStatus";
				cmb.Name = "PresenceStatus";
				cmb.DataPropertyName = "PresenceStatus";

				dgvStudentAttendance.Rows.Clear();
				dgvStudentAttendance.ReadOnly = false;
				dgvStudentAttendance.ColumnCount = 9;
				dgvStudentAttendance.Columns[0].Name = "StudentAttendanceID";
				dgvStudentAttendance.Columns[1].Name = "StudentID";
				dgvStudentAttendance.Columns[2].Name = "IntakeID";
				dgvStudentAttendance.Columns[3].Name = "SubjectID";
				dgvStudentAttendance.Columns[4].Name = "LecturerID";
				dgvStudentAttendance.Columns[5].Name = "DayOfWeek";
				dgvStudentAttendance.Columns[6].Name = "WeekOfYear";
				dgvStudentAttendance.Columns[7].Name = "Date";
				dgvStudentAttendance.Columns[8].Name = "Student Name";
				dgvStudentAttendance.Columns.Add(cmb);

				dgvStudentAttendance.Columns["StudentAttendanceID"].Visible = false;
				dgvStudentAttendance.Columns["WeekOfYear"].Visible = false;
				dgvStudentAttendance.Columns["DayOfWeek"].Visible = false;
				dgvStudentAttendance.Columns["Date"].Visible = false;
				dgvStudentAttendance.Columns["LecturerID"].Visible = false;
				dgvStudentAttendance.Columns["SubjectID"].Visible = false;

				dgvStudentAttendance.Columns["StudentID"].ReadOnly = true;
				dgvStudentAttendance.Columns["IntakeID"].ReadOnly = true;
				dgvStudentAttendance.Columns["Student NAme"].ReadOnly = true;

				for (int i = 0; i < studentAttendanceItems.Count; i++)
				{
					string[] row = new string[]{
					studentAttendanceItems[i].StudentAttendanceID.ToString(),
					studentAttendanceItems[i].StudentID,
					studentAttendanceItems[i].IntakeID,
					studentAttendanceItems[i].SubjectID.ToString(),
					studentAttendanceItems[i].LecturerID,
					studentAttendanceItems[i].DayOfWeek.ToString(),
					studentAttendanceItems[i].WeekOfyear.ToString(),
					studentAttendanceItems[i].Date.ToString(),
					studentAttendanceItems[i].StudentFullName.ToString()
				};
					dgvStudentAttendance.Rows.Add(row);
					dgvStudentAttendance.Rows[i].Cells["PresenceStatus"].Value = studentAttendanceItems[i].PresenceStatusID;
				}

				if (dgvStudentAttendance.Rows.Count == 0)
					btnPublishStudentAttendance.Enabled = false;
				else

					btnPublishStudentAttendance.Enabled = true;
			}
		}

		private void cbxClassSchedule_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (isFormLoaded)
				PopulateListStudentAttendance();
		}
	}
}
