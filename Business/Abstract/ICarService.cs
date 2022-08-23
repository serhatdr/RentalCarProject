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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByCategoryId(int id);
        IDataResult<List<Car>> GetAllByDailyPrice(decimal min,decimal max);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
    }
}
