using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IUserDal:IEntityRepository<User>
	{
		List<LecturerItem> GetLecturerByIDAndName(string key);
		List<StudentItem> GetStudentByIDAndName(string key);
	}
}
