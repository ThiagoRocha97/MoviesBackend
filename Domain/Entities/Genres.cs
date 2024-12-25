using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
	[Table("Genres")]
	public class Genres : BaseEntity
	{
		[Required]
		[StringLength(100)]
		public required string GenreName { get; set; }
	}
}
