using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCore_WithBugs.Models
{
    public static class ProductDb
    {
        public static List<Product> GetAllProducts(ProductContext _context)
        {
            return _context.Product.ToList();
        }

        public static Product AddProduct(ProductContext context, Product prod)
        {
            context.Product.Add(prod);
            context.SaveChanges();
            return prod;
        }
    }
}
