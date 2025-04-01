using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_api.Src.DTOs
{
    public class ProductDTO
    {
        public string Name {get; set;} = string.Empty;
        public float Price {get; set;}
    }
}