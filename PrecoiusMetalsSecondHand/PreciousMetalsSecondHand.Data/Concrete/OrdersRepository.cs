using System;
using System.Collections.Generic;
using PreciousMetalsSecondHand.Data.Context;
using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.Data.Concrete
{
    public class OrdersRepository
    {
        private ApplicationContext context;

        public OrdersRepository()
        {
            context = new ApplicationContext();
        }

        public void AddTestData()
        {
            IList<Order> orders = new List<Order>();

            var order = new Order();
            order.CreatedDate = DateTime.Now;
            order.Description = "złota moneta";
            order.PurchaserPhoneNumber = "660332370";
            order.PurchaserEmail = "adamwojcik@gmail.com";
            order.ProductTypeId = 1;
            order.Price = 7700;
            order.Type = OrderType.Buy;
            order.Location = "Kraków";

            var order2 = new Order();
            order2.CreatedDate = DateTime.Now;
            order2.Description = "Krugerand";
            order2.PurchaserPhoneNumber = "660332370";
            order2.PurchaserEmail = "adamwojcik@gmail.com";
            order2.ProductTypeId = 1;
            order2.Price = 7700;
            order2.Type = OrderType.Sell;
            order2.Location = "Warszawa";

            var order3 = new Order();
            order3.CreatedDate = DateTime.Now;
            order3.Description = "złota moneta";
            order3.PurchaserPhoneNumber = "660332370";
            order3.PurchaserEmail = "adamwojcik@gmail.com";
            order3.ProductTypeId = 2;
            order3.Price = 7700;
            order3.Type = OrderType.Buy;
            order3.Location = "Tokyo";

            var order4 = new Order();
            order4.CreatedDate = DateTime.Now;
            order4.Description = "złota moneta";
            order4.PurchaserPhoneNumber = "660332370";
            order4.PurchaserEmail = "adamwojcik@gmail.com";
            order4.ProductTypeId = 3;
            order4.Price = 7700;
            order4.Type = OrderType.Sell;
            order4.Location = "Wrocław";

            orders.Add(order);
            orders.Add(order2);
            orders.Add(order3);
            orders.Add(order4);

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders;
        }
    }
}
