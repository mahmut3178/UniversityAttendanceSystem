using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IStudentAttendanceDal:IEntityRepository<StudentAttendance>
	{
		List<LecturerStudentAttendanceItem> GetLecturerStudentAttendance();
		List<LecturerStudentAttendanceItem> GetLecturerNewStudentAttendance(string LecturerID, string IntakeID, int SubjectID, int DayOfWeek, int WeekOfYear);
		List<StudentAttendanceItem> GetStudentAttendace(StudentAttendanceParameter parameter);
		List<StudentTimeTableItem> AttendanceByStudentCardID(string cardID);
	}
}
