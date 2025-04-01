using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using product_api.Src.DTOs;
using product_api.Src.Interfaces;
using product_api.Src.Models;

namespace product_api.Src.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository repository) 
        {
             _productRepository = repository; 
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductDTO productDTO)
        {
            var product = new Product { Name = productDTO.Name, Price = productDTO.Price };
            await _productRepository.CreateProductAsync(product);
            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productRepository.GetProductByIdAsync(id);
            if (product == null) return NotFound("Producto no encontrado");
            return Ok(product);
        }
    }
}