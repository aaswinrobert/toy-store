using MVC.Data.Cart;
using MVC.Data.Services;
using MVC.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace MVC.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IToysService _coursesService;
        private readonly ShoppingCart _shoppingCart;
        private readonly IOrdersService _ordersService;
        private readonly IUserservice userservice;

        public OrdersController(IToysService coursesService, ShoppingCart shoppingCart, IOrdersService ordersService,IUserservice userservice)
        {
            _coursesService = coursesService;
            _shoppingCart = shoppingCart;
            _ordersService = ordersService;
            this.userservice = userservice;
            
        }


       // [Authorize(Roles ="Admin")]
        public async Task<IActionResult> Index()
        {
            string userId = this.userservice.GetUserId();
            var orders = await _ordersService.GetOrdersbyUserIdAsync(userId);
            return View(orders);
        }

        public async Task<IActionResult> Getallorder()
        {
            
            var orders = await _ordersService.GetAll();
            return View(orders);
        }


        public IActionResult ShoppingCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }

        public async Task<IActionResult> AddItemToShoppingCart(int id)
        {
            var item = await _coursesService.GetToysByIdAsync(id);

            if(item != null)
            {
                _shoppingCart.AddItemtoCart(item);

               
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await _coursesService.GetToysByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemFromCart(item);


            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> RemoveItemCompleteFromShoppingCart(int id)
        {
            var item = await _coursesService.GetToysByIdAsync(id);

            if (item != null)
            {
                _shoppingCart.RemoveItemCompleteFromCart(item);


            }
            return RedirectToAction(nameof(ShoppingCart));
        }





        public async Task<IActionResult> CompleteOrder()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            string userId = this.userservice.GetUserId();
            string userEmailAddress = " ";

            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);

            

            
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            await _shoppingCart.ClearShoppingCartAsync();



            return View(response);
        }


        public async Task<IActionResult> Checkout()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            string userId = this.userservice.GetUserId();
            string userEmailAddress = this.userservice.GetUser();

            await _ordersService.StoreOrderAsync(items, userId, userEmailAddress);
            await _shoppingCart.ClearShoppingCartAsync();

            return View(response);
        }


    }
}
