using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfClassRoomDal:EfEntityRepositoryBase<ClassRoom, ApuAttendanceContext>, IClassRoomDal
	{
		public List<LecturerTimeTableItem> GetLecturerTimeTable(string LecturerID)
		{

			using (var context = new ApuAttendanceContext())
			{
				var lecturerTimeTableItem = from tt in context.TimeTables
											join
			  s in context.Subjects on tt.SubjectID equals s.SubjectID
											join
											cr in context.ClassRooms on tt.ClassRoomID equals cr.ClassRoomID
											where tt.LecturerID.Equals(LecturerID)
											select new LecturerTimeTableItem
											{
												TimeTableID = tt.TimeTableID,
												IntakeID = tt.IntakeID,
												SubjectID = tt.SubjectID,
												SubjectName = s.SubjectName,
												SubjectDayID = tt.SubjectDay,
												SubjectDay = ((DayOfWeek)tt.SubjectDay).ToString(),
												SubjectTime = tt.SubjectTime,
												ClassDetails = tt.IntakeID + " | " + s.SubjectName + " | " + tt.SubjectTime + " | " + cr.ClassRoomName,
												ClassDetails2 = ((DayOfWeek)tt.SubjectDay).ToString() + " | " + tt.IntakeID + " | " + s.SubjectName + " | " + tt.SubjectTime + " | " + cr.ClassRoomName
											};

			return lecturerTimeTableItem.ToList();
			}
		}

	}
}
