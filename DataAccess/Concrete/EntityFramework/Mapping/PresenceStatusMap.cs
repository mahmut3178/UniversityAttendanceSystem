using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	class PresenceStatusMap:EntityTypeConfiguration<PresenceStatus>
	{
		public PresenceStatusMap()
		{
			ToTable(@"PresenceStatus", @"dbo");
			HasKey(x => x.PresenceStatusID);

			Property(x => x.PresenceStatusID).HasColumnName("PresenceStatusID");
			Property(x => x.PresenceStatusName).HasColumnName("PresenceStatusName");
		}
	}
}
