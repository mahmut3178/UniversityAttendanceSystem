using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class StudentTimeTableItem
	{
		public int TimeTableID { get; set; }
		public string StudentID { get; set; }
		public string IntakeID { get; set; }
		public string LecturerID { get; set; }
		public int SubjectID { get; set; }
		public int ClassRoomID { get; set; }
		public int SubjectDay { get; set; }
		public TimeSpan SubjectTime { get; set; }
		public int SubjectDuration { get; set; }
	}
}
