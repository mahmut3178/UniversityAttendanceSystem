using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class Intake:IEntity
	{
		public string IntakeID { get; set; }
		public bool IsIntakeActive { get; set; }
	}
}
