using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IStudentIntakeService
	{
		List<StudentIntake> GetAll();
		StudentIntake Insert(StudentIntake entity);
		StudentIntake Delete(StudentIntake entity);
		StudentIntake Update(StudentIntake entity);
		StudentIntake GetIntakeByStudentID(Student entity);
		List<StudentIntake>GetAllIntakeByStudentID(Student entity);
		void InactivateStudentIntake(StudentIntake entity);
	}
}
