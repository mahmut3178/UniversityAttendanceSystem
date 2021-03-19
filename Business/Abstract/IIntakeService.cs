using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IIntakeService
	{
		List<Intake> GetAll();
		List<Intake> GetAllIntake();
		List<Intake> GetByIntake(string key, bool isUsed);
		Intake Insert(Intake entity);
		Intake Delete(Intake entity);
		Intake Update(Intake entity);
		void InactivateIntake(Intake intake);		
	}
}
