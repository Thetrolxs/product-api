using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using product_api.Src.Data;
using product_api.Src.Interfaces;
using product_api.Src.Models;

namespace product_api.Src.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly DataContext _context;

        public ShopRepository(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task CreateShopAsync(Shop shop)
        {
            _context.Shops.Add(shop);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}