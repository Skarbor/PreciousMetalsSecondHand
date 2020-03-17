using System;
using System.Collections.Generic;
using System.Text;

namespace PreciousMetalsSecondHand.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public Ore Ore { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
