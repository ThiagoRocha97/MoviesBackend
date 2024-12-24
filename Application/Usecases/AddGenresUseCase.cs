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
	public class AddGenresUseCase : IAddGenresUseCase
	{
		private readonly IGenresRepository _genresRepository;

		public AddGenresUseCase(IGenresRepository genresRepository)
		{
			_genresRepository = genresRepository;
		}

		public async Task Execute(Genres genres)
		{
			await _genresRepository.Add(genres);
		}
	}
}
