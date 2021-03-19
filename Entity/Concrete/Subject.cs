using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Subject:IEntity
	{
		public int SubjectID { get; set; }
		public string SubjectName { get; set; }
	}
}
