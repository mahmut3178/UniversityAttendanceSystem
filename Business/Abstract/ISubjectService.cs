using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ISubjectService
	{
		List<Subject> GetAll();
		List<Subject> GetBySubject(string key);
		Subject Insert(Subject entity);
		Subject Update(Subject entity);
		Subject Delete(Subject entity);
		List<IntakeSubjectItem> GetIntakeSubjects(string intakeID);
	}
}
