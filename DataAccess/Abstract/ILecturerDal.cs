using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ILecturerDal : IEntityRepository<Lecturer>
	{
		void InsertLecturer(User user, Lecturer lecturer);
	}
}
