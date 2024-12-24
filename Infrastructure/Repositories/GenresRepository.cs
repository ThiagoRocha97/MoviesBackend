using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
	public class GenresRepository : IGenresRepository
	{
		private readonly ApplicationDbContext _applicationDbContext;

		public GenresRepository(ApplicationDbContext applicationDbContext) 
		{
			_applicationDbContext = applicationDbContext;
		}

		public async Task Add(Genres entity)
		{
			_applicationDbContext.Add(entity);
			await _applicationDbContext.SaveChangesAsync();
		}

		public Task Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<List<Genres>> GetAll()
		{
			var list = await _applicationDbContext.Genres.ToListAsync();
			return list;
		}

		public Task<Genres> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task Update(Genres entity)
		{
			throw new NotImplementedException();
		}
	}
}
