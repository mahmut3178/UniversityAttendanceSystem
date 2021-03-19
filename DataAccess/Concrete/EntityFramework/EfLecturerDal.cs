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
	public class EfLecturerDal:EfEntityRepositoryBase<Lecturer, ApuAttendanceContext>, ILecturerDal
	{
		public void InsertLecturer(User user, Lecturer lecturer)
		{
			using (var transaction = new TransactionScope())
			{
				try
				{
					using (var context = new ApuAttendanceContext())
					{
						var insertedUser = context.Entry(user);
						insertedUser.State = EntityState.Added;
						var insertedLecturer = context.Entry(lecturer);
						insertedLecturer.State = EntityState.Added;
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
