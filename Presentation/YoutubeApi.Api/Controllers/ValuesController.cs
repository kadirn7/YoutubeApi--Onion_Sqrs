using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using YoutubeApi.Aplication.Interfaces.Repositories.UnitOfWorks;
using YoutubeApi.Persistence.UnitOfWorks;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            unitOfWork = unitOfWork;
        }

        
        
    }
}
