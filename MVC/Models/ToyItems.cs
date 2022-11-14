using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ToyItems
    {

        public int ToyID { get; set; }
        public Toys Toys { get; set; }

        public int ShopID { get; set; }
        public Shops Shops { get; set; }
    }
}
