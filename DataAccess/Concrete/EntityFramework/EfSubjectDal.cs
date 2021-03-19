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
	public class EfSubjectDal : EfEntityRepositoryBase<Subject, ApuAttendanceContext>, ISubjectDal
	{
		public List<IntakeSubjectItem> GetIntakeSubjects(string intakeID)
		{
			using (var context = new ApuAttendanceContext())
			{
				var subject = from ic in context.IntakeCourses
							  join
cs in context.CourseSubjects on ic.CourseID equals cs.CourseID
							  join s in context.Subjects on cs.SubjectID equals s.SubjectID
							  where ic.IntakeID.Equals(intakeID)
							  select new IntakeSubjectItem { SubjectID = s.SubjectID, SubjectName = s.SubjectName };
				return subject.ToList();
			}
		}


	}
}
