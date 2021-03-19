using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class StudentAttendance : IEntity
	{
		public int StudentAttendanceID { get; set; }
		public string StudentID { get; set; }
		public string IntakeID { get; set; }
		public int SubjectID { get; set; }
		public string LecturerID { get; set; }
		public int PresenceStatusID { get; set; }
		public int DayOfWeek { get; set; }
		public int WeekOfYear { get;set; }
		public DateTime Date { get; set; }
	}
}
