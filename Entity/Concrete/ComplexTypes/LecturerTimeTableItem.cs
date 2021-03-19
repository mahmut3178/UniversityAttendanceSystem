using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class LecturerTimeTableItem
	{
		public int TimeTableID { get; set; }
		public string IntakeID { get; set; }
		public int SubjectID { get; set; }
		public string SubjectName { get; set; }
		public int SubjectDayID { get; set; }
		public string SubjectDay { get; set; }
		public TimeSpan SubjectTime { get; set; }
		private DateTime _date;
		public DateTime Date { get { return _date; } set { _date = Convert.ToDateTime(value.ToString("MM/dd/yyyy")); } }
		public int WeekOfYear { get; set; }
		public string ClassDetails { get; set; }
		public string ClassDetails2 { get; set; }
	}
}
