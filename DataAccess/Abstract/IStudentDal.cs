using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IStudentDal:IEntityRepository<Student>
	{
		 void InsertStudent(User user, Student student, StudentIntake studentIntake);
	}
}
