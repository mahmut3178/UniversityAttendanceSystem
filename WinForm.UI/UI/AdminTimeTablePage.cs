using Business.Abstract;
using Business.BaseFunctions;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using Business.Exceptions;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using FluentValidation;
using Karebase.WinFormsUI.Controls;
using System;
using System.Activities.Expressions;
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
	public partial class AdminTimeTablePage : Form
	{

		public AdminTimeTablePage()
		{
			InitializeComponent();
			SetDtpProperties();
			PopulateCbxSearchDaysOfWeek();
			PopulateCbxSearchLecturer();
			PopulateCbxIntake();
			PopulateCbxClassRoom();
			PopulateCbxSearchIntake();
			PopulateCbxLecturer();
			PopulateCbxSubject();
			PopulateCbxDaysOfWeek();
			PopulateGridIntakeTimeTable();
			isFormLoaded = true;
		}
		bool isFormLoaded = false;
		IIntakeService _intakeService = InstanceFactory.GetInstance<IIntakeService>();
		ILecturerService _lecturerService = InstanceFactory.GetInstance<ILecturerService>();
		ISubjectService _subjectService = InstanceFactory.GetInstance<ISubjectService>();
		ITimeTableService _timeTableService = InstanceFactory.GetInstance<ITimeTableService>();
		IClassRoomService _classRoomService = InstanceFactory.GetInstance<IClassRoomService>();
		TimeTable timeTable = new TimeTable();
		private void SetDtpProperties()
		{
			dtpSubjectTime.Format = DateTimePickerFormat.Custom;
			dtpSubjectTime.CustomFormat = "HH:mm";
			dtpSubjectTime.ShowUpDown = true;
			dtpSubjectTime.Value = new DateTime(1900, 1, 1);
		}

		private void PopulateCbxClassRoom()
		{
			cbxClassRoom.Size = new Size(140, 25);
			List<ClassRoom> classRooms = _classRoomService.GetAll();
			classRooms.Insert(0, new ClassRoom { ClassRoomID = 0, ClassRoomName = "Select Classroom" });
			cbxClassRoom.DataSource = classRooms;
			cbxClassRoom.DisplayMember = "ClassRoomName";
			cbxClassRoom.ValueMember = "ClassRoomID";
		}
		private void PopulateCbxIntake()
		{

			List<Intake> intakes = _intakeService.GetAllIntake();
			intakes.Insert(0, new Intake { IntakeID = "Select Intake" });
			cbxIntake.DataSource = intakes;
			cbxIntake.ValueMember = "IntakeID";
			cbxIntake.DisplayMember = "IntakeID";
			cbxIntake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbxIntake.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
		private void PopulateCbxSearchIntake()
		{
			List<Intake> intake = _intakeService.GetAllIntake();
			intake.Insert(0, new Intake { IntakeID = "Select Intake" });
			cbxSearchIntake.DataSource = intake;
			cbxSearchIntake.ValueMember = "IntakeID";
			cbxSearchIntake.DisplayMember = "IntakeID";
			cbxSearchIntake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbxSearchIntake.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
		private void PopulateCbxSearchLecturer()
		{
			List<Lecturer> lecturerList = _lecturerService.GetAll();
			lecturerList.Insert(0, new Lecturer { FirstName = "Select", MiddleName = "Lecturer", LastName = "", LecturerID = "Select Lecturer" });
			DataTable lecturer = FunctionBase.ToDataTable(lecturerList);
			lecturer.Columns.Add("FullName", typeof(string), "FirstName +' '+ MiddleName +' '+ LastName");
			cbxSearchLecturer.DataSource = lecturer;
			cbxSearchLecturer.DisplayMember = "FullName";
			cbxSearchLecturer.ValueMember = "LecturerID";
			cbxSearchLecturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbxSearchLecturer.AutoCompleteSource = AutoCompleteSource.ListItems;
			
		}
		private void PopulateCbxLecturer()
		{
			List<Lecturer> lecturerList = _lecturerService.GetAll();
			lecturerList.Insert(0, new Lecturer { FirstName = "Select", MiddleName = "Lecturer", LastName = "", LecturerID = "Select Lecturer" });
			DataTable lecturer = FunctionBase.ToDataTable(lecturerList);
			lecturer.Columns.Add("FullName", typeof(string), "FirstName +' '+ MiddleName +' '+ LastName");
			cbxLecturer.DataSource = lecturer;
			cbxLecturer.DisplayMember = "FullName";
			cbxLecturer.ValueMember = "LecturerID";
			cbxLecturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbxLecturer.AutoCompleteSource = AutoCompleteSource.ListItems;
		}
		private void PopulateCbxSubject()
		{
				List<IntakeSubjectItem> intakeSubjectItem = _subjectService.GetIntakeSubjects(cbxIntake.SelectedValue.ToString());
				intakeSubjectItem.Insert(0, new IntakeSubjectItem { SubjectName = "Select Subject", SubjectID = 0 });
				if (intakeSubjectItem.Count == 0)
					cbxSubject.Text = "Select Subject";
				cbxSubject.DataSource = intakeSubjectItem;
				cbxSubject.DisplayMember = "SubjectName";
				cbxSubject.ValueMember = "SubjectID";
				cbxIntake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				cbxIntake.AutoCompleteSource = AutoCompleteSource.ListItems;
		
		}
		private void PopulateCbxDaysOfWeek()
		{
			cbxDayOfWeek.DataSource = DaysOfWeek.DaysOfTheWeek();
			cbxDayOfWeek.DisplayMember = "Day";
			cbxDayOfWeek.ValueMember = "Value";
		}
		private void PopulateCbxSearchDaysOfWeek()
		{
			cbxSearchDay.DataSource = DaysOfWeek.DaysOfTheWeek();
			cbxSearchDay.DisplayMember = "Day";
			cbxSearchDay.ValueMember = "Value";
		}
		private void PopulateGridIntakeTimeTable()
		{
			dgvListIntakeTimeTable.DataSource = _timeTableService.GetListTimeTable(cbxSearchIntake.SelectedValue.ToString(), cbxSearchLecturer.SelectedValue.ToString(), (int)cbxSearchDay.SelectedValue);
			dgvListIntakeTimeTable.Columns["ClassRoomID"].Visible = false;
			dgvListIntakeTimeTable.Columns["TimeTableID"].Visible = false;
			dgvListIntakeTimeTable.Columns["LecturerID"].Visible = false;
			dgvListIntakeTimeTable.Columns["SubjectID"].Visible = false;
			dgvListIntakeTimeTable.Columns["SubjectDayID"].Visible = false;
		}

		private void btnClosed_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void AdminTimeTablePage_SizeChanged(object sender, EventArgs e)
		{
			if (dgvListIntakeTimeTable.Width < 900)
				dgvListIntakeTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			else
				dgvListIntakeTimeTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void dgvListIntakeTimeTable_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			timeTable.TimeTableID = (int)dgvListIntakeTimeTable.CurrentRow.Cells["TimeTableID"].Value;
			timeTable.LecturerID = dgvListIntakeTimeTable.CurrentRow.Cells["LecturerID"].Value.ToString();
			timeTable.SubjectID = (int)dgvListIntakeTimeTable.CurrentRow.Cells["SubjectID"].Value;
			timeTable.IntakeID = dgvListIntakeTimeTable.CurrentRow.Cells["Intake"].Value.ToString();
			timeTable.SubjectDay = (int)dgvListIntakeTimeTable.CurrentRow.Cells["SubjectDayID"].Value;
			timeTable.SubjectTime = (TimeSpan)dgvListIntakeTimeTable.CurrentRow.Cells["SubjectTime"].Value;
			timeTable.SubjectDuration = (int)dgvListIntakeTimeTable.CurrentRow.Cells["SubjectDuration"].Value;
			timeTable.ClassRoomID = (int)dgvListIntakeTimeTable.CurrentRow.Cells["ClassRoomID"].Value;

			cbxIntake.Text = timeTable.IntakeID;
			cbxLecturer.Text = dgvListIntakeTimeTable.CurrentRow.Cells["LecturerName"].Value.ToString();
			cbxSubject.Text = dgvListIntakeTimeTable.CurrentRow.Cells["SubjectName"].Value.ToString();
			cbxDayOfWeek.Text = dgvListIntakeTimeTable.CurrentRow.Cells["SubjectDay"].Value.ToString();
			DateTime dt = new DateTime(1900, 01, 01);
			dt = dt + (TimeSpan)dgvListIntakeTimeTable.CurrentRow.Cells["SubjectTime"].Value;
			dtpSubjectTime.Value = dt;
			nudDuration.Value = timeTable.SubjectDuration;
			cbxClassRoom.Text = dgvListIntakeTimeTable.CurrentRow.Cells["ClassRoomName"].Value.ToString();
		}


		private void cbxSearchIntake_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isFormLoaded)
				PopulateGridIntakeTimeTable();
		}

		private void cbxSearchLecturer_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isFormLoaded)
				PopulateGridIntakeTimeTable(); ;
		}

		private void btnInsertTimeTable_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(InsertTimeTable);			
		}

		public void InsertTimeTable()
		{
			_timeTableService.Insert(new TimeTable { LecturerID = cbxLecturer.SelectedValue.ToString(), SubjectID = (int)cbxSubject.SelectedValue, IntakeID = cbxIntake.SelectedValue.ToString(), SubjectDay = (int)cbxDayOfWeek.SelectedValue, SubjectTime = dtpSubjectTime.Value.TimeOfDay, SubjectDuration = (int)nudDuration.Value, ClassRoomID = (int)cbxClassRoom.SelectedValue });
			PopulateGridIntakeTimeTable();
			MMessageBox.ShowMessage("Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void cbxIntake_SelectedIndexChanged(object sender, EventArgs e)
		{
			PopulateCbxSubject();
		}
		private void cbxSearchDay_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isFormLoaded)
				PopulateGridIntakeTimeTable();
		}

		private void btnDeleteTimeTable_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(DeleteTimeTable);
		}

		private void DeleteTimeTable()
		{
			_timeTableService.Delete(new TimeTable { TimeTableID = (int)dgvListIntakeTimeTable.CurrentRow.Cells["TimeTableID"].Value });
			PopulateGridIntakeTimeTable();
			MMessageBox.ShowMessage("Record Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdateTimeTable_Click(object sender, EventArgs e)
		{
			DelegateAction.RunMethod(UpdateTimeTable);	
		}
		private void UpdateTimeTable()
		{
				_timeTableService.Update(new TimeTable { TimeTableID = timeTable.TimeTableID, LecturerID = cbxLecturer.SelectedValue.ToString(), SubjectID = (int)cbxSubject.SelectedValue, IntakeID = cbxIntake.SelectedValue.ToString(), SubjectDay = (int)cbxDayOfWeek.SelectedValue, SubjectTime = dtpSubjectTime.Value.TimeOfDay, SubjectDuration = (int)nudDuration.Value, ClassRoomID = (int)cbxClassRoom.SelectedValue });
				PopulateGridIntakeTimeTable();
				MMessageBox.ShowMessage("Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
