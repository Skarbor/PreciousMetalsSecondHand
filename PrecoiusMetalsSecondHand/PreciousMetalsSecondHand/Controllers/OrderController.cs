using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data;
using PreciousMetalsSecondHand.WebApiModels.Models;

namespace PreciousMetalsSecondHand.Controllers
{
    public class OrderController : Controller
    {
        private ProductTypesProvider _productTypesProvider;

        public OrderController()
        {
            _productTypesProvider = new ProductTypesProvider();
        }

        [HttpPost]
        public IActionResult Create(CreateOrderModel createOrderModel)
        {
            return null;
        }

        //public IActionResult Create()
        //{
        //    var model = new CreateOrderModel();
        //    model.AvailableProductNames = _productTypesProvider.GetAll().Select(productType => productType.Name);

        //    return View(model);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(CreateOrderModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return Ok();
        //    }

        //    return BadRequest();
        //}
    }
}