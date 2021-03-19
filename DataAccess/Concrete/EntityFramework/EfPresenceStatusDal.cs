﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfPresenceStatusDal:EfEntityRepositoryBase<PresenceStatus, ApuAttendanceContext>, IPresenceStatusDal
	{
	}
}
