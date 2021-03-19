using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class TimeTableItem
	{
		public int TimeTableID { get; set; }
		public string Intake { get; set; }
		public string LecturerID { get; set; }
		public string LecturerName { get; set; }
		public int SubjectID { get; set; }
		public string SubjectName { get; set; }
		public int ClassRoomID { get; set; }
		public string ClassRoomName { get; set; }
		public int SubjectDayID { get; set; }
		public string SubjectDay { get; set; }
		public TimeSpan SubjectTime { get; set; }
		public string StartTime { get; set; }
		public string StartEndTime { get; set; }
		public int SubjectDuration { get; set; }
	}
}
