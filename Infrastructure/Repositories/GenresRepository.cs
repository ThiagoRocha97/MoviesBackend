using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

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
			_applicationDbContext.Genres.Add(entity);
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

		public async Task<Genres?> GetById(int id)
		{
			Genres? genre = await _applicationDbContext.Genres.FindAsync(id);
			return genre;
		}

		public Task Update(Genres entity)
		{
			throw new NotImplementedException();
		}
	}
}
