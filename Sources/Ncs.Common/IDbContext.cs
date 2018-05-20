using System.Collections.Generic;

namespace Ncs.Common
{
    public interface IDbContext
    {
        IList<Product> GetAllProducts();

    }
}