using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PreciousMetalsSecondHand.Data.Context;
using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.Data.Concrete
{
    public class ProductsRepository
    {
        private ApplicationContext context;

        public ProductsRepository()
        {
            context = new ApplicationContext();
        }

        public Product Get(int id)
        {
            return context.Products.Single(product => product.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products;
        }

        public void Add(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
