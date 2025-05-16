using FluentValidation;
using MeDesenvolveIA.Domain;
using MeDesenvolveIA.Shareable;
using MeDesenvolveIA.Shareable.Behaviors;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeDesenvolveIA.IoC;

public static class AppServiceCollectionExtensions
{
	public static void ConfigureAppDependencies(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddMediatR(cfg =>
			cfg.RegisterServicesFromAssemblies(
				typeof(IDomainEntryPoint).Assembly,
				typeof(ValidationBehavior<,>).Assembly)
		);

		services.AddValidatorsFromAssemblyContaining<IShareableEntryPoint>();
		services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

	}
}