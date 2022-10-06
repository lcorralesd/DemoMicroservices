using Demo.Inventory.Command.Catalog.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace Demo.Inventory.Command.Catalog.Api.Infrastructure;

public class InventoryDbContext : DbContext
{
	public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options)
	{
		try
		{
			var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;
			if(databaseCreator != null)
			{
				if (!databaseCreator.CanConnect()) databaseCreator.Create();
				if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
			}
		}
		catch (Exception ex)
		{

			Console.WriteLine(ex.Message);
		}
	}

	public DbSet<Product> Products => Set<Product>();
}
