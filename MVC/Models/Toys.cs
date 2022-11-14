using MVC.Data;
using MVC.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Toys:IEntityBase
    {  
        [Key]
        public int Id { get; set; }

        public string ToyName { get; set; }

        public string ToyDescription { get; set; }

        public int ToyPrice { get; set; }

        public string ToyImageURL { get; set; }

        public string Availability { get; set; }

        public ToyCategory ToyCategory { get; set; }


        
        public List<ToyItems> ToyItems { get; set; }

  
        public List<Shops> Shops { get; set; }


    }
}
