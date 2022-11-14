using MVC.Data.Base;
using MVC.Data.ViewModels;
using MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data.Services
{
    public class ToysService : EntityBaseRepository<Toys>, IToysService
    {
        private readonly ApplicationDbContext _context;
        public ToysService(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewToysAsync(newToysVM data)
        {
            var newToys = new Toys()
            {
                ToyName = data.ToyName,
                ToyDescription = data.ToyDescription,
                ToyPrice = data.ToyPrice,
                ToyCategory = data.ToyCategory,
                Availability = data.Availability,
                ToyImageURL = data.ToyImageURL,
                

            };
            await _context.Toys.AddAsync(newToys);
            await _context.SaveChangesAsync();

            //foreach (var ShopId in data.ShopIds)
            //{
            //    var newToyShop = new ToyItems()
            //    {
            //        ToyID = newToys.Id,
            //        ShopID = ShopId
            //    };
            //    await _context.ToyItems.AddAsync(newToyShop);
            //}
            await _context.SaveChangesAsync();

        }

        public async Task<NewToysDropDownVM> GetNewToysDropDownValues()
        {

            var response = new NewToysDropDownVM()
            {
                Shops = await _context.Shops.OrderBy(n => n.FullName).ToListAsync(),
            };
            
            return response;
        }

    public async Task<Toys> GetToysByIdAsync(int id)
    {
        var pianoCourseDetails = await _context.Toys.Include(am => am.ToyItems).ThenInclude(a => a.Shops).FirstOrDefaultAsync(n => n.Id == id);

        return pianoCourseDetails;
    }

        public async Task UpdateToysAsync(newToysVM data)
        {

            var dbToy = await _context.Toys.FirstOrDefaultAsync(n => n.Id == data.ToyId);

            if(dbToy != null)
            {

                dbToy.ToyName = data.ToyName;
                dbToy.ToyDescription = data.ToyDescription;
                dbToy.ToyPrice = data.ToyPrice;
                dbToy.ToyCategory = data.ToyCategory;
                dbToy.Availability = data.Availability;
                dbToy.ToyImageURL = data.ToyImageURL;


                
               
                await _context.SaveChangesAsync();

            }

            var existingAuthorDb = _context.ToyItems.Where(n => n.ToyID == data.ToyId).ToList();
            _context.ToyItems.RemoveRange(existingAuthorDb);
            await _context.SaveChangesAsync();


            foreach (var ShopId in data.ShopIds)
            {
                var newToyShop = new ToyItems()
                {
                    ToyID = data.ToyId,
                    ShopID = ShopId
                };
                await _context.ToyItems.AddAsync(newToyShop);
            }
            await _context.SaveChangesAsync();

        }
    }
}
