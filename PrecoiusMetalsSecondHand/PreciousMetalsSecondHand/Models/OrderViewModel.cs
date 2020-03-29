using System;
using PreciousMetalsSecondHand.Data.Entities;
using static PreciousMetalsSecondHand.Data.Entities.OrderType;

namespace PreciousMetalsSecondHand.Models
{
    public class OrderViewModel
    {
        public string OrderType { get; set; }
        public string Location { get; set; }
        public string ProductName { get; set; }
        public string ProductImagePath { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string PurchaserPhoneNumber { get; set; }
        public string PurchaserEmail { get; set; }
        public DateTime CreatedDate { get; set; }

        public OrderViewModel(Order order, ProductType productType)
        {
            if (order.Type == Sell) OrderType = "Sell";
            if (order.Type == Buy) OrderType = "Buy";

            Location = order.Location;
            ProductName = productType.Name;
            //ProductImagePath = productType.ImagePath;
            ProductDescription = productType.Description;
            Price = order.Price;
            PurchaserPhoneNumber = order.PurchaserPhoneNumber;
            PurchaserEmail = order.PurchaserEmail;
            CreatedDate = order.CreatedDate;
        }
    }
}
