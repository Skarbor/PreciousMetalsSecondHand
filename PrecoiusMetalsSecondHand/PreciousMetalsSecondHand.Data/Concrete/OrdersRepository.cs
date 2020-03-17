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
            for (int i = 0; i < 3; i++)
            {
                var order = new Order();
                order.CreatedDate = DateTime.Now;
                order.Description = "złota moneta";
                order.PurchaserPhoneNumber = "660332370";
                order.PurchaserEmail = "adamwojcik@gmail.com";

                var product = new Product();
                product.Category = Category.Coin;
                product.Ore = Ore.Silver;
                product.Name = "Krugerand";
                product.Description ="Krugerand "

                orders.Add(new Order(){CreatedDate = DateTime.Now, Description = "Item " + i});
            }

            context.Orders.AddRange(orders);
            context.SaveChanges();
        }

        public IEnumerable<Order> GetAll()
        {
            return context.Orders;
        }
    }
}
