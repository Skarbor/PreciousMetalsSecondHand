using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data.Concrete;
using PreciousMetalsSecondHand.WebApiModels.Models;

namespace PreciousMetalsSecondHand.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController: ControllerBase
    {
        private OrdersRepository _ordersRepository;

        public OrdersController()
        {
            _ordersRepository = new OrdersRepository();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ordersRepository.GetAll());
        }

        public void CreateOrder(CreateOrderModel createOrderModel)
        {
            return;
        }
    }
}
