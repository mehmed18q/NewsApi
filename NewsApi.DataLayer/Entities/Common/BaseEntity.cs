using System.ComponentModel.DataAnnotations;

namespace NewsApi.DataLayer.Entities.Common
{
	public abstract class BaseEntity
	{
		[Key]
		public long Id { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime? LastUpdateDate { get; set; }
		public DateTime? DeleteDate { get; set; }
		public bool IsDelete => DeleteDate.HasValue;
	}
}
