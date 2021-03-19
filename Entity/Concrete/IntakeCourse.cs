using Entity.Abstract;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class IntakeCourse:IEntity
	{
		public int IntakeCourseID { get; set; }
		public string IntakeID { get; set; }
		public int CourseID { get; set; }
		public bool IsIntakeCourseActive { get; set; }
	}
}
