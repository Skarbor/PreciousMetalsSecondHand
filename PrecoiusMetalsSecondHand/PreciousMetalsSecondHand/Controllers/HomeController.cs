using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data;
using PreciousMetalsSecondHand.Data.Concrete;
using PreciousMetalsSecondHand.Models;

namespace PreciousMetalsSecondHand.Controllers
{
    public class HomeController : Controller
    {
        private readonly OrdersRepository _ordersRepository;
        private ProductTypesProvider _productTypesProvider;

        public HomeController()
        {
            _ordersRepository = new OrdersRepository();
            _productTypesProvider = new ProductTypesProvider();
            _ordersRepository.AddTestData();
        }
        public IActionResult Index()
        {
            var orders = _ordersRepository.GetAll();
            var ordersViewModels = orders.Select(order =>
                new OrderViewModel(order, _productTypesProvider.Get(order.ProductTypeId)));

            return View(ordersViewModels);
        }
    }
}