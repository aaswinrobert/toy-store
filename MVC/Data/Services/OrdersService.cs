﻿using MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext _context;

        public OrdersService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Order>> GetOrdersbyUserIdAsync(string userId)
        {
            var orders = await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Toys).Where(n => n.UserId == userId).ToListAsync();
            return orders;
        }

        public async Task<List<Order>> GetAll()
        {
            var orders = await _context.Orders.ToListAsync();
            return orders;
        }


        public async Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach(var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    ToyID = item.Toys.Id,
                    OrderId = order.Id,
                    Price = item.Toys.ToyPrice,
                };
               await _context.OrderItems.AddAsync(orderItem);
            }
            await _context.SaveChangesAsync()
;        }

       
    }
}
