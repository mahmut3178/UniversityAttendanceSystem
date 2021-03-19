using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.CrossCuttingConcerns.Validations.FluentValidation
{
	public class InsertStudentValidator:AbstractValidator<Student>
	{
		public InsertStudentValidator()
		{			
		}
	}
}
