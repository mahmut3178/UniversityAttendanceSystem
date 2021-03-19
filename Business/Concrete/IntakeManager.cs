using Business.Abstract;
using Business.CrossCuttingConcerns.Validations.FluentValidation;
using Business.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class IntakeManager : IIntakeService
	{
		IIntakeDal _intakeDal;

		IIntakeCourseService _intakeCourseService = new IntakeCourseManager(new EfIntakeCourseDal());
		public IntakeManager(IIntakeDal intakeDal)
		{
			_intakeDal = intakeDal;
		}

		public Intake Delete(Intake entity)
		{
			return _intakeDal.Delete(entity);
		}

		public List<Intake> GetAll()
		{
			return _intakeDal.GetList();
		}

		public List<Intake> GetAllIntake()
		{
			return _intakeDal.GetList(x=>x.IsIntakeActive == true);
		}

		public List<Intake> GetByIntake(string key, bool isUsed)
		{
			var intakeList = key == null ? _intakeDal.GetList(x => x.IsIntakeActive == true) : _intakeDal.GetList(x => x.IntakeID.Contains(key) && x.IsIntakeActive == true);
			List<Intake> intakesList = new List<Intake>();
			foreach (var intake in intakeList)
			{
				var showIntake = _intakeCourseService.GetAll().FirstOrDefault(x => x.IntakeID == intake.IntakeID && x.IsIntakeCourseActive == true);
				bool isShowIntake = (showIntake != null);
				if (isShowIntake == isUsed)
				{
					intakesList.Add(intake);
				}
			}
			return intakesList;
		}

		public void InactivateIntake(Intake intake)
		{
			var hasIntake = _intakeCourseService.GetAll().FirstOrDefault(x => x.IntakeID == intake.IntakeID && x.IsIntakeCourseActive == true);
			if (hasIntake != null)
				throw new DataUsedException("You Cannot remove a Intake That is In Use by a course!");
			_intakeDal.Update(intake);
		}

		public Intake Insert(Intake entity)
		{
			ValidatorTool.FluentValidate(new IntakeValidator(), entity);
			var hasIntake = GetAll().FirstOrDefault(x => x.IntakeID == entity.IntakeID);
			if (hasIntake != null && hasIntake.IsIntakeActive == false)
			{
				hasIntake.IsIntakeActive = true;
				return Update(hasIntake);
			}
			else if (hasIntake != null && hasIntake.IsIntakeActive == true)
			{
				throw new DataExistException("This intake is already being used.");
			}

			return _intakeDal.Insert(entity);
		}

		public Intake Update(Intake entity)
		{
			return _intakeDal.Update(entity);
		}
	}
}
