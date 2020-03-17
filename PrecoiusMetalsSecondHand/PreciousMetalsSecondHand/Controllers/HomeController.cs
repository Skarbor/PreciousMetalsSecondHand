using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PreciousMetalsSecondHand.Data.Concrete;

namespace PreciousMetalsSecondHand.Controllers
{
    public class HomeController : Controller
    {
        private OrdersRepository _ordersRepository;
        public HomeController()
        {
            _ordersRepository = new OrdersRepository();
        }
        public IActionResult Index()
        {
            var orders = _ordersRepository.GetAll();
            return View(orders);
        }
    }
}