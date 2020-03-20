using System;

namespace PreciousMetalsSecondHand.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string PurchaserPhoneNumber { get; set; }
        public string PurchaserEmail { get; set; }
    }
}
