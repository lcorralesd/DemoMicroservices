namespace Demo.Inventory.Command.Catalog.Api.Domain.Contracts.Repository;

public interface IUnitOfWork
{
    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
