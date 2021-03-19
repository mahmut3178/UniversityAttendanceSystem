using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validations.FluentValidation
{
	public class IntakeCourseValidator:AbstractValidator<IntakeCourse>
	{
		public IntakeCourseValidator()
		{
			RuleFor(x=>x.IntakeID).NotEmpty().WithMessage("You should select atleast one Intake!");
			RuleFor(x => x.CourseID).GreaterThan(0).WithMessage("You should select atleast one Course!");
		}
	}
}
