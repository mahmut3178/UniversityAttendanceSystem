using Business.Abstract;
using Business.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Business.Concrete
{
	public class StudentAttendanceManager : IStudentAttendanceService
	{
		IStudentAttendanceDal _studentAttendanceDal;

		public StudentAttendanceManager(IStudentAttendanceDal studentAttendanceDAl)
		{
			_studentAttendanceDal = studentAttendanceDAl;
		}
		public StudentAttendance Delete(StudentAttendance entity)
		{
			throw new NotImplementedException();
		}

		public List<StudentAttendance> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<LecturerStudentAttendanceItem> GetLecturerStudentAttendance(string LecturerID, string intakeID, int subjectID, int dayOfWeek, int weekOfYear)
		{
			var freshStudentAttendanceItem = _studentAttendanceDal.GetLecturerNewStudentAttendance(LecturerID, intakeID, subjectID, dayOfWeek, weekOfYear);
			var freshStudentAttendanceReturnItem = _studentAttendanceDal.GetLecturerNewStudentAttendance(LecturerID, intakeID, subjectID, dayOfWeek, weekOfYear);
			var attendanceitemlist = _studentAttendanceDal.GetLecturerStudentAttendance().Where(x => x.IntakeID.Equals(intakeID)
			&& x.SubjectID.Equals(subjectID) && x.DayOfWeek.Equals(dayOfWeek) && x.WeekOfyear.Equals(weekOfYear)).ToList();
			if (attendanceitemlist.Count > 0)
			{
				string[] studentIDs = attendanceitemlist.Select(x => x.StudentID).ToArray();

				foreach (var item in freshStudentAttendanceItem.Where(x => studentIDs.Contains(x.StudentID)))
				{

					freshStudentAttendanceReturnItem.Remove(freshStudentAttendanceReturnItem.FirstOrDefault(x => x.StudentID.Equals(item.StudentID)));
				}
				attendanceitemlist.ForEach(x =>
				{
					x.PresenceStatus = x.PresenceStatusID.ToString();
					freshStudentAttendanceReturnItem.Add(x);
				}
				);
			}
			return freshStudentAttendanceReturnItem;
		}
		public bool PublishNewStudentAttendance(List<StudentAttendance> studentAttendances)
		{
			using (var ts = new TransactionScope())
			{
				try
				{
					foreach (var item in studentAttendances)
					{

						var isExistItem = _studentAttendanceDal.GetList(x => x.StudentID.Equals(item.StudentID) && x.IntakeID.Equals(item.IntakeID) && x.LecturerID.Equals(item.LecturerID) && x.SubjectID == item.SubjectID
						&& x.DayOfWeek == item.DayOfWeek && x.WeekOfYear == item.WeekOfYear);

						if (isExistItem.Count == 0)
						{
							_studentAttendanceDal.Insert(item);
						}
						else
						{
							_studentAttendanceDal.Update(item);
						}
					}
				}
				catch (Exception)
				{
					ts.Dispose();
					throw new Exception("Something Went Wrong!");
				}

				ts.Complete();
			}

			return true;

		}
		public StudentAttendanceItem GetStudentAttendance(StudentAttendanceParameter parameter)
		{
			if (parameter.IntakeID.Equals("Select Intake"))
				return null;
			StudentAttendanceItem studentAttendance = new StudentAttendanceItem();
			int presentTimes = 0;
			int absentTimes = 0;
			int totalClasses = 0;
			var studentAttendanceItem = _studentAttendanceDal.GetStudentAttendace(parameter);
			if (studentAttendanceItem.Count == 0)
				return null;
			presentTimes = studentAttendanceItem.ToList().Where(x => x.presenceStatus == 1).Count();
			absentTimes += studentAttendanceItem.ToList().Where(x => x.presenceStatus == 2).Count();
			absentTimes += studentAttendanceItem.ToList().Where(x => x.presenceStatus == 3).Count();
			totalClasses = presentTimes + absentTimes;
			double percentage = 0;

			if (presentTimes != 0)
				percentage = ((double)presentTimes / (double)totalClasses) * 100;
			else
				percentage = 0;

			if (percentage < 80)
				studentAttendance.isAttendancePassed = true;
			else
				studentAttendance.isAttendancePassed = false;

			studentAttendance.Attendance = percentage.ToString("0.##")+ "%" + "(" + presentTimes + "/" + totalClasses + ")";
			studentAttendance.LecturerName = studentAttendanceItem[0].LecturerName;
			studentAttendance.SubjectName = studentAttendanceItem[0].SubjectName;

			return studentAttendance;
		}

		public StudentAttendance Insert(StudentAttendance entity)
		{
			throw new NotImplementedException();
		}


		public StudentAttendance Update(StudentAttendance entity)
		{
			throw new NotImplementedException();
		}

		public bool UpdateStudentAttendanceByStudentCardID(string cardID)
		{
			List<StudentTimeTableItem> timeTables = _studentAttendanceDal.AttendanceByStudentCardID(cardID);

			foreach (var item in timeTables)
			{
				TimeSpan entitySubjectDuration = TimeSpan.FromMinutes(item.SubjectDuration);
				TimeSpan entitySubjectTime = item.SubjectTime;
				TimeSpan timeTableSubjectTimeAddSubjectDuration = entitySubjectTime.Add(entitySubjectDuration);
				if (Convert.ToInt32(DateTime.Now.DayOfWeek) == item.SubjectDay && (DateTime.Now.TimeOfDay >= item.SubjectTime && DateTime.Now.TimeOfDay <= timeTableSubjectTimeAddSubjectDuration))
				{
					var studentAttendanceExists = GetStudentAttendanceItem(item.StudentID, item.SubjectID, DateTime.Now.Date);
					if (studentAttendanceExists != null)
					{
						studentAttendanceExists.PresenceStatusID = 1;
						_studentAttendanceDal.Update(studentAttendanceExists);
					}
					else
					{
						_studentAttendanceDal.Insert(new StudentAttendance
						{
							StudentID = item.StudentID,
							IntakeID = item.IntakeID,
							SubjectID = item.SubjectID,
							LecturerID = item.LecturerID,
							PresenceStatusID = 1,
							DayOfWeek = Convert.ToInt32(DateTime.Now.DayOfWeek),
							WeekOfYear = ((DateTime.Now.DayOfYear + 3) / 7),
							Date = DateTime.Now.Date
						});
					}
					return true;
				}
			}

			return false;
		}

		public StudentAttendance GetStudentAttendanceItem(string studentID, int subjectID, DateTime date)
		{
			return _studentAttendanceDal.Get(x => x.StudentID.Equals(studentID) && x.SubjectID == subjectID && x.Date == date.Date);
		}
	}
}
