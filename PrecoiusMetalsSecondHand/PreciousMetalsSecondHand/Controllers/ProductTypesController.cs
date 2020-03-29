using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data;

namespace PreciousMetalsSecondHand.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private ProductTypesProvider _productTypesProvider;

        public ProductTypesController()
        {
                _productTypesProvider = new ProductTypesProvider();
        }

        public IActionResult GetAll()
        {
            return Ok(_productTypesProvider.GetAll());
        }
    }
}