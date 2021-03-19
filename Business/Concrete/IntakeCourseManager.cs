using Business.Abstract;
using Business.CrossCuttingConcerns.Validations.FluentValidation;
using Business.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class IntakeCourseManager : IIntakeCourseService
	{
		IIntakeCourseDal _intakeCourseDal;

		IStudentIntakeService _studentIntakeService = new StudentIntakeManager(new EfStudentIntakeDal());
		public IntakeCourseManager(IIntakeCourseDal intakeCourseDal)
		{
			_intakeCourseDal = intakeCourseDal;
		}

		public IntakeCourse Delete(IntakeCourse entity)
		{
			throw new NotImplementedException();
		}

		public List<IntakeCourse> GetAll()
		{
			return _intakeCourseDal.GetList();
		}

		public List<IntakeCourseItem> GetIntakeCourses(string key)
		{
			return _intakeCourseDal.GetIntakeCourses(key);
		}

		public void InActivateIntakeCourse(IntakeCourse entity)
		{
			var studentIntake = _studentIntakeService.GetAll().FirstOrDefault(x=>x.IntakeID == entity.IntakeID && x.IsStudentIntakeActive==true);
			if (studentIntake != null)
				throw new DataUsedException("This Intake is being used by some students.");
			entity.IsIntakeCourseActive = false;
			_intakeCourseDal.Update(entity);
		}

		public IntakeCourse Insert(IntakeCourse entity)
		{
			ValidatorTool.FluentValidate(new IntakeCourseValidator(), entity);
			var intakeCourse = _intakeCourseDal.Get(x => (x.IntakeID == entity.IntakeID) ||(x.IntakeID == entity.IntakeID && x.CourseID == entity.CourseID) && x.IsIntakeCourseActive == true);
			if (intakeCourse != null)
			{
				throw new DataExistException("Intake Course Already Exists!");
			}
			return _intakeCourseDal.Insert(entity);
		}

		public IntakeCourse Update(IntakeCourse entity)
		{
			throw new NotImplementedException();
		}
	}
}
