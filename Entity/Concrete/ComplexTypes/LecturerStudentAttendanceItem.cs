using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class LecturerStudentAttendanceItem
	{
		public int StudentAttendanceID { get; set; }
		public string IntakeID { get; set; }
		public string StudentID { get; set; }
		public int SubjectID { get; set; }
		public string StudentFullName { get; set; }
		public string LecturerID { get; set; }
		public string LecturerFullName { get; set; }
		public int PresenceStatusID { get; set; }
		public string PresenceStatus { get; set; }
		public int DayOfWeek { get; set; }
		public int WeekOfyear { get; set; }
		public DateTime Date { get; set; }
	}
}
