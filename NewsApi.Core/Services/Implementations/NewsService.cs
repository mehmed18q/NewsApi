using Microsoft.EntityFrameworkCore;
using NewsApi.Core.Services.Interfaces;
using NewsApi.DataLayer.Entities.NewsEntities;
using NewsApi.DataLayer.Repositories;

namespace NewsApi.Core.Services.Implementations
{
	public class NewsService(IGenericRepository<NewsCategory> newsCategoryRepository) : INewsService
	{
		private IGenericRepository<NewsCategory> _newsCategoryRepository = newsCategoryRepository;

		#region News Categories
		public async Task<List<NewsCategory>> GetAllActiveCategories()
		{
			return await _newsCategoryRepository.GetEntitiesQuery()
				.OrderBy(nc => nc.Order).ToListAsync();
		}
		#endregion

		#region  Dispose
		public ValueTask DisposeAsync()
		{
			throw new NotImplementedException();
		}
		#endregion
	}
}
