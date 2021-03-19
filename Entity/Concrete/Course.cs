using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Course:IEntity
	{
		public int CourseID { get; set; }
		public string CourseName { get; set; }
		public bool IsCourseActive { get; set; }
	}
}
