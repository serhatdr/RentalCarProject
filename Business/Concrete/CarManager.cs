using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAcces.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            //business codes
             
            if(car.Name.Length<2)
            {
                return new ErrorResult(Messages.CarNameInValid);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if(DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);   
        }

        public IDataResult<List<Car>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.CategoryId == id));
        }

        public IDataResult<List<Car>> GetAllByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListed);
        }

         public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        
    }
}
