using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T> where T : IEntity, new()
	{
		List<T> GetList(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
		T Insert(T entity);
		T Update(T entity);
		T Delete(T entity);
	}
}
