using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class PresenceStatus:IEntity
	{
		public int PresenceStatusID { get; set; }
		public string PresenceStatusName { get; set; }
	}
}
