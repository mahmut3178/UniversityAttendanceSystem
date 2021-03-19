using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes.ParameterItems
{
	public struct StudentQueryItem
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int UserTypeID { get; set; }
		public string StudentID { get; set; }
		public string StudentFirstName { get; set; }
		public string StudentMiddleName { get; set; }
		public string StudentLastName { get; set; }
		public DateTime StudentBirthDate { get; set; }
		public string StudentEmail { get; set; }
		public byte[] Photo { get; set; }
		public int StudentIntakeID { get; set; }
		public string IntakeID { get; set; }
		public DateTime IntakeCreatedDate { get; set; }
		public bool IsStudentIntakeActive { get; set; }
	}
}
