using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validations.FluentValidation
{
	public class IntakeValidator : AbstractValidator<Intake>
	{
		public IntakeValidator()
		{
			RuleFor(x => x.IntakeID).NotEmpty().WithMessage("Intake name should not be empty!");
		}
	}
}

