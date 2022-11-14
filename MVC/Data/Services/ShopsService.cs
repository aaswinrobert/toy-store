using MVC.Data.Base;
using MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data.Services
{
    public class ShopsService :EntityBaseRepository<Shops>, IShopsService
    {
      

        public ShopsService(ApplicationDbContext context) : base(context) { }
        
     
    }
}
