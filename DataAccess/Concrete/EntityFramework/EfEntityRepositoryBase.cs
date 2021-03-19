using DataAccess.Abstract;
using Entity.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
		where TEntity : class, IEntity, new()
		where TContext : DbContext, new()
	{
		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			using (var context = new TContext())
			{
				return context.Set<TEntity>().FirstOrDefault(filter);
			}

		}

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
		{
			using (var context = new TContext())
			{
				return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
			}
		}

		public TEntity Insert(TEntity entity)
		{
			using (var context = new TContext())
			{
				try
				{
					var insertedEntity = context.Entry(entity);
					insertedEntity.State = EntityState.Added;
					context.SaveChanges();
					return entity;
				}
				catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
				{
					Exception raise = dbEx;
					foreach (var validationErrors in dbEx.EntityValidationErrors)
					{
						foreach (var validationError in validationErrors.ValidationErrors)
						{
							string message = string.Format("{0}:{1}",
								validationErrors.Entry.Entity.ToString(),
								validationError.ErrorMessage);
							// raise a new exception nesting
							// the current instance as InnerException
							raise = new InvalidOperationException(message, raise);
						}
					}
					throw raise;
				}

			}
		}

		public TEntity Update(TEntity entity)
		{
			using (var context = new TContext())
			{
				var updatedEntity = context.Entry(entity);
				updatedEntity.State = EntityState.Modified;
				context.SaveChanges();
				return entity;
			}
		}
		public TEntity Delete(TEntity entity)
		{
			using (var context = new TContext())
			{
				var deletedEntity = context.Entry(entity);
				deletedEntity.State = EntityState.Deleted;
				context.SaveChanges();
				return entity;
			}
		}
	}
}

