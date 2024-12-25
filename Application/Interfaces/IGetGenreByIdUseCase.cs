using Domain.Entities;

namespace Application.Interfaces
{
	public interface IGetGenreByIdUseCase
	{
		Task<Genres?> Execute(int Id);
	}
}
