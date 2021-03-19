using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IClassRoomService
	{
		List<ClassRoom> GetAll();
		List<ClassRoom> GetByClassRoom(string key);
		List<LecturerTimeTableItem> GetLecturerTimeTable(string LecturerID, bool onlyToday);
		ClassRoom Insert(ClassRoom entity);
		ClassRoom Update(ClassRoom entity);
		ClassRoom Delete(ClassRoom entity);
	}
}
