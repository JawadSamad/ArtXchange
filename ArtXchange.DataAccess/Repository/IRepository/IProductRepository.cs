using ArtXchange.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtXchange.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
