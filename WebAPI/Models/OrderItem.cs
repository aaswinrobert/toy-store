using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            InverseOrderItemNavigation = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int ToyId { get; set; }
        public int? ToysId { get; set; }
        public int OrderId { get; set; }
        public int? OrderItemId { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderItem OrderItemNavigation { get; set; }
        public virtual Toy Toys { get; set; }
        public virtual ICollection<OrderItem> InverseOrderItemNavigation { get; set; }
    }
}
