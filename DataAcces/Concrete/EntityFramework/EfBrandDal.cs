﻿using DataAcces.Abstract;
using Entitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentalContext context = new RentalContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentalContext context = new RentalContext())
            {
                var deletedEntity = context.Entry(entity);
                    deletedEntity.State= EntityState.Deleted;
                    context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentalContext context = new RentalContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);

            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentalContext context = new RentalContext())
            {
                return filter ==null
                    ?context.Set<Brand>().ToList()
                    :context.Set<Brand>().Where(filter).ToList();

            }
        }

        public void Update(Brand entity)
        {
            using (RentalContext context = new RentalContext())
            {
                var updatedContext = context.Entry(entity);
                updatedContext.State= EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}