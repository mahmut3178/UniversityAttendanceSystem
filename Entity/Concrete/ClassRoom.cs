﻿using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
	public class ClassRoom:IEntity
	{
		public int ClassRoomID { get; set; }
		public string ClassRoomName { get; set; }
	}
}
