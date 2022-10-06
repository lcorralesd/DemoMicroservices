using Demo.Inventory.Command.Catalog.Api.Domain.Contracts.Repository;
using Demo.Inventory.Command.Catalog.Api.Domain.Entities;

namespace Demo.Inventory.Command.Catalog.Api.Infrastructure.Repository;

public class ProductRepository : IProductRepository
{
    private readonly InventoryDbContext _inventoryDbContext;

    public ProductRepository(InventoryDbContext inventoryDbContext) => _inventoryDbContext = inventoryDbContext;

    public void Create(Product product) 
    {
        _inventoryDbContext.Products.Add(product);
    }
    public void Delete(int id) => throw new NotImplementedException();
    public void Update(Product product) => throw new NotImplementedException();
}
