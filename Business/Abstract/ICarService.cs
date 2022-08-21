using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface ICarService
    {
         
        void Delete(Car car);   
        void Update(Car car);
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetAllByDailyPrice(decimal min,decimal max);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
        Car GetById(int id);
        IResult Add(Car car);
    }
}
