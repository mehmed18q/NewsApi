using NewsApi.DataLayer.Entities.NewsEntities;

namespace NewsApi.Core.Services.Interfaces
{
	public interface INewsService : IAsyncDisposable
	{
		#region News Categories
		Task<List<NewsCategory>> GetAllActiveCategories();
		#endregion
	}
}
