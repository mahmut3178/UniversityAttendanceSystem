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
	public class StudentIntakeManager:IStudentIntakeService
	{
		IStudentIntakeDal _studentIntakeDal;

		public StudentIntakeManager(IStudentIntakeDal studentIntakeDal)
		{
			_studentIntakeDal = studentIntakeDal;
		}

		public StudentIntake Delete(StudentIntake entity)
		{
			return _studentIntakeDal.Delete(entity);
		}

		public List<StudentIntake> GetAll()
		{
			return _studentIntakeDal.GetList();
		}

		public List<StudentIntake> GetAllIntakeByStudentID(Student entity)
		{
			return _studentIntakeDal.GetList(x => x.StudentID == entity.StudentID).OrderByDescending(x => x.IntakeCreatedDate).ToList();
		}

		public StudentIntake GetIntakeByStudentID(Student entity)
		{
			return _studentIntakeDal.GetList(x => x.StudentID == entity.StudentID).OrderByDescending(x => x.IntakeCreatedDate).FirstOrDefault();
		}

		public void InactivateStudentIntake(StudentIntake entity)
		{
			throw new NotImplementedException();
		}

		public StudentIntake Insert(StudentIntake entity)
		{
			return _studentIntakeDal.Insert(entity);
		}

		public StudentIntake Update(StudentIntake entity)
		{
			return _studentIntakeDal.Update(entity);
		}
	}
}
