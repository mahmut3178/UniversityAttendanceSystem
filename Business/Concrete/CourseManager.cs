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
	public class CourseManager : ICourseService
	{
		ICourseDal _courseDal;
		IIntakeCourseService _intakeCourseService = new IntakeCourseManager(new EfIntakeCourseDal());
		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

		public List<Course> GetByCourse(string key)
		{
			return key == null ? _courseDal.GetList() : _courseDal.GetList(x=>x.CourseName.Contains(key) && x.IsCourseActive == true);
		}

		public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
		{
			return _courseDal.GetList();
		}

		public Course Insert(Course entity)
		{
			ValidatorTool.FluentValidate(new CourseValidator(), entity);
			var hasCourse = GetAll().FirstOrDefault(x => x.CourseName == entity.CourseName && x.IsCourseActive == true);
			if (hasCourse != null)
			{
				throw new DataExistException("A course with the same name already exists.");
			}
			entity.IsCourseActive = true;
			return _courseDal.Insert(entity);
		}

		public Course Update(Course entity)
		{
			ValidatorTool.FluentValidate(new CourseValidator(), entity);
			var hasCourse = _intakeCourseService.GetAll().FirstOrDefault(x => x.CourseID == entity.CourseID && x.IsIntakeCourseActive == true);
			if (hasCourse != null)
			{
				throw new DataUsedException("You cannot modify a course that is in use by an intake.");
			}
			entity.IsCourseActive = true;
			return _courseDal.Update(entity);
		}
		public Course Delete(Course entity)
		{
			return _courseDal.Delete(entity);
		}

		public List<Course> GetAll()
		{
			return _courseDal.GetList();
		}

		public void InactivateCourse(Course course)
		{
			var hasCourse = _intakeCourseService.GetAll().FirstOrDefault(x=>x.CourseID == course.CourseID && x.IsIntakeCourseActive == true);
			if(hasCourse != null)
			{
				throw new DataUsedException("You cannot remove a course that is in use by an intake.");
			}
			_courseDal.Update(course);
		}
	}
}
