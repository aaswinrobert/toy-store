using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Toys Toys { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
        
    }
}
