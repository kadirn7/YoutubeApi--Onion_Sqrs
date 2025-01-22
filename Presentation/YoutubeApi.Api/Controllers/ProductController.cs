using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Aplication.Features.Products.Command.CreateProduct;
using YoutubeApi.Aplication.Features.Products.Command.DeleteProduct;
using YoutubeApi.Aplication.Features.Products.Command.UpdateProduct;
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
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPost("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var request = new DeleteProductCommandRequest { Id = id };
                await mediator.Send(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
