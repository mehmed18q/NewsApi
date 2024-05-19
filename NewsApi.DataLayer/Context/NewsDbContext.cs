using Microsoft.EntityFrameworkCore;
using NewsApi.DataLayer.Entities.NewsEntities;

namespace NewsApi.DataLayer.Context
{
	public class NewsDbContext(DbContextOptions<NewsDbContext> options) : DbContext(options)
	{
		public DbSet<News> News { get; set; }
		public DbSet<NewsCategory> NewsCategories { get; set; }
	}
}
