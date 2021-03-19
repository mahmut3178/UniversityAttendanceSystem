using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class StudentMap:EntityTypeConfiguration<Student>
	{
		public StudentMap()
		{
			ToTable(@"Students", @"dbo");
			HasKey(x => x.StudentID);

			Property(x => x.StudentID).HasColumnName("StudentID");
			Property(x => x.StudentCardID).HasColumnName("StudentCardID");
			Property(x => x.StudentFirstName).HasColumnName("StudentFirstNAme");
			Property(x => x.StudentMiddleName).HasColumnName("StudentMiddleName");
			Property(x => x.StudentLastName).HasColumnName("StudentLastName");
			Property(x => x.StudentBirthDate).HasColumnName("StudentBirthDate");
			Property(x => x.Photo).HasColumnName("Photo");
		}
	}
}
