using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class ShopsToy
    {
        public int ShopsId { get; set; }
        public int ToysId { get; set; }

        public virtual Shop Shops { get; set; }
        public virtual Toy Toys { get; set; }
    }
}
