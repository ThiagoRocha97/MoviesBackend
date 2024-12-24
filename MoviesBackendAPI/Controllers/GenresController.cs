using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesBackendAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GenresController : ControllerBase
	{
		/// <summary>
		/// Gets a list of genres
		/// </summary>
		[HttpGet]
		public IActionResult Get() 
		{
			return Ok();
		}

		///<summary>
		/// Gets one specific genre
		/// </summary>
		[HttpGet]
		public IActionResult GetById(int id) 
		{
			return Ok();
		}

		///<summary>
		/// Create new Genre
		/// </summary>
		[HttpPost]
		public IActionResult Create(Genres genres)
		{
			return Created();
		}

		///<summary>
		/// Update one Genre
		/// </summary>
		[HttpPut]
		public IActionResult Put(Genres genres) 
		{
			return Ok(); 
		}
	}
}
