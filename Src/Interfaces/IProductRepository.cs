using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using product_api.Src.DTOs;
using product_api.Src.Models;

namespace product_api.Src.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task CreateProductAsync(Product product);  
    }
}