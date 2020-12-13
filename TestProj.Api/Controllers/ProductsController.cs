using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestProj.AppServices.Interfaces;

namespace TestProj.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly IProductService _service;

        public ProductsController(ILogger<ProductsController> logger,
                                  IProductService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("{id=1}")] //Set default value for example only, it should be [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.GetById(id));
        }
    }
}
