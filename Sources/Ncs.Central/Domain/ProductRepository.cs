using Ncs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncs.Central.Domain
{
    class ProductRepository : IProductRepository
    {
        IDbContext dbContext;
        public ProductRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IList<Product> GetProducts()
        {
            return dbContext.GetAllProducts();
        }
    }
}
