using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class StudentIntakeMap : EntityTypeConfiguration<StudentIntake>
	{
		public StudentIntakeMap()
		{
			ToTable(@"StudentIntakes", @"dbo");
			HasKey(x => x.StudentIntakeID);

			Property(x => x.StudentIntakeID).HasColumnName("StudentIntakeID");
			Property(x => x.StudentID).HasColumnName("StudentID");
			Property(x => x.IntakeID).HasColumnName("IntakeID");
			Property(x => x.IntakeCreatedDate).HasColumnName("IntakeCreatedDate");
			Property(x => x.IsStudentIntakeActive).HasColumnName("IsStudentIntakeActive");
		}
	}
}
