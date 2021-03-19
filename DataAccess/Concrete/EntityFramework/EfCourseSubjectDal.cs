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
	public class EfCourseSubjectDal : EfEntityRepositoryBase<CourseSubject, ApuAttendanceContext>, ICourseSubjectDal
	{
		public List<CourseSubjectItem> GetCourseSubjects(int courseID)

		{
			using (var context = new ApuAttendanceContext())
			{
				var courseSubjectItem = from cs in context.CourseSubjects
										join
	  c in context.Courses on cs.CourseID equals c.CourseID
										join s in context.Subjects on cs.SubjectID equals s.SubjectID
										where cs.CourseID == courseID
										select new CourseSubjectItem
										{
											CourseSubjectID = cs.CourseSubjectID,
											CourseID = c.CourseID,
											CourseName = c.CourseName,
											SubjectID = s.SubjectID,
											SubjectName = s.SubjectName
										};
				return courseSubjectItem.ToList();
			}
		}
		public List<CourseSubjectItem> GetStudentCourseByStudentID(string studentID)

		{
			using (var context = new ApuAttendanceContext())
			{
				var courseSubjectItem = from s in context.Students
										join si in context.StudentIntakes on s.StudentID equals si.StudentID
										join ic in context.IntakeCourses on si.IntakeID equals ic.IntakeID
										join cs in context.CourseSubjects on ic.CourseID equals cs.CourseID
										join c in context.Courses on ic.CourseID equals c.CourseID
										join sbj in context.Subjects on cs.SubjectID equals sbj.SubjectID
										where s.StudentID == studentID
										select new CourseSubjectItem {
										CourseSubjectID = cs.CourseSubjectID,
										CourseID = ic.CourseID,
										CourseName = c.CourseName,
										SubjectID = sbj.SubjectID,
										SubjectName = sbj.SubjectName
										};
				return courseSubjectItem.ToList();
			}
		}



	}
}
