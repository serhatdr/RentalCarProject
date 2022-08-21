using Core.DataAcces.EntityFramework;
using DataAcces.Abstract;
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
    public class EfCarDal : EfEntityRepositoryBase<Car,RentalContext>,ICarDal
    {
        
    }
}
