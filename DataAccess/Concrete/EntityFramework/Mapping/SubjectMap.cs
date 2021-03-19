using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class SubjectMap:EntityTypeConfiguration<Subject>
	{
		public SubjectMap()
		{
			ToTable(@"Subjects", @"dbo");
			HasKey(x => x.SubjectID);

			Property(x => x.SubjectID).HasColumnName("SubjectID");
			Property(x => x.SubjectName).HasColumnName("SubjectName");
		}
	}
}
