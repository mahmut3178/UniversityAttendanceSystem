using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class UserMap:EntityTypeConfiguration<User>
	{
		public UserMap()
		{
			ToTable(@"Users",@"dbo");
			HasKey(x=>x.UserID);

			Property(x => x.UserID).HasColumnName("UserID");
			Property(x => x.UserName).HasColumnName("UserName");
			Property(x => x.Password).HasColumnName("Password");
			Property(x => x.UserTypeID).HasColumnName("UserTypeID");
		}
	}
}
