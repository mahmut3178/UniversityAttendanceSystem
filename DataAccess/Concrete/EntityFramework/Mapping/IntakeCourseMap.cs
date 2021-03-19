using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class IntakeCourseMap : EntityTypeConfiguration<IntakeCourse>
	{
		public IntakeCourseMap()
		{
			ToTable(@"IntakeCourses", @"dbo");
			HasKey(x => x.IntakeCourseID);

			Property(x => x.IntakeCourseID).HasColumnName("IntakeCourseID");
			Property(x => x.IntakeID).HasColumnName("IntakeID");
			Property(x => x.CourseID).HasColumnName("CourseID");
			Property(x => x.IsIntakeCourseActive).HasColumnName("IsIntakeCourseActive");
		}
	}
}
