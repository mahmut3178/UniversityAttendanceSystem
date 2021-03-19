using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class CourseSubject:IEntity
	{
		public int CourseSubjectID { get; set; }
		public int CourseID { get; set; }
		public int SubjectID { get; set; }
	}
}
