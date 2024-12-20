﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Project5MyApiNightContext context) : base(context)
        {
        }

        public int GetProductCount()
        {
            var context = new Project5MyApiNightContext();
            int value = context.Products.Count();
            return value;
        }
    }
}
