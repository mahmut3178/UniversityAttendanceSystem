using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class ClassRoomMap:EntityTypeConfiguration<ClassRoom>
	{
		public ClassRoomMap()
		{
			ToTable(@"ClassRooms", @"dbo");
			HasKey(x => x.ClassRoomID);

			Property(x => x.ClassRoomID).HasColumnName("ClassRoomID");
			Property(x => x.ClassRoomName).HasColumnName("ClassRoomName");
		}
	}
}
