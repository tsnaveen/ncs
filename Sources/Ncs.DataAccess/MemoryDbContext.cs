using Ncs.Common;
using System;
using System.Collections.Generic;

namespace Ncs.DataAccess
{
    public class MemoryDbContext : IDbContext
    {
        public IList<Product> GetAllProducts()
        {
            ProductCategory sareeCategory = new ProductCategory() { id = 1, name = "saree" };
            ProductCategory punjabiCategory = new ProductCategory() { id = 2, name = "punjabi" };
            return new List<Product>()
            {
                new Product() {id= 1, name= "bengali cotton saree", description= "bengali cotton saree", category= sareeCategory },
                new Product() {id= 2, name= "silk saree", description= "silk saree", category= sareeCategory },
                new Product() {id= 3, name= "traditional punjabi", description= "traditional punjabi", category= punjabiCategory },
                new Product() {id= 4, name= "jalandhar punjabi", description= "jalandhar", category= punjabiCategory },
            };
        }
    }
}
