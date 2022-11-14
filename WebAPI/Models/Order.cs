using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string UserId { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
