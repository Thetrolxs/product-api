using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using product_api.Src.Models;

namespace product_api.Src.DTOs
{
    public class ShopDTO
    {
        public string Name {get; set;} = string.Empty;
        public string City {get; set;} = string.Empty;
        public List<Product> products {get; set;} = new();
    }
}