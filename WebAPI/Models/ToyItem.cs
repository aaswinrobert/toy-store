using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class ToyItem
    {
        public int ToyId { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual Toy Toy { get; set; }
    }
}
