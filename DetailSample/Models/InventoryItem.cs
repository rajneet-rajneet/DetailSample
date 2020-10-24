using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailSample.Models
{
    public enum OrderItemDetailType
    {
        Size,
        Flavor,
        Topping,
        Sauce,
        Cheese,
        Dough
    }

    public class InventoryItem
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OrderItemDetailType Type { get; set; }

        public InventoryItem Item { get; set; }

        public int QuantityRemaining { get; set; }

        public decimal PricePerUnit { get; set; }

        IEnumerable<OrderItemDetailType> OrderItemDetailTypes { get; set; }

    }
}
