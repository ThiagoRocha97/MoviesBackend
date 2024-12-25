using Domain.Entities;

namespace Application.Interfaces
{
	public interface IAddGenresUseCase
	{
		Task Execute(Genres genres);
	}
}
