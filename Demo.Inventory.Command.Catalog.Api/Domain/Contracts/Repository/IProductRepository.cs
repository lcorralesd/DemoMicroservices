using Demo.Inventory.Command.Catalog.Api.Domain.Entities;

namespace Demo.Inventory.Command.Catalog.Api.Domain.Contracts.Repository;

public interface IProductRepository
{
    void Create(Product product);
    void Update(Product product);
    void Delete(int id);
}
