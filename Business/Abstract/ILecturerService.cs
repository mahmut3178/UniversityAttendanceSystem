using Entity.Concrete;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface ILecturerService
	{
		List<Lecturer> GetAll();
		Lecturer GetLecturerByID(Lecturer entity);
		Lecturer Insert(Lecturer entity);
		Lecturer Delete(Lecturer entity);
		Lecturer Update(Lecturer entity);
		void InactivateLecturer(Lecturer entity);
		void InsertLecturer(LecturerQueryItem lecturerQueryItem1);
	}
}
