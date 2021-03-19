using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Mapping
{
	public class StudentAttendanceMap:EntityTypeConfiguration<StudentAttendance>
	{
		public StudentAttendanceMap()
		{
			ToTable(@"StudentAttendances", @"dbo");
			HasKey(x => x.StudentAttendanceID);

			Property(x => x.StudentAttendanceID).HasColumnName("StudentAttendanceID");
			Property(x => x.StudentID).HasColumnName("StudentID");
			Property(x => x.IntakeID).HasColumnName("IntakeID");
			Property(x => x.SubjectID).HasColumnName("SubjectID");
			Property(x => x.LecturerID).HasColumnName("LecturerID");
			Property(x => x.PresenceStatusID).HasColumnName("PresenceStatusID");
			Property(x => x.Date).HasColumnName("Date");
		}
	}
}
