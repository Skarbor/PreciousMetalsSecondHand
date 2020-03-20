using System;
using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.Models
{
    public class OrderViewModel
    {
        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string PurchaserPhoneNumber { get; set; }
        public string PurchaserEmail { get; set; }
        public DateTime CreatedDate { get; set; }

        public OrderViewModel(Order order, ProductType productType)
        {
            ProductName = productType.Name;
            ProductImagePath = productType.ImagePath;
            ProductDescription = productType.Description;
            Price = order.Price;
            PurchaserPhoneNumber = order.PurchaserPhoneNumber;
            PurchaserEmail = order.PurchaserEmail;
            CreatedDate = order.CreatedDate;
        }
    }
}
