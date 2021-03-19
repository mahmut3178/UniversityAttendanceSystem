using Business.Abstract;
using Business.Exceptions;
using DataAccess.Abstract;
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
	public class CourseSubjectManager:ICourseSubjectService
	{
		ICourseSubjectDal _courseSubjectDal;

		public CourseSubjectManager(ICourseSubjectDal courseSubjectDal)
		{
			_courseSubjectDal = courseSubjectDal;
		}

		public CourseSubject Delete(CourseSubject entity)
		{
			return _courseSubjectDal.Delete(entity);
		}

		public List<CourseSubject> GetAll()
		{
			return _courseSubjectDal.GetList();
		}

		public List<CourseSubjectItem> GetCourseSubjects(int courseID)
		{
			return _courseSubjectDal.GetCourseSubjects(courseID);
		}

		public List<CourseSubjectItem> GetStudentCourseByStudentID(string studentID)
		{
			return _courseSubjectDal.GetStudentCourseByStudentID(studentID);
		}

		public CourseSubject Insert(CourseSubject entity)
		{
			var isExist = _courseSubjectDal.Get(x=>x.CourseID == entity.CourseID && x.SubjectID == entity.SubjectID);
			if (isExist != null)
				throw new DataExistException("This Subject already exists in the selected course.");
			return _courseSubjectDal.Insert(entity);
		}

		public CourseSubject Update(CourseSubject entity)
		{
			throw new NotImplementedException();
		}
	}
}
