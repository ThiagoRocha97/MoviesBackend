using Domain.Entities;

namespace Application.Interfaces
{
	public interface IGetGenresUseCase
	{
		Task<List<Genres>> Execute();
	}
}
