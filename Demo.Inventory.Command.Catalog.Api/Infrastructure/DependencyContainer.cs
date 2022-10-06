using Demo.Inventory.Command.Catalog.Api.Domain.Contracts.Repository;
using Demo.Inventory.Command.Catalog.Api.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Demo.Inventory.Command.Catalog.Api.Infrastructure;

public static class DependencyContainer
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
        var dbName = Environment.GetEnvironmentVariable("DB_NAME");
        var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");
        var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};user ID=sa;Password={dbPassword}";

        services.AddDbContext<InventoryDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOffWork>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
