using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
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
	public partial class StudentTimeTablePage : Form
	{
		public StudentTimeTablePage()
		{
			InitializeComponent();
			SetFontProperties();
			PopulateFlpTimeTable();
			PopulateComboBoxDays();
	
			isLoaded = true;
		}
		bool isLoaded = false;
		Color labelTextColor;
		Font labelHeaderTextFontStyle;
		Font labelextFontStyle;

		ITimeTableService _timeTableService = InstanceFactory.GetInstance<ITimeTableService>();
		IStudentIntakeService _studentIntakeService = InstanceFactory.GetInstance<IStudentIntakeService>();
		private void SetFontProperties()
		{
			labelHeaderTextFontStyle = new Font("MS Gothic", 9, FontStyle.Bold);
			labelextFontStyle = new Font("MS Gothic", 15);
			labelTextColor = Color.FloralWhite;

			flpTimeTable.AutoScroll = false;
			flpTimeTable.HorizontalScroll.Enabled = false;
			flpTimeTable.AutoScroll = true;
		}
		private void PopulateComboBoxDays()
		{
			cbxDays.DataSource = DaysOfWeek.DaysOfTheWeek();
			cbxDays.DisplayMember = "Day";
			cbxDays.ValueMember = "Value";
		}
		

		private void PopulateFlpTimeTable()
		{
			if (isLoaded == false)
				return;
			flpTimeTable.Controls.Clear();
			List<TimeTableItem> timeTableItems = _timeTableService.GetStudentTimeTable(Program.student.StudentID, (int)cbxDays.SelectedValue);

			foreach (var item in timeTableItems)
			{

				Panel holderPanel = new Panel();
				holderPanel.Size = new Size(flpTimeTable.ClientSize.Width, 111);
				holderPanel.BorderStyle = BorderStyle.FixedSingle;
				holderPanel.BackColor = Color.FromArgb(64, 64, 64);

				Panel topPanel = new Panel();
				topPanel.Height = 20;
				topPanel.BackColor = Color.DarkGray;
				topPanel.Dock = DockStyle.Top;
				topPanel.Width = flpTimeTable.ClientSize.Width;

				Label lblSubjectName = new Label();
				lblSubjectName.Text = item.SubjectName;
				lblSubjectName.TextAlign = ContentAlignment.MiddleCenter;
				lblSubjectName.Dock = DockStyle.Fill;
				lblSubjectName.ForeColor = labelTextColor;
				lblSubjectName.Font = labelHeaderTextFontStyle;
				 
				Label lblLecturerName = new Label();
				lblLecturerName.Text = item.LecturerName;
				lblLecturerName.TextAlign = ContentAlignment.MiddleCenter;
				lblLecturerName.Dock = DockStyle.Top;
				lblLecturerName.ForeColor = labelTextColor;
				lblLecturerName.Font = labelextFontStyle;

				Label lblSubjectDay = new Label();
				if ((int)cbxDays.SelectedValue == 0)
				{
					holderPanel.Height = 111;
					lblSubjectDay.Text = item.SubjectDay;
					lblSubjectDay.TextAlign = ContentAlignment.MiddleCenter;
					lblSubjectDay.Dock = DockStyle.Top;
					lblSubjectDay.ForeColor = labelTextColor;
					lblSubjectDay.Font = labelextFontStyle;
				}
				holderPanel.Height = 90;
				Label lblSubjectTime = new Label();
				lblSubjectTime.Text = item.StartEndTime;
				lblSubjectTime.TextAlign = ContentAlignment.MiddleCenter;
				lblSubjectTime.Dock = DockStyle.Top;
				lblSubjectTime.ForeColor = labelTextColor;
				lblSubjectTime.Font = labelextFontStyle;

				Label lblClassRoom = new Label();
				lblClassRoom.Text = item.ClassRoomName;
				lblClassRoom.TextAlign = ContentAlignment.MiddleCenter;
				lblClassRoom.Dock = DockStyle.Top;
				lblClassRoom.ForeColor = labelTextColor;
				lblClassRoom.Font = labelextFontStyle;

				topPanel.Controls.Add(lblSubjectName);
				holderPanel.Controls.Add(lblClassRoom);
				holderPanel.Controls.Add(lblSubjectTime);
				if((int)cbxDays.SelectedValue == 0) 
					holderPanel.Controls.Add(lblSubjectDay);
				holderPanel.Controls.Add(lblLecturerName);
				holderPanel.Controls.Add(topPanel);

				flpTimeTable.Controls.Add(holderPanel);
			}
		}
		private void cbxDays_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			PopulateFlpTimeTable();
		}
	}
}
