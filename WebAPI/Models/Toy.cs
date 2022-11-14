using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Toy
    {
        public Toy()
        {
            OrderItems = new HashSet<OrderItem>();
            ShoppingCartItems = new HashSet<ShoppingCartItem>();
            ShopsToys = new HashSet<ShopsToy>();
            ToyItems = new HashSet<ToyItem>();
        }

        public int Id { get; set; }
        public string ToyName { get; set; }
        public string ToyDescription { get; set; }
        public int ToyPrice { get; set; }
        public string ToyImageUrl { get; set; }
        public string Availability { get; set; }
        public int ToyCategory { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual ICollection<ShopsToy> ShopsToys { get; set; }
        public virtual ICollection<ToyItem> ToyItems { get; set; }
    }
}
