using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfUserDal : EfEntityRepositoryBase<User, ApuAttendanceContext>, IUserDal
	{
		public List<LecturerItem> GetLecturerByIDAndName(string key)
		{
			using (var context = new ApuAttendanceContext())
			{
				var lecturerItem = from u in context.Users
								   join
		   l in context.Lecturers on u.UserName equals
		   l.LecturerID
								   where key == null ? 1 != 0 : (l.LecturerID.Contains(key) || l.FirstName.Contains(key)
					  || l.MiddleName.Contains(key) || l.LastName.Contains(key))
								   select new LecturerItem
								   {
									   UserID = u.UserID,
									   LecturerID = l.LecturerID,
									   UserName = u.UserName,
									   Password = u.Password,
									   FirstName = l.FirstName,
									   MiddleName = l.MiddleName,
									   LastName = l.LastName,
									   Address = l.Address,
									   Phone = l.Phone,
									   Photo = l.Photo
								   };
				return lecturerItem.ToList();
			}
		}


		public List<StudentItem> GetStudentByIDAndName(string key)
		{
			using (var context = new ApuAttendanceContext())
			{
				var studentItem = from u in context.Users
								  join
s in context.Students on u.UserName equals
s.StudentID
								  join si in context.StudentIntakes on s.StudentID equals si.StudentID

								  where key == null ? 1 != 0 : (s.StudentID.Contains(key) || s.StudentFirstName.Contains(key)
					 || s.StudentMiddleName.Contains(key) || s.StudentLastName.Contains(key))
								  select new StudentItem
								  {
									  StudentIntakeID = si.StudentIntakeID,
									  UserID = u.UserID,
									  StudentID = s.StudentID,
									  UserName = u.UserName,
									  Password = u.Password,
									  StudentFirstName = s.StudentFirstName,
									  StudentMiddleName = s.StudentMiddleName,
									  StudentLastName = s.StudentLastName,
									  Intake = si.IntakeID,
									  StudentBirthDate = s.StudentBirthDate,
									  StudentEmail = s.StudentEmail,
									  Photo = s.Photo

								  };
				return studentItem.ToList();
			}
		}



	}
}


