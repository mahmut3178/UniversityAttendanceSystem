using Business.Abstract;
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
	public class UserManager:IUserService
	{
		readonly IUserDal _userDal;

		public UserManager(IUserDal userDal)
		{
			_userDal = userDal;
		}

		public User Delete(User entity)
		{
			return _userDal.Delete(entity);
		}

		public List<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<LecturerItem> GetLecturerByIDAndName(string key)
		{
			return _userDal.GetLecturerByIDAndName(key);
		}

		public List<StudentItem> GetStudentByIDAndName(string key)
		{
			return _userDal.GetStudentByIDAndName(key);
		}

		public User GetUserByID(string userID)
		{
			return _userDal.Get(x=>x.UserName.Equals(userID));
		}

		public User Insert(User entity)
		{
			if (_userDal.Get(x => x.UserName.Equals(entity.UserName))!=null)
				throw new DataExistException("User with that ID Already Exists");
			return entity;
		}
		public User Update(User entity)
		{
			return _userDal.Update(entity);
		}

		public User UserLogin(User entity)
		{
			var userExist = _userDal.Get(x => x.UserName.Equals(entity.UserName) && x.Password.Equals(entity.Password));

			if(userExist!=null)
			{
				return userExist;
			}
			else
			{
				throw new LoginFailedException("Login details incorrect");
			}
		}
		public void ValidateUser(User user)
		{
			if (_userDal.Get(x => x.UserName.Equals(user.UserName)) != null)
				throw new DataExistException("User with that ID Already Exists");			
		}
	}
}
