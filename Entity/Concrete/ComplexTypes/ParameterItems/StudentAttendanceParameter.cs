using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes.ParameterItems
{
	public struct StudentAttendanceParameter
	{
		public int SubjectID { get; set; }
		public string StudentID { get; set; }
		public string IntakeID { get; set; }
	}

	public struct StudentAttendanceParameterWithDate
	{
		public int SubjectID { get; set; }
		public string StudentID { get; set; }
		public string IntakeID { get; set; }
		public DateTime Date { get; set; }
	}

}
