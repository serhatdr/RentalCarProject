using Core.DataAcces;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Abstract
{
    public interface ICarDal : IEntityRepostiory<Car>
    {
        List<CarDetailDto> GetCarDetails();
    }
}
