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
	public class SubjectManager : ISubjectService
	{
		ISubjectDal _subjectDal;
		ICourseSubjectService _courseSubjectService = new CourseSubjectManager(new EfCourseSubjectDal());
		public SubjectManager(ISubjectDal subjectDal)
		{
			_subjectDal = subjectDal;
		}

		public Subject Delete(Subject entity)
		{
			var isExist = _courseSubjectService.GetAll().FirstOrDefault(x => x.SubjectID == entity.SubjectID);
			if (isExist != null)
				throw new DataUsedException("This subject is being used by a course hence not removable.");
			return _subjectDal.Delete(entity);
		}

		public List<Subject> GetAll()
		{
			return _subjectDal.GetList();
		}

		public List<Subject> GetBySubject(string key)
		{
			return key == null ? _subjectDal.GetList() : _subjectDal.GetList(x => x.SubjectName.Contains(key));
		}

		public List<IntakeSubjectItem> GetIntakeSubjects(string intakeID)
		{
			return _subjectDal.GetIntakeSubjects(intakeID);
		}

		public Subject Insert(Subject entity)
		{
			ValidatorTool.FluentValidate(new SubjectValidator(), entity);
			var isExist = _subjectDal.Get(x => x.SubjectName == entity.SubjectName);
			if (isExist != null)
				throw new DataExistException("A Subject with the same name already exists.");

			return _subjectDal.Insert(entity);
		}

		public Subject Update(Subject entity)
		{
			ValidatorTool.FluentValidate(new SubjectValidator(), entity);
			return _subjectDal.Update(entity);

		}
	}
}
