using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface ICourseSubjectDal:IEntityRepository<CourseSubject>
	{
		List<CourseSubjectItem> GetCourseSubjects(int courseID);
		List<CourseSubjectItem> GetStudentCourseByStudentID(string studentID);
	}
}
