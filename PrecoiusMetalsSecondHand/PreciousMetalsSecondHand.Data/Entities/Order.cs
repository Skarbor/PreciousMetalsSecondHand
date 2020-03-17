using System;
using System.Collections.Generic;
using System.Text;

namespace PrecoiusMetalsSecondHand.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
    }
}
