using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrecoiusMetalsSecondHand.Data.Concrete;

namespace PrecoiusMetalsSecondHand.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationRepository applicationRepository;
        public HomeController()
        {
            applicationRepository = new ApplicationRepository();
        }
        public IActionResult Index()
        {
            var orders = applicationRepository.GetAll();
            return View(orders);
        }
    }
}