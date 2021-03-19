using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfStudentDal : EfEntityRepositoryBase<Student, ApuAttendanceContext>, IStudentDal
	{
		public void InsertStudent(User user, Student student, StudentIntake studentIntake)
		{
			using (var transaction = new TransactionScope())
			{
				try
				{
					using (var context = new ApuAttendanceContext())
					{			
						var insertedUser = context.Entry(user);
						insertedUser.State = EntityState.Added;
						var insertedStudent = context.Entry(student);
						insertedStudent.State = EntityState.Added;
						var insertedStudentIntake = context.Entry(studentIntake);
						insertedStudentIntake.State = EntityState.Added;
						context.SaveChanges();
						transaction.Complete();
					}
				}
				catch (Exception)
				{
					transaction.Dispose();
					throw new Exception("Something Went Wrong");
				}
			}
		}


	}
}
