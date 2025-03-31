using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product_api.Src.Models
{
    public class Shop
    {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty;
        public string City {get; set;} = string.Empty;
    }
}