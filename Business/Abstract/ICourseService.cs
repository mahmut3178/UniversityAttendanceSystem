using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ICourseService
	{
		List<Course> GetAll();
		List<Course> GetByCourse(string key);
		Course Insert(Course entity);
		Course Update(Course entity);
		Course Delete(Course entity);
		void InactivateCourse(Course course);
	}
}
