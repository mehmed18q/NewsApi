using NewsApi.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace NewsApi.DataLayer.Entities.NewsEntities
{
	public class NewsCategory : BaseEntity
	{
		#region Properties
		[Display(Name = "دسته بندی خبر")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public required string Name { get; set; }

		[Display(Name = "اولویت نمایش")]
		public int Order { get; set; }

		[Display(Name = "تصویر")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public required string ImageName { get; set; }
		#endregion

		#region Relations
		public ICollection<News>? AllNews { get; set; }
		#endregion
	}
}
