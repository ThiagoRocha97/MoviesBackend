using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.IRepositories;

namespace Application.Usecases
{
	public class GetGenreByIdUseCase : IGetGenreByIdUseCase
	{
		private readonly IGenresRepository _genresRepository;

		public GetGenreByIdUseCase(IGenresRepository genresRepository)
		{
			_genresRepository = genresRepository;
		}

		public async Task<Genres?> Execute(int Id)
		{
			return await _genresRepository.GetById(Id);
		}
	}
}
