using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PresenceStatusManager:IPresenceStatusService
	{
		IPresenceStatusDal _presenceStatusDal;
		public PresenceStatusManager(IPresenceStatusDal presenceStatusDal)
		{
			_presenceStatusDal = presenceStatusDal;
		}

		public PresenceStatus Delete(PresenceStatus entity)
		{
			throw new NotImplementedException();
		}

		public List<PresenceStatus> GetAll()
		{
			return _presenceStatusDal.GetList();
		}
				
		public PresenceStatus Insert(PresenceStatus entity)
		{
			throw new NotImplementedException();
		}

		public PresenceStatus Update(PresenceStatus entity)
		{
			throw new NotImplementedException();
		}
	}
}
