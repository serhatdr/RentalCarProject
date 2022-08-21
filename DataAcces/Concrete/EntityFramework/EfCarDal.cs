using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentalContext context=new RentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Name = c.Name,
                                 Brand = b.Name,
                                 Color = co.Name,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description,

                             };
                return result.ToList();
            }
            
        }
    }
}
