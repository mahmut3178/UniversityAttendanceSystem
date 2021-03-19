using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class StudentAttendanceItem
	{
		public string SubjectName { get; set; }
		public string LecturerName { get; set; }
		public int Present{ get; set; }
		public int Absent { get; set; }
		public int presenceStatus { get; set; }
		public int AbsentWithReason { get; set; }
		public string Attendance { get; set; }
		public bool isAttendancePassed { get; set; }
	}
}
