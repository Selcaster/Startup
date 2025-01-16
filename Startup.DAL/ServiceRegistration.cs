using Startup.Core.RepositoryInterfaces;
using Startup.DAL.RepositoryImplements;
using Microsoft.Extensions.DependencyInjection;

namespace Startup.DAL;

public static class ServiceRegistration
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        return services;
    }
}