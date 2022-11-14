using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class ShoppingCartItem
    {
        public int Id { get; set; }
        public int? ToysId { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

        public virtual Toy Toys { get; set; }
    }
}
