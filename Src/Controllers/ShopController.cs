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
    public class ShopController : Controller
    {
        private readonly IShopRepository _shopRepository;

        public ShopController(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetShops()
        {
            var products = await _shopRepository.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShop([FromBody] ShopDTO shopDTO)
        {
            var shop = new Shop { Name = shopDTO.Name, City = shopDTO.City, Products = shopDTO.products };
            await _shopRepository.CreateShopAsync(shop);
            return Ok(shop);
        }
    }
}