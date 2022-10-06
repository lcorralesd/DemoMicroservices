using Demo.Inventory.Command.Catalog.Api.Domain.Contracts.Repository;

namespace Demo.Inventory.Command.Catalog.Api.Infrastructure.Repository;

public class UnitOffWork : IUnitOfWork
{
    private readonly InventoryDbContext _inventoryDbContext;

    public UnitOffWork(InventoryDbContext inventoryDbContext) => _inventoryDbContext = inventoryDbContext;

    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await _inventoryDbContext.SaveChangesAsync(cancellationToken);
    }
}
