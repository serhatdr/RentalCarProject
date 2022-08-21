using DataAcces.Abstract;
using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.DataAcces.EntityFramework;

namespace DataAcces.Concrete.EntityFramework
{
    public class EfColorDal :EfEntityRepositoryBase<Color, RentalContext>,IColorDal 
    {
        
    }
}
