﻿using ArtXchange.DataAccess.Data;
using ArtXchange.DataAccess.Repository.IRepository;
using ArtXchange.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArtXchange.DataAccess.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly ApplicationDbContext _db;

        public ShoppingCartRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}
