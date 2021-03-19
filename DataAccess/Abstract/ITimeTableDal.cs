using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ITimeTableDal:IEntityRepository<TimeTable>
	{
		List<TimeTableItem> GetListTimeTable(string intakeID, string lecturerID, int dayOfWeek);
		List<TimeTableItem> GetTimeTableByValidatingLecturerTime(TimeTable entity);
		List<TimeTableItem> GetTimeTableByValidatingIntakeTime(TimeTable entity);
		List<TimeTableItem> GetTimeTableByValidatingClassTime(TimeTable entity);
		List<TimeTableItem> GetStudentTimeTable(string studentID, int WeekOfDay);
		List<LecturerTimeTableItem> GetPastClasses(string lecturerID);
	}
}
