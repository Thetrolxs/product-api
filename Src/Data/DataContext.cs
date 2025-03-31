using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using product_api.Src.Models;

namespace product_api.Src.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
  
        public DbSet<Product> Products {get; set;}
        public DbSet<Shop> Shops {get; set;}

    }
}