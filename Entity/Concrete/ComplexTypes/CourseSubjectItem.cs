using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class CourseSubjectItem
	{
		public int CourseSubjectID { get; set; }
		public int CourseID { get; set; }
		public int SubjectID { get; set; }
		public string CourseName { get; set; }
		public string SubjectName { get; set; }
	}
}
