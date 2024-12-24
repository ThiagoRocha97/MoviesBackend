using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesBackendAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GenresController : ControllerBase
	{
		private readonly IAddGenresUseCase _addGenresUseCase;
		private readonly IGetGenresUseCase _getGenresUseCase;

		public GenresController(IAddGenresUseCase addGenresUseCase, IGetGenresUseCase getGenresUseCase)
		{
			_addGenresUseCase = addGenresUseCase;
			_getGenresUseCase = getGenresUseCase;
		}
		/// <summary>
		/// Gets a list of genres
		/// </summary>
		[HttpGet]
		public async Task<IActionResult> Get() 
		{
			var list = await _getGenresUseCase.Execute();
			return Ok();
		}

		///<summary>
		/// Gets one specific genre
		/// </summary>
		[HttpGet("{id}", Name = "GetGenreById")]
		public async Task<IActionResult> GetGenreById(int id) 
		{
			return Ok();
		}

		///<summary>
		/// Create new Genre
		/// </summary>
		[HttpPost]
		public async Task<IActionResult> Create(Genres genres)
		{
			await _addGenresUseCase.Execute(genres);

			return CreatedAtRoute("GetGenreById", new {id = genres.Id});
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
