using Microsoft.AspNetCore.Mvc;
using NewsApi.Core.Services.Interfaces;
using NewsApi.DataLayer.Entities.NewsEntities;

namespace NewsApi.Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NewsController(INewsService newsService) : ControllerBase
	{
		private INewsService _newsService = newsService;

		#region News Categories
		[HttpGet("news-categories")]
		public async Task<IActionResult> GetNewsCategories()
		{
			List<NewsCategory> categories = await _newsService.GetAllActiveCategories();

			return new JsonResult(new
			{
				categories
			});
		}
		#endregion
	}
}
