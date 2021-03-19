using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IClassRoomDal:IEntityRepository<ClassRoom>
	{
		List<LecturerTimeTableItem> GetLecturerTimeTable(string LecturerID);
	}
}
