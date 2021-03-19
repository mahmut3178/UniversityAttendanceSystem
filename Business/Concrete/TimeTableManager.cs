using Business.Abstract;
using Business.CrossCuttingConcerns.Validations.FluentValidation;
using Business.Exceptions;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class TimeTableManager : ITimeTableService
	{
		readonly ITimeTableDal _timeTableDal;

		public TimeTableManager(ITimeTableDal timeTableDal)
		{
			_timeTableDal = timeTableDal;
		}

		public TimeTable Delete(TimeTable entity)
		{
			return _timeTableDal.Delete(entity);
		}

		public List<TimeTable> GetAll()
		{
			throw new NotImplementedException();
		}

		public void InactivateLecturer(TimeTable entity)
		{
			throw new NotImplementedException();
		}

		public TimeTable Insert(TimeTable entity)
		{
			ValidatorTool.FluentValidate(new TimeTableValidator(), entity);
			TimeTableLecturerScheduleClashValidator(entity);
			TimeTableIntakeScheduleClashValidator(entity);
			TimeTableClassRoomScheduleClashValidator(entity);
			return _timeTableDal.Insert(entity);
		}

		public TimeTable Update(TimeTable entity)
		{
			ValidatorTool.FluentValidate(new TimeTableValidator(), entity);
			TimeTableLecturerScheduleClashValidator(entity);
			TimeTableIntakeScheduleClashValidator(entity);
			TimeTableClassRoomScheduleClashValidator(entity);
			return _timeTableDal.Update(entity);
		}
		public List<TimeTableItem> GetListTimeTable(string intakeID, string lecturerID, int dayOfWeek)
		{
			return _timeTableDal.GetListTimeTable(intakeID, lecturerID, dayOfWeek);
		}

		public void TimeTableLecturerScheduleClashValidator(TimeTable entity)
		{
			List<TimeTableItem> timeTables = _timeTableDal.GetTimeTableByValidatingLecturerTime(entity);
			ScheduleValidatorListLooper(entity, timeTables, "This Lecturer is enrolled to a class at the given time.");


		}
		public void TimeTableIntakeScheduleClashValidator(TimeTable entity)
		{
			List<TimeTableItem> timeTables = _timeTableDal.GetTimeTableByValidatingIntakeTime(entity);
			ScheduleValidatorListLooper(entity, timeTables, "This Intake is enrolled to a class at the given time.");
		}
		public void TimeTableClassRoomScheduleClashValidator(TimeTable entity)
		{
			List<TimeTableItem> timeTables = _timeTableDal.GetTimeTableByValidatingClassTime(entity);
			ScheduleValidatorListLooper(entity, timeTables, "Classroom not available at the given time.");

		}

		public void ScheduleValidatorListLooper(TimeTable entity, List<TimeTableItem> timeTableItems, string exceptionMessage)
		{
			foreach (var timetable in timeTableItems)
			{
				TimeSpan entitySubjectDuration = TimeSpan.FromMinutes(entity.SubjectDuration);
				TimeSpan timeTableSubjectDuration = TimeSpan.FromMinutes(timetable.SubjectDuration);

				TimeSpan entitySubjectTime = entity.SubjectTime;
				TimeSpan timeTablesubjectTime = timetable.SubjectTime;

				TimeSpan entitySubjectTimeSubtractTimeTableSubjectDuration = entitySubjectTime.Subtract(timeTableSubjectDuration);
				TimeSpan timeTableSubjectTimeAddSubjectDuration = entitySubjectTime.Add(entitySubjectDuration);

				if (entitySubjectTimeSubtractTimeTableSubjectDuration <= timetable.SubjectTime && timetable.SubjectTime <= timeTableSubjectTimeAddSubjectDuration && entity.TimeTableID != timetable.TimeTableID)
					throw new DataUsedException(exceptionMessage);
			}
		}

		public TimeTable GetTimeTableByID(int timeTableID)
		{
			return _timeTableDal.Get(x=>x.TimeTableID== timeTableID);
		}

		public List<TimeTableItem> GetStudentTimeTable(string studentID, int WeekOfDay)
		{			
			List<TimeTableItem> timeTableList = _timeTableDal.GetStudentTimeTable(studentID, WeekOfDay).OrderBy(x=>x.SubjectDayID).ThenBy(x=>x.SubjectTime).ToList();

			foreach (var item in timeTableList)
			{
				TimeSpan subjectDuration = TimeSpan.FromMinutes(item.SubjectDuration);
				item.StartEndTime = item.SubjectTime.ToString() + " - " + item.SubjectTime.Add(subjectDuration).ToString();                
			}
			return timeTableList;
		}

		public List<LecturerTimeTableItem> GetPastClasses(string lecturerID)
		{
			return _timeTableDal.GetPastClasses(lecturerID);			
		}
	}
}
