using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Ninject
{
	public class BusinessModule:NinjectModule
	{
		public override void Load()
		{
			Bind<IClassRoomService>().To<ClassRoomManager>();
			Bind<IClassRoomDal>().To<EfClassRoomDal>();

			Bind<ICourseService>().To<CourseManager>();
			Bind<ICourseDal>().To<EfCourseDal>();

			Bind<ICourseSubjectService>().To<CourseSubjectManager>();
			Bind<ICourseSubjectDal>().To<EfCourseSubjectDal>();

			Bind<IIntakeCourseService>().To<IntakeCourseManager>();
			Bind<IIntakeCourseDal>().To<EfIntakeCourseDal>(); 
			
			Bind<IIntakeService>().To<IntakeManager>();
			Bind<IIntakeDal>().To<EfIntakeDal>();

			Bind<ILecturerService>().To<LecturerManager>();
			Bind<ILecturerDal>().To<EfLecturerDal>();

			Bind<IPresenceStatusService>().To<PresenceStatusManager>();
			Bind<IPresenceStatusDal>().To<EfPresenceStatusDal>();

			Bind<IStudentAttendanceService>().To<StudentAttendanceManager>();
			Bind<IStudentAttendanceDal>().To<EfStudentAttendanceDal>();

			Bind<IStudentIntakeService>().To<StudentIntakeManager>();
			Bind<IStudentIntakeDal>().To<EfStudentIntakeDal>();

			Bind<IStudentService>().To<StudentManager>();
			Bind<IStudentDal>().To<EfStudentDal>();

			Bind<ISubjectService>().To<SubjectManager>();
			Bind<ISubjectDal>().To<EfSubjectDal>();

			Bind<ITimeTableService>().To<TimeTableManager>();
			Bind<ITimeTableDal>().To<EfTimeTableDal>();

			Bind<IUserService>().To<UserManager>();
			Bind<IUserDal>().To<EfUserDal>();

		}
	}
}
