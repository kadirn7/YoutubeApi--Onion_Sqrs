using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Aplication.Features.Products.Queries.GetAllProducts;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Product : ControllerBase
    {
        private readonly IMediator mediator;
        public Product(IMediator mediator) 
        {
            this.mediator=mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var responce = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(responce);
        }
    }
}
