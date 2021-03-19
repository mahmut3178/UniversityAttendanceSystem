using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IStudentAttendanceService
	{
		List<StudentAttendance> GetAll();
		StudentAttendance Insert(StudentAttendance entity);
		StudentAttendance Delete(StudentAttendance entity);
		StudentAttendance Update(StudentAttendance entity);
		bool PublishNewStudentAttendance(List<StudentAttendance> entity);
		List<LecturerStudentAttendanceItem> GetLecturerStudentAttendance(string LecturerID, string IntakeID, int SubjectID, int DayOfWeek, int WeekOfYear);
		StudentAttendanceItem GetStudentAttendance(StudentAttendanceParameter parameter);

		bool UpdateStudentAttendanceByStudentCardID(string CardID);
		StudentAttendance GetStudentAttendanceItem(string studentID, int subjectID, DateTime date);


	}
}
