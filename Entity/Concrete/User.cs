﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class User:IEntity
	{
		public int UserID { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public int UserTypeID { get; set; }
	}
}
