using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes.ParameterItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class LecturerManager : ILecturerService
	{
		ILecturerDal _lecturerDal;
		public LecturerManager(ILecturerDal lecturerDal)
		{
			_lecturerDal = lecturerDal;
		}

		public List<Lecturer> GetAll()
		{
			return _lecturerDal.GetList();
		}

		public Lecturer Insert(Lecturer entity)
		{
			return _lecturerDal.Insert(entity);
		}

		public Lecturer Delete(Lecturer entity)
		{
			return _lecturerDal.Delete(entity);
		}

		public Lecturer Update(Lecturer entity)
		{
			return _lecturerDal.Update(entity);
		}

		public void InactivateLecturer(Lecturer entity)
		{
			throw new NotImplementedException();
		}

		public Lecturer GetLecturerByID(Lecturer entity)
		{
			return _lecturerDal.Get(x => x.LecturerID.Equals(entity.LecturerID));
		}

		public void InsertLecturer(LecturerQueryItem lecturerItem)
		{
			_lecturerDal.InsertLecturer(new User
			{
				UserName = lecturerItem.UserName,
				Password = lecturerItem.Password,
				UserTypeID = lecturerItem.UserTypeID
			}, new Lecturer
			{
				LecturerID = lecturerItem.LecturerID,
				FirstName = lecturerItem.FirstName,
				MiddleName = lecturerItem.MiddleName,
				LastName = lecturerItem.LastName,
				Phone = lecturerItem.Phone,
				Address = lecturerItem.Address,
				Photo = lecturerItem.Photo
			});
		}
	}
}
