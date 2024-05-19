using Microsoft.EntityFrameworkCore;
using NewsApi.DataLayer.Context;
using NewsApi.DataLayer.Entities.Common;

namespace NewsApi.DataLayer.Repositories
{
	public class GenericRepository<TEntity>(NewsDbContext context) : IGenericRepository<TEntity>
		where TEntity : BaseEntity
	{
		private NewsDbContext _context = context;
		private DbSet<TEntity> _dbSet = context.Set<TEntity>();

		#region Get Entities Query
		public IQueryable<TEntity> GetEntitiesQuery()
		{
			return _dbSet.Where(e => e.DeleteDate == null).AsQueryable();
		}
		#endregion

		#region Get Entity By Id
		public async Task<TEntity?> GetEntityById(long id)
		{
			return await _dbSet.SingleOrDefaultAsync(e => e.Id == id && e.DeleteDate == null);
		}
		#endregion

		#region Create Entity
		public async Task CreateEntity(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
		}
		#endregion

		#region Edit Entity
		public void EditEntity(TEntity entity)
		{
			entity.LastUpdateDate = DateTime.Now;
			_dbSet.Update(entity);
		}
		#endregion

		#region Remove Entity
		public bool RemoveEntity(TEntity? entity)
		{
			if (entity is not null)
			{
				entity.DeleteDate = DateTime.Now;
				EditEntity(entity);

				return true;
			}
			return false;
		}

		public async Task<bool> RemoveEntity(long id)
		{
			TEntity? entity = await GetEntityById(id);

			return RemoveEntity(entity);

		}
		#endregion

		#region Save Changes
		public async Task Save()
		{
			await _context.SaveChangesAsync();
		}
		#endregion
	}
}
