using ArtXchange.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtXchange.DataAccess.Repository.IRepository
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails obj);
    }
}
