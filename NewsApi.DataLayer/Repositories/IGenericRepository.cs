using NewsApi.DataLayer.Entities.Common;

namespace NewsApi.DataLayer.Repositories
{
	public interface IGenericRepository<TEntity> where TEntity : BaseEntity
	{
		IQueryable<TEntity> GetEntitiesQuery();
		Task<TEntity?> GetEntityById(long id);
		Task CreateEntity(TEntity entity);
		void EditEntity(TEntity entity);
		bool RemoveEntity(TEntity? entity);
		Task<bool> RemoveEntity(long id);
		Task Save();
	}
}
