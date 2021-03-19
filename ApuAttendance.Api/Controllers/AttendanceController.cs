using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace ApuAttendance.WebApi.Controllers
{
	
	public class AttendanceController : ApiController
	{
		IStudentAttendanceService _studentAttendanceService;
		public AttendanceController()
		{
			_studentAttendanceService = new StudentAttendanceManager(new EfStudentAttendanceDal());
		}

		[Route("api/attendance/SubmitAttendance")]
		[HttpPost]
		public bool SubmitAttendance(string cardID)
		{
			return _studentAttendanceService.UpdateStudentAttendanceByStudentCardID(cardID);
		}	

		
	}
}
