using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using Newtonsoft.Json;
using MVC.Data;

namespace MVC.Controllers
{
    public class ShopsController : Controller
    {
        private readonly ApplicationDbContext _context;

        HttpClient client = new HttpClient();
        string url = "http://localhost:28127/api/shops";


       
        public ShopsController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: StoresMVCCallAPI    
        public async Task<IActionResult> Index()
        {
                
            return View(JsonConvert.DeserializeObject<List<Shops>>(await client.GetStringAsync(url)).ToList());
        }

        // GET: StoresMVCCallWebAPI/Details/5    
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

              
            var store = JsonConvert.DeserializeObject<Shops>(await client.GetStringAsync(url + id));

            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // GET: StoresMVCCallWebAPI/Create    
        public IActionResult Create()
        {
            return View();
        }

        // POST: StoresMVCCallWebAPI/Create    
        // To protect from overposting attacks, enable the specific properties you want to bind to.    
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ShopImageURL,FullName,Desc")] Shops shops)
        {
            if (ModelState.IsValid)
            {
                   
                await client.PostAsJsonAsync<Shops>(url, shops);

                return RedirectToAction(nameof(Index));
            }
            return View(shops);
        }

        // GET: StoresMVCCallWebAPI/Edit/5    
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            

               
            var shops = JsonConvert.DeserializeObject<Shops>(await client.GetStringAsync(url + id));

            if (shops == null)
            {
                return NotFound();
            }
            return View(shops);
        }

        // POST: StoresMVCCallWebAPI/Edit/5    
        // To protect from overposting attacks, enable the specific properties you want to bind to.    
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ShopImageURL,FullName,Desc")] Shops shops)
        {
            if (id != shops.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Original code:    
                    //_context.Update(store);    
                    //await _context.SaveChangesAsync();    

                    // Consume API    
                    await client.PutAsJsonAsync<Shops>(url + id, shops);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StoreExists(shops.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(shops);
        }

        // GET: StoresMVCCallWebAPI/Delete/5    
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

                
            var store = JsonConvert.DeserializeObject<Shops>(await client.GetStringAsync(url + id));

            if (store == null)
            {
                return NotFound();
            }

            return View(store);
        }

        // POST: StoresMVCCallWebAPI/Delete/5    
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
               
            await client.DeleteAsync(url + id);

            return RedirectToAction(nameof(Index));
        }

        private bool StoreExists(int id)
        {
            return _context.Shops.Any(e => e.Id == id);
        }
    }
}