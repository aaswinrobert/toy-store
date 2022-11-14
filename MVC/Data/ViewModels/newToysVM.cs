using MVC.Data;
using MVC.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class newToysVM
    {  
        public int ToyId { get; set; }

        [Display(Name = "Toy Name")]
        [Required(ErrorMessage = "Name is required")]

        public string ToyName { get; set; }

        [Display(Name = "Toy Description")]
        [Required(ErrorMessage = "Description is required")]

        public string ToyDescription { get; set; }

        [Display(Name = "Toy Price")]
        [Required(ErrorMessage = "Price is required")]
        public int ToyPrice { get; set; }


        [Display(Name = "Toy Image URL")]
        [Required(ErrorMessage = "Toy Image URL required")]
        public string ToyImageURL { get; set; }

        [Display(Name = "Availability")]
        [Required(ErrorMessage = "Availability is required")]
        public string Availability { get; set; }

        [Display(Name = "Toy Category")]
        [Required(ErrorMessage = "Toy Category required")]
        public ToyCategory ToyCategory { get; set; }



        //[Display(Name = "Shops associated with us")]
        //[Required(ErrorMessage = "At least one shop is required")]
        public List<int> ShopIds { get; set; }


        public List<Shops> Shops { get; set; }


    }
}
