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
	public interface IUserService
	{
		List<User> GetAll();
		User Insert(User entity);
		User Update(User entity);
		User Delete(User entity);
		User UserLogin(User entity);
		User GetUserByID(string userID);
		List<LecturerItem> GetLecturerByIDAndName(string key);
		List<StudentItem> GetStudentByIDAndName(string key);
		void ValidateUser(User user);
	}
}
