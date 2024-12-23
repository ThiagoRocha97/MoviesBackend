using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[Table("Genres")]
	public class Genres : BaseEntity
	{
		public string? GenreName { get; set; }
	}
}
