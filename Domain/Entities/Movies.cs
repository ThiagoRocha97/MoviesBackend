using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
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
