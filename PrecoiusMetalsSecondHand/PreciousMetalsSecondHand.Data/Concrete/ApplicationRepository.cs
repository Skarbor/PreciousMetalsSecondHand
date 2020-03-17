using System;
using System.Collections.Generic;
using System.Text;
using PrecoiusMetalsSecondHand.Data.Context;
using PrecoiusMetalsSecondHand.Data.Entities;

namespace PrecoiusMetalsSecondHand.Data.Concrete
{
    public class ApplicationRepository
    {
        private ApplicationContext context;

        public ApplicationRepository()
        {
            context = new ApplicationContext();
        }

        public void AddTestData()
        {
            IList<Order> orders = new List<Order>();
            for (int i = 0; i < 3; i++)
            {
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
