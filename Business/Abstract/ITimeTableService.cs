using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ITimeTableService
	{
		List<TimeTable> GetAll();
		TimeTable Insert(TimeTable entity);
		TimeTable Delete(TimeTable entity);
		TimeTable Update(TimeTable entity);
		TimeTable GetTimeTableByID(int timeTableID);
		void InactivateLecturer(TimeTable entity);
		List<TimeTableItem> GetListTimeTable(string intakeID, string lecturerID, int dayOfWeek);
		List<TimeTableItem> GetStudentTimeTable(string studentID, int WeekOfDay);
		List<LecturerTimeTableItem> GetPastClasses(string lecturerID);
	}
}
