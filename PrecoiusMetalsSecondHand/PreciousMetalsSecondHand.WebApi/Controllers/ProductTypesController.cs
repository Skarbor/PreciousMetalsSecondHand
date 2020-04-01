using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data;

namespace PreciousMetalsSecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductTypesController : ControllerBase
    {
        private ProductTypesProvider _productTypesProvider;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productTypesProvider.GetAll());
        }
    }
}
