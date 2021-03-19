using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfIntakeCourseDal : EfEntityRepositoryBase<IntakeCourse, ApuAttendanceContext>, IIntakeCourseDal
	{

		public List<IntakeCourseItem> GetIntakeCourses(string key)
		{
			using (var context = new ApuAttendanceContext())
			{
				var intakeCourseItem = from ic in context.IntakeCourses
									   join i in context.Intakes on ic.IntakeID equals i.IntakeID
									   join c in context.Courses on ic.CourseID equals c.CourseID
									   where (string.IsNullOrEmpty(key))? ic.IsIntakeCourseActive == true : (i.IntakeID.Contains(key) 
									   || c.CourseName.Contains(key)) && ic.IsIntakeCourseActive == true
									   select new IntakeCourseItem
									   {
										   IntakeCourseID = ic.IntakeCourseID,
										   Intake = i.IntakeID,
										   CourseID = c.CourseID,
										   Course = c.CourseName
									   };

				return intakeCourseItem.ToList();
			}
		}
	}
}
