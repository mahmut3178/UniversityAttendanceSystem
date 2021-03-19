using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class TimeTableMap:EntityTypeConfiguration<TimeTable>
	{
		public TimeTableMap()
		{
			ToTable(@"TimeTables", @"dbo");
			HasKey(x => x.TimeTableID);

			Property(x => x.TimeTableID).HasColumnName("TimeTableID");
			Property(x => x.IntakeID).HasColumnName("IntakeID");
			Property(x => x.LecturerID).HasColumnName("LecturerID");
			Property(x => x.SubjectID).HasColumnName("SubjectID");
			Property(x => x.ClassRoomID).HasColumnName("ClassRoomID");
			Property(x => x.SubjectDay).HasColumnName("SubjectDay");
			Property(x => x.SubjectTime).HasColumnName("SubjectTime");
			Property(x => x.SubjectDuration).HasColumnName("SubjectDuration");
		}
	}
}
