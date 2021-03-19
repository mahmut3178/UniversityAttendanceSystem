using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApuAttendance.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AttendanceController : ControllerBase
	{
		IStudentAttendanceService _studentAttendanceService;
		public AttendanceController(IStudentAttendanceService studentAttendanceService)
		{
			_studentAttendanceService = studentAttendanceService;
		}
		public IActionResult MarkAttendance(string cardID)
		{
			return Ok(_studentAttendanceService.UpdateStudentAttendanceByStudentCardID(cardID));
		}
	}
}
