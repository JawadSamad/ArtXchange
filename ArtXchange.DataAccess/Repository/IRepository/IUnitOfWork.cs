using ArtXchange.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArtXchange.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICompanyRepository Company { get; }
        IProductRepository Product { get; }
        ISP_Call SP_Call { get; }
        IApplicationUserRepository ApplicationUser { get; }

        void Save();
    }
}
