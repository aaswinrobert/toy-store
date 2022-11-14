using System;
using System.Collections.Generic;

#nullable disable

namespace WebAPI.Models
{
    public partial class Shop
    {
        public Shop()
        {
            ShopsToys = new HashSet<ShopsToy>();
            ToyItems = new HashSet<ToyItem>();
        }

        public int Id { get; set; }
        public string ShopImageUrl { get; set; }
        public string FullName { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<ShopsToy> ShopsToys { get; set; }
        public virtual ICollection<ToyItem> ToyItems { get; set; }
    }
}
