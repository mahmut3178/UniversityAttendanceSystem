using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfStudentAttendanceDal : EfEntityRepositoryBase<StudentAttendance, ApuAttendanceContext>, IStudentAttendanceDal
	{
		public List<LecturerStudentAttendanceItem> GetLecturerStudentAttendance()
		{
			using (var context = new ApuAttendanceContext())
			{
				var lecturerStudentAttendanceItem = from sa in context.StudentAttendances
													join s in context.Students on sa.StudentID equals s.StudentID
													join l in context.Lecturers on sa.LecturerID equals l.LecturerID
													join sbj in context.Subjects on sa.SubjectID equals sbj.SubjectID
													select new LecturerStudentAttendanceItem
													{
														StudentAttendanceID = sa.StudentAttendanceID,
														IntakeID = sa.IntakeID,
														StudentID = sa.StudentID,
														StudentFullName = s.StudentFirstName + " " + (String.IsNullOrEmpty(s.StudentMiddleName) ? "" : s.StudentMiddleName + " ") + s.StudentLastName,
														LecturerID = l.LecturerID,
														LecturerFullName = l.FirstName + " " + (String.IsNullOrEmpty(l.MiddleName) ? "" : l.MiddleName + " ") + l.LastName,
														PresenceStatusID = sa.PresenceStatusID,
														SubjectID = sbj.SubjectID,
														DayOfWeek = sa.DayOfWeek,
														WeekOfyear = sa.WeekOfYear,
														Date = sa.Date
													};
				return lecturerStudentAttendanceItem.ToList();

			}
		}

		public List<LecturerStudentAttendanceItem> GetLecturerNewStudentAttendance(string LecturerID, string IntakeID, int SubjectID, int DayOfWeek, int WeekOfYear)
		{
			using (var context = new ApuAttendanceContext())
			{
				var lecturerStudentAttendanceItem = from s in context.Students
													join si in context.StudentIntakes on s.StudentID equals si.StudentID
													where si.IntakeID.Equals(IntakeID)
													select new LecturerStudentAttendanceItem
													{
														IntakeID = IntakeID,
														StudentID = s.StudentID,
														SubjectID = SubjectID,
														StudentFullName = s.StudentFirstName + " " + (String.IsNullOrEmpty(s.StudentMiddleName) ? "" : s.StudentMiddleName + " ") + s.StudentLastName,
														LecturerID = LecturerID,
														PresenceStatusID = 0,
														DayOfWeek = DayOfWeek,
														WeekOfyear = WeekOfYear
													};
				return lecturerStudentAttendanceItem.ToList();
			}
		}


		public List<StudentAttendanceItem> GetStudentAttendace(StudentAttendanceParameter parameter)
		{
			using (var context = new ApuAttendanceContext())
			{
				var studentAttendanceItem = from sa in context.StudentAttendances
											join
	  sbj in context.Subjects on sa.SubjectID equals sbj.SubjectID
											join l in context.Lecturers on sa.LecturerID equals l.LecturerID
											where sa.IntakeID == parameter.IntakeID && sa.SubjectID == parameter.SubjectID && sa.StudentID == parameter.StudentID
											select new StudentAttendanceItem
											{
												SubjectName = sbj.SubjectName,
												LecturerName = l.FirstName + " " + (String.IsNullOrEmpty(l.MiddleName) ? "" : l.MiddleName + " ") + l.LastName,
												presenceStatus = sa.PresenceStatusID

											};
				return studentAttendanceItem.ToList();
			}
		}

		public List<StudentTimeTableItem> AttendanceByStudentCardID(string cardID)
		{
			using (var context = new ApuAttendanceContext())
			{
				var listOfStudentTimeTable = from s in context.Students
											 join
				  si in context.StudentIntakes on s.StudentID equals si.StudentID
											 join tt in context.TimeTables on si.IntakeID equals tt.IntakeID
											 where s.StudentCardID == cardID
											 select new StudentTimeTableItem
											 {
												 TimeTableID = tt.TimeTableID,
												 StudentID = s.StudentID,
												 IntakeID = tt.IntakeID,
												 LecturerID = tt.LecturerID, 
												 SubjectID = tt.SubjectID,
												 ClassRoomID = tt.ClassRoomID, 
												 SubjectDay = tt.SubjectDay,
												 SubjectTime = tt.SubjectTime,
												 SubjectDuration = tt.SubjectDuration, 
											 };
				return listOfStudentTimeTable.ToList();
			}
		}

		
	}
}