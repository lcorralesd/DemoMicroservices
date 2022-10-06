using MediatR;

namespace Demo.Inventory.Command.Catalog.Api.Application.Catalog.CreateProduct;

public class CreateProductCommand : IRequest
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
