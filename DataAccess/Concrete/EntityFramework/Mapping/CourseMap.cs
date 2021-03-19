using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class CourseMap : EntityTypeConfiguration<Course>
	{
		public CourseMap()
		{
			ToTable(@"Courses", @"dbo");
			HasKey(x => x.CourseID);

			Property(x => x.CourseID).HasColumnName("CourseID");
			Property(x => x.CourseName).HasColumnName("CourseName");
			Property(x => x.IsCourseActive).HasColumnName("IsCourseActive");
		}
	}
}
