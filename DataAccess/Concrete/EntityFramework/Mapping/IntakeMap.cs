using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class IntakeMap:EntityTypeConfiguration<Intake>
	{
		public IntakeMap()
		{
			ToTable(@"Intakes", @"dbo");
			HasKey(x => x.IntakeID);

			Property(x => x.IntakeID).HasColumnName("IntakeID");
			Property(x => x.IsIntakeActive).HasColumnName("IsIntakeActive");
		}
	}
}
