using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[Table("Movies")]
	public class Movies : BaseEntity
	{
		public string? Title {  get; set; }
		public string? Synopsis { get; set; }
		public int GenreId {  get; set; }
		public int YearReleased {  get; set; }
		public string? ImageUrl { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime DateUpdated { get; set; } = DateTime.Now;
	}
}
