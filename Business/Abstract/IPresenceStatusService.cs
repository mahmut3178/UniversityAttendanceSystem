using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IPresenceStatusService
	{
		List<PresenceStatus> GetAll();
		PresenceStatus Insert(PresenceStatus entity);
		PresenceStatus Delete(PresenceStatus entity);
		PresenceStatus Update(PresenceStatus entity);
	}
}
