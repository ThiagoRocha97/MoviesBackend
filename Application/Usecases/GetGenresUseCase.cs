using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.IRepositories;

namespace Application.Usecases
{
	public class GetGenresUseCase : IGetGenresUseCase
	{
		private readonly IGenresRepository _genresRepository;

		public GetGenresUseCase(IGenresRepository genresRepository)
		{
			_genresRepository = genresRepository;
		}

		public async Task<List<Genres>> Execute()
		{
			return await _genresRepository.GetAll();
		}
	}
}
