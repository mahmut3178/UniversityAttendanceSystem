using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class IntakeCourseItem
	{
		public int IntakeCourseID { get; set; }
		public string Intake{ get; set; }
		public int CourseID { get; set; }
		public string Course{ get; set; }
	}
}
