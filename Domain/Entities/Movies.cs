using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[Table("Movies")]
	public class Movies : BaseEntity
	{
		public string? Title {  get; set; }
		public string? Description { get; set; }
		public int GenreId {  get; set; }
		public int Year_Released {  get; set; }
		public string? Image_Url { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; } = DateTime.Now;
	}
}
