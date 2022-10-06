using Demo.Inventory.Command.Catalog.Api.Application.Catalog.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Inventory.Command.Catalog.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ISender _sender;

    public ProductsController(ISender sender) => _sender = sender;

    [HttpPost]
    public async Task<IResult> CreateProduct(CreateProductCommand command) =>
        Results.Ok(await _sender.Send(command));

}
