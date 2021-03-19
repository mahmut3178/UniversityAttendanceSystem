using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICourseSubjectService
	{
		List<CourseSubject> GetAll();
		CourseSubject Insert(CourseSubject entity);
		CourseSubject Update(CourseSubject entity);
		CourseSubject Delete(CourseSubject entity);
		List<CourseSubjectItem> GetCourseSubjects(int courseID);
		List<CourseSubjectItem> GetStudentCourseByStudentID(string studentID);
	}
}
