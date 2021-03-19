using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Student:IEntity
	{
		public string StudentID { get; set; }
		public string StudentCardID { get; set; }
		public string StudentFirstName { get; set; }
		public string StudentMiddleName { get; set; }
		public string StudentLastName { get; set; }
		public DateTime StudentBirthDate { get; set; }
		public string StudentEmail { get; set; }
		public byte[] Photo { get; set; }
	}
}
