using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class StudentManager : IStudentService
	{
		IStudentDal _studentDal;

		public StudentManager(IStudentDal studentDal)
		{
			_studentDal = studentDal;
		}

		public Student Delete(Student entity)
		{
			return _studentDal.Delete(entity);
		}

		public List<Student> GetAll()
		{
			return _studentDal.GetList();
		}

		public Student GetStudentByID(Student student)
		{
			return _studentDal.Get(x => x.StudentID.Equals(student.StudentID));
		}

		public void InactivateStudent(Student entity)
		{
			throw new NotImplementedException();
		}

		public Student Insert(Student entity)
		{
			return _studentDal.Insert(entity);
		}

		public void InsertStudent(StudentQueryItem studentItem)
		{
			User user = new User { UserName = studentItem.UserName, Password = studentItem.Password, UserTypeID = studentItem.UserTypeID };
			Student student = new Student
			{
				StudentID = studentItem.StudentID,
				StudentFirstName = studentItem.StudentFirstName,
				StudentMiddleName = studentItem.StudentMiddleName,
				StudentLastName = studentItem.StudentLastName,
				StudentBirthDate = studentItem.StudentBirthDate,
				StudentEmail = studentItem.StudentEmail,
				Photo = studentItem.Photo
			};
			StudentIntake studentIntake = new StudentIntake { StudentID = studentItem.StudentID, IntakeID = studentItem.IntakeID, IsStudentIntakeActive = studentItem.IsStudentIntakeActive };

			_studentDal.InsertStudent(user, student, studentIntake);
		}

		public Student Update(Student entity)
		{
			return _studentDal.Update(entity);
		}
	}
}
