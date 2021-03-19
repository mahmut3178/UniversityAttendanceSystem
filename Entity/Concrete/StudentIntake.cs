using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class StudentIntake:IEntity
	{
		public int StudentIntakeID { get; set; }
		public string StudentID { get; set; }
		public string IntakeID { get; set; }
		public DateTime IntakeCreatedDate { get; set; }
		public bool IsStudentIntakeActive { get; set; }
	}
}
