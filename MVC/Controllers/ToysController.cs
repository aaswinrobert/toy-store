using MVC.Data;
using MVC.Data.Services;
using MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PagedList.Mvc;
using PagedList;
using Microsoft.AspNetCore.Authorization;

namespace MVC.Controllers
{
    public class ToysController : Controller
    {
        private readonly IToysService _service;

        public ToysController(IToysService service)
        {
            _service = service;
        }
        
        public async Task<IActionResult> Index( int? i)
        {
            var allToys = await _service.GetAllAsync();
            return View(allToys.ToPagedList(i ?? 1,10));
        }

        [Authorize]
        public async Task<IActionResult> NotThere()
        {
            var allToys = await _service.GetAllAsync();
            return View("NotThere");
        }

        public async Task<IActionResult> Filter(string searchString)
        {

            var allToys = await _service.GetAllAsync();


            if (!string.IsNullOrEmpty(searchString))
            {

                var filteredResult = allToys.Where(n => n.ToyName.ToLower().Contains(searchString.ToLower()) || n.ToyDescription.ToLower().Contains(searchString.ToLower())).ToList();
                if (filteredResult.Count>0)
                {
                    return View("Index", filteredResult);
                }
                else
                {
                    return View("NotThere");
                }
                
            }

            return View("Index", allToys);
            
        }



        [Authorize]
        public async Task<IActionResult> Details (int id)
        {
            var ToyDetail = await _service.GetToysByIdAsync(id);
            return View(ToyDetail);
        }

        [Authorize (Roles ="Admin")]
        public async Task<IActionResult> Create()
        {
            var ToysDropDownData = await _service.GetNewToysDropDownValues();

            ViewBag.Shops = new SelectList(ToysDropDownData.Shops, "ToyId", "FullName");
            
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(newToysVM shops)
        {
            if (!ModelState.IsValid)
            {
                var ToysDropDownData = await _service.GetNewToysDropDownValues();
                ViewBag.Shops = new SelectList(ToysDropDownData.Shops, "ToyId", "FullName");
                return View(shops);
            }

            await _service.AddNewToysAsync(shops);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Edit(int id)
        {

            var ToyDetails = await _service.GetToysByIdAsync(id);
            if (ToyDetails == null) return View("NotFound");


            var response = new newToysVM()
            {
                ToyId = ToyDetails.Id,
                ToyName = ToyDetails.ToyName,
                ToyDescription = ToyDetails.ToyDescription,
                ToyPrice = ToyDetails.ToyPrice,
                Availability = ToyDetails.Availability,
                ToyImageURL = ToyDetails.ToyImageURL,
                ToyCategory = ToyDetails.ToyCategory,
                //ShopIds = ToyDetails.ToyItems.Select(n => n.ShopID).ToList(),
            };

            var ToysDropDownData = await _service.GetNewToysDropDownValues();

            ViewBag.Shops = new SelectList(ToysDropDownData.Shops, "ToyId", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, newToysVM ToysVM)
        {


            if (id != ToysVM.ToyId) return View("NotFound");

            ////if (!ModelState.IsValid)
            //{
            //    var ToysDropDownData = await _service.GetNewToysDropDownValues();
            //    //ViewBag.Shops = new SelectList(ToysDropDownData.Shops, "ToyId", "FullName");
            //    return View(ToysVM);
            //}

            await _service.UpdateToysAsync(ToysVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
