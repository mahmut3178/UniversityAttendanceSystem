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
	public interface IIntakeCourseService
	{
		List<IntakeCourse> GetAll();
		IntakeCourse Insert(IntakeCourse entity);
		IntakeCourse Update(IntakeCourse entity);
		IntakeCourse Delete(IntakeCourse entity);
		List<IntakeCourseItem> GetIntakeCourses(string key);
		void InActivateIntakeCourse(IntakeCourse entity);
	}
}
