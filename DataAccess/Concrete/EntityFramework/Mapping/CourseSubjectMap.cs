using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class CourseSubjectMap:EntityTypeConfiguration<CourseSubject>
	{
		public CourseSubjectMap()
		{
			ToTable(@"CourseSubjects", @"dbo");
			HasKey(x => x.CourseSubjectID);

			Property(x => x.CourseSubjectID).HasColumnName("CourseSubjectID");
			Property(x => x.CourseID).HasColumnName("CourseID");
			Property(x => x.SubjectID).HasColumnName("SubjectID");

		}
	}
}
