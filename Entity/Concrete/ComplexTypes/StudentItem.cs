using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class StudentItem
	{
		public int UserID { get; set; }
		public int StudentIntakeID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string StudentID { get; set; }
		public string StudentFirstName { get; set; }
		public string StudentMiddleName { get; set; }
		public string StudentLastName { get; set; }
		public string Intake { get; set; }
		public DateTime StudentBirthDate { get; set; }
		public string StudentEmail { get; set; }
		public Byte[] Photo { get; set; }
	}
}
