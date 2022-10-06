using MediatR;
using System.Reflection;

namespace Demo.Inventory.Command.Catalog.Api.Application;

public static class DependencyContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
