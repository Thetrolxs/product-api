using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using product_api.Src.Models;

namespace product_api.Src.Interfaces
{
    public interface IShopRepository
    {
        Task CreateShopAsync(Shop shop);
        Task<IEnumerable<Product>> GetProducts();
    }
}