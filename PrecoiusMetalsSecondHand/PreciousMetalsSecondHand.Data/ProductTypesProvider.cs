using System.Collections.Generic;
using System.Linq;
using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.Data
{
    public class ProductTypesProvider
    {
        public ProductType Get(int id)
        {
            return _productTypes.Single(productType => productType.Id == id);
        }

        public IEnumerable<ProductType> GetAll()
        {
            return _productTypes;
        }

        private readonly IList<ProductType> _productTypes = new List<ProductType>
        {
            new ProductType {Id = 1, Name = "Krugerrand", Category = Category.Coin, Ore = Ore.Gold, Description = "Krugerrand", ImagePath = "./assets/images/kruggerand_coin.jpg"},
            new ProductType {Id = 2, Name = "Kanadyjski liść", Category = Category.Coin, Ore = Ore.Gold, Description = "Kanadyjski liść", ImagePath = "./assets/images/kanadyjski_lisc_coin.jpg"},
            new ProductType {Id = 3, Name = "Złoty Orzeł", Category = Category.Coin, Ore = Ore.Silver, Description = "Złoty orzeł", ImagePath = "./assets/images/srebrny_amerykanski_orzel.jpg"},
        };
    }
}
