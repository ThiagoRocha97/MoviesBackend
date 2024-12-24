using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
