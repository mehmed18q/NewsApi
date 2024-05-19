using NewsApi.DataLayer.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace NewsApi.DataLayer.Entities.NewsEntities
{
	public class News : BaseEntity
	{
		#region Properties
		[Display(Name = "عنوان خبر")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public required string Title { get; set; }

		[Display(Name = "نویسنده")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public required string Author { get; set; }

		[Display(Name = "تصویر")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public required string ImageName { get; set; }

		[Display(Name = "دسته بندی")]
		[Required(ErrorMessage = "لطفا {0} را وارد نمایید.")]
		[MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
		public long NewsCategoryId { get; set; }
		#endregion

		#region Relations
		public required NewsCategory NewsCategory { get; set; }
		#endregion
	}
}
