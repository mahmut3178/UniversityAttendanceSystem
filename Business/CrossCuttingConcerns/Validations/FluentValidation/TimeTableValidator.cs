using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validations.FluentValidation
{
	public class TimeTableValidator:AbstractValidator<TimeTable>
	{
		public TimeTableValidator()
		{
			RuleFor(x => x.SubjectDuration).GreaterThan(0).WithMessage("Subject duration is invalid");
			RuleFor(x => x.IntakeID).NotEqual("Select Intake", null).WithMessage("Intake is invalid");
			RuleFor(x => x.LecturerID).NotEqual("Select Lecturer", null).WithMessage("Choose A Lecturer");
			RuleFor(x => x.ClassRoomID).GreaterThan(0).WithMessage("Classroom is invalid");
			RuleFor(x => x.SubjectID).GreaterThan(0).WithMessage("Invalid Subject");
			RuleFor(x => x.SubjectDay).GreaterThan(0).WithMessage("Day is invalid");
		}
	}
}
