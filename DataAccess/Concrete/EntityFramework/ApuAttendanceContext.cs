using DataAccess.Concrete.EntityFramework.Mapping;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class ApuAttendanceContext:DbContext
	{
		public DbSet<User> Users { get; set; }
		public DbSet<Intake> Intakes { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<IntakeCourse> IntakeCourses { get; set; }
		public DbSet<Subject> Subjects { get; set; }
		public DbSet<CourseSubject> CourseSubjects { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<StudentIntake> StudentIntakes { get; set; }
		public DbSet<TimeTable> TimeTables { get; set; }
		public DbSet<Lecturer> Lecturers { get; set; }
		public DbSet<StudentAttendance> StudentAttendances { get; set; }
		public DbSet<ClassRoom> ClassRooms { get; set; }
		public DbSet<PresenceStatus> PresenceStatuses { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new UserMap());
			modelBuilder.Configurations.Add(new IntakeMap());
			modelBuilder.Configurations.Add(new CourseMap());
			modelBuilder.Configurations.Add(new IntakeCourseMap());
			modelBuilder.Configurations.Add(new SubjectMap());
			modelBuilder.Configurations.Add(new CourseSubjectMap());
			modelBuilder.Configurations.Add(new StudentMap());
			modelBuilder.Configurations.Add(new StudentIntakeMap());
			modelBuilder.Configurations.Add(new StudentAttendanceMap());
			modelBuilder.Configurations.Add(new ClassRoomMap());
			modelBuilder.Configurations.Add(new PresenceStatusMap());
			base.OnModelCreating(modelBuilder);
			Database.SetInitializer<ApuAttendanceContext>(null);
		}
	}
}
