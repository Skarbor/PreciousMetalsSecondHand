using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.WebApiModels.Models
{
    public class CreateOrderModel
    {
        public OrderType OrderType { get; set; }
        public int ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public string PurchaserPhoneNumber { get; set; }
        public string PurchaserEmail { get; set; }
    }
}
