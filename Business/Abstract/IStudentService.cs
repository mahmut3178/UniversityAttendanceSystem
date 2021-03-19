using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IStudentService
	{
		List<Student> GetAll();
		Student Insert(Student entity);
		Student Delete(Student entity);
		Student Update(Student entity);
		void InactivateStudent(Student entity);
		Student GetStudentByID(Student student);
		void InsertStudent(StudentQueryItem studentItem);
	}
}
