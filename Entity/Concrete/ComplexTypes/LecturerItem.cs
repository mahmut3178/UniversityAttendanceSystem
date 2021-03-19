using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes
{
	public class LecturerItem
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string LecturerID { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public Byte[] Photo { get; set; }
	}
}
