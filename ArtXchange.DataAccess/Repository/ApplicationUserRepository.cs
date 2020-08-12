using ArtXchange.DataAccess.Data;
using ArtXchange.DataAccess.Repository.IRepository;
using ArtXchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtXchange.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        //public void Update(ApplicationUser applicationUser)
        //{
        //    var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == applicationUser.Id);
        //    if(objFromDb != null)
        //    {
        //        objFromDb.Name = applicationUser.Name;
        //    }
        //}
    }
}
