using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data.ViewModels
{
    public class NewToysDropDownVM
    {

        public NewToysDropDownVM()
        {
            Shops = new List<Shops>();
        }
        public List<Shops> Shops { get; set; }
    }
}
