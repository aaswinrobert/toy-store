using MVC.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Shops:IEntityBase
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Shop Image URL")]
        [Required(ErrorMessage = "Required Shop Image")]
        public string ShopImageURL { get; set; }

        [Display(Name = "Shop Name")]
        [Required(ErrorMessage = "Required Shop Name")]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "The Name must contain at least 2 characters")]
        public string FullName { get; set; }

        [Display(Name = "Shop Description")]
        [Required(ErrorMessage = "Required Description")]
        public string Desc { get; set; }


        public List<ToyItems> ToyItems { get; set; }

        public List<Toys> Toys { get; set; }
    }
}
