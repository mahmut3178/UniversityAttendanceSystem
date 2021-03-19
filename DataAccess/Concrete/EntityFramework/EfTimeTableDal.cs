using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfTimeTableDal : EfEntityRepositoryBase<TimeTable, ApuAttendanceContext>, ITimeTableDal
	{
		public List<TimeTableItem> GetListTimeTable(string intakeID, string lecturerID, int dayOfWeek)
		{
			using (var context = new ApuAttendanceContext())
			{
				var timeTableItem = from tt in context.TimeTables
									join
	  i in context.Intakes on tt.IntakeID equals i.IntakeID
									join l in context.Lecturers on tt.LecturerID equals l.LecturerID
									join s in context.Subjects on tt.SubjectID equals s.SubjectID
									join cr in context.ClassRooms on tt.ClassRoomID equals cr.ClassRoomID
									where (intakeID.Equals("Select Intake") ? 0 != 1 : tt.IntakeID.Equals(intakeID))
									&& (lecturerID.Equals("Select Lecturer") ? 0 != 1 : tt.LecturerID.Equals(lecturerID))
									&& (dayOfWeek == 0 ? 0 != 1 : tt.SubjectDay == dayOfWeek)
									orderby tt.SubjectTime
									select new TimeTableItem
									{
										TimeTableID = tt.TimeTableID,
										Intake = i.IntakeID,
										LecturerID = l.LecturerID,
										LecturerName = l.FirstName + " " + l.MiddleName + " " + l.LastName,
										SubjectID = s.SubjectID,
										SubjectName = s.SubjectName,
										ClassRoomID = cr.ClassRoomID,
										ClassRoomName = cr.ClassRoomName,
										SubjectDayID = tt.SubjectDay,
										SubjectDay = ((DayOfWeek)tt.SubjectDay).ToString(),
										SubjectTime = tt.SubjectTime,
										SubjectDuration = tt.SubjectDuration
									};
				return timeTableItem.ToList();
			}
		}

		public List<TimeTableItem> GetTimeTableByValidatingLecturerTime(TimeTable entity)
		{
			using (var context = new ApuAttendanceContext())
			{
				var timeTables = from tt in context.TimeTables
								 where tt.LecturerID == entity.LecturerID && tt.SubjectDay == entity.SubjectDay
								 select new TimeTableItem
								 {
									 TimeTableID = tt.TimeTableID,
									 Intake = tt.IntakeID,
									 LecturerID = tt.LecturerID,
									 SubjectID = tt.SubjectID,
									 SubjectDayID = tt.SubjectDay,
									 SubjectTime = tt.SubjectTime,
									 SubjectDuration = tt.SubjectDuration
								 };
				return timeTables.ToList();
			}
		}
		public List<TimeTableItem> GetTimeTableByValidatingIntakeTime(TimeTable entity)
		{
			using (var context = new ApuAttendanceContext())
			{
				var timeTables = from tt in context.TimeTables
								 where tt.IntakeID == entity.IntakeID && tt.SubjectDay == entity.SubjectDay
								 select new TimeTableItem
								 {
									 TimeTableID = tt.TimeTableID,
									 Intake = tt.IntakeID,
									 LecturerID = tt.LecturerID,
									 SubjectID = tt.SubjectID,
									 SubjectDayID = tt.SubjectDay,
									 SubjectTime = tt.SubjectTime,
									 SubjectDuration = tt.SubjectDuration
								 };
				return timeTables.ToList();
			}
		}
		public List<TimeTableItem> GetTimeTableByValidatingClassTime(TimeTable entity)
		{
			using (var context = new ApuAttendanceContext())
			{
				var timeTables = from tt in context.TimeTables
								 where tt.ClassRoomID == entity.ClassRoomID && tt.SubjectDay == entity.SubjectDay
								 select new TimeTableItem
								 {
									 TimeTableID = tt.TimeTableID,
									 Intake = tt.IntakeID,
									 LecturerID = tt.LecturerID,
									 SubjectID = tt.SubjectID,
									 SubjectDayID = tt.SubjectDay,
									 SubjectTime = tt.SubjectTime,
									 SubjectDuration = tt.SubjectDuration
								 };
				return timeTables.ToList();
			}
		}

		public List<TimeTableItem> GetStudentTimeTable(string studentID, int weekOfDay)
		{
			using (var context = new ApuAttendanceContext())
			{
				var timeTableItem = from s in context.Students
									join si in context.StudentIntakes on s.StudentID equals si.StudentID
									join tt in context.TimeTables on si.IntakeID equals tt.IntakeID
									join l in context.Lecturers on tt.LecturerID equals l.LecturerID
									join sbj in context.Subjects on tt.SubjectID equals sbj.SubjectID
									join cr in context.ClassRooms on tt.ClassRoomID equals cr.ClassRoomID
									where si.IsStudentIntakeActive == true && s.StudentID.Equals(studentID) && weekOfDay == 0 ? 0 == 0 : tt.SubjectDay == weekOfDay
									select new TimeTableItem
									{
										SubjectName = sbj.SubjectName,
										LecturerName = l.FirstName + " " + l.MiddleName + " " + l.LastName,
										SubjectDayID = tt.SubjectDay,
										SubjectDay = ((DayOfWeek)tt.SubjectDay).ToString(),
										SubjectTime = tt.SubjectTime,
										SubjectDuration = tt.SubjectDuration,
										ClassRoomName = cr.ClassRoomName
									};
				return timeTableItem.Distinct().ToList();
			}
		}

		public List<LecturerTimeTableItem> GetPastClasses(string lecturerID)
		{
			using (var context = new ApuAttendanceContext())
			{
				var groupByTimeTableItem = from sa in context.StudentAttendances
										   where sa.LecturerID.Equals(lecturerID)
										   group sa by new
										   {
											   sa.LecturerID,
											   sa.IntakeID,
											   sa.SubjectID,
											   sa.WeekOfYear,
											   sa.DayOfWeek,
											   sa.Date
										   } into g
										   join sbj in context.Subjects on g.Key.SubjectID equals sbj.SubjectID
										   orderby g.Key.Date ascending
										   select new LecturerTimeTableItem
										   {
											   IntakeID = g.Key.IntakeID,
											   SubjectID = g.Key.SubjectID,
											   WeekOfYear = g.Key.WeekOfYear,
											   Date = g.Key.Date,
											   SubjectDayID = g.Key.DayOfWeek,
											   SubjectName = sbj.SubjectName,
											   SubjectDay = ((DayOfWeek)g.Key.DayOfWeek).ToString()
										   };

				var result = groupByTimeTableItem.ToArray().Select(x =>
				new LecturerTimeTableItem
				{
					IntakeID = x.IntakeID,
					SubjectID = x.SubjectID,
					WeekOfYear = x.WeekOfYear,
					Date = x.Date,
					SubjectDayID = x.SubjectDayID,
					SubjectName = x.SubjectName,
					SubjectDay = x.SubjectDay,
					ClassDetails = x.IntakeID + "|" + x.SubjectName + "|" + x.SubjectDay+ "|" + x.Date.ToString("dd-MM-yyyy")
				}
				);
				return result.ToList();
			}
		}

	}
}
