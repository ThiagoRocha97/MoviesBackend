using Application.Interfaces;
using Application.Usecases;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
	public static class UseCaseServiceCollectionExtensions
	{
		public static IServiceCollection AddUseCases(this IServiceCollection services) 
		{
			services.AddScoped<IAddGenresUseCase, AddGenresUseCase>();
			services.AddScoped<IGetGenreByIdUseCase, GetGenreByIdUseCase>();
			services.AddScoped<IGetGenresUseCase, GetGenresUseCase>();

			return services;
		}
	}
}
