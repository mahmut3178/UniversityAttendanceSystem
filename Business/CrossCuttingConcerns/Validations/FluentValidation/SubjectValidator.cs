using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validations.FluentValidation
{
	public class SubjectValidator:AbstractValidator<Subject>
	{
		public SubjectValidator()
		{
			RuleFor(x => x.SubjectName).NotEmpty().WithMessage("Subject Name Cannot Be Empty.");
		}
	}
}
