using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class LecturerMap:EntityTypeConfiguration<Lecturer>
	{
		public LecturerMap()
		{
			ToTable(@"Lecturers", @"dbo");
			HasKey(x => x.LecturerID);

			Property(x => x.LecturerID).HasColumnName("LecturerID");
			Property(x => x.FirstName).HasColumnName("FirstName");
			Property(x => x.MiddleName).HasColumnName("MiddleName");
			Property(x => x.LastName).HasColumnName("LastName");
			Property(x => x.Address).HasColumnName("Address");
			Property(x => x.Phone).HasColumnName("Phone");
			Property(x => x.Photo).HasColumnName("Photo");
		}
	}
}
