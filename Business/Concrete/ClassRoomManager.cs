using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ClassRoomManager:IClassRoomService
	{
		IClassRoomDal _classRoomDal;
		public ClassRoomManager(IClassRoomDal classRoomDal)
		{
			_classRoomDal = classRoomDal;
		}

		public ClassRoom Delete(ClassRoom entity)
		{
			throw new NotImplementedException();
		}

		public List<ClassRoom> GetAll()
		{
			return _classRoomDal.GetList();
		}

		public List<ClassRoom> GetByClassRoom(string key)
		{
			throw new NotImplementedException();
		}

		public List<LecturerTimeTableItem> GetLecturerTimeTable(string LecturerID, bool onlyToday)
		{
			if(onlyToday)
			return _classRoomDal.GetLecturerTimeTable(LecturerID).Where(x=>x.SubjectDayID == Convert.ToInt32(DateTime.Now.DayOfWeek)).OrderBy(X=>X.SubjectDayID).ToList();

			return _classRoomDal.GetLecturerTimeTable(LecturerID).OrderBy(X => X.SubjectDayID).ThenBy(x=>x.SubjectTime).ToList();
		}

		public ClassRoom Insert(ClassRoom entity)
		{
			throw new NotImplementedException();
		}

		public ClassRoom Update(ClassRoom entity)
		{
			throw new NotImplementedException();
		}

	}
}
