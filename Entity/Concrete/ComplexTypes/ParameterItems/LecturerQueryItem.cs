using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.ComplexTypes.ParameterItems
{
	public struct LecturerQueryItem
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int UserTypeID { get; set; }
		public string LecturerID { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Phone { get; set; }
		public string Address { get; set; }
		public byte[] Photo { get; set; }
	}
}
