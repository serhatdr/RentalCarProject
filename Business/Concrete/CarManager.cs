using Business.Abstract;
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

        public void Add(Car car)
        {
             _carDal.Add(car);
        }
        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public List<Car> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?
            return _carDal.GetAll();   
        }

        public List<Car> GetAllByCategoryId(int id)
        {
            return _carDal.GetAll(c=>c.CategoryId==id);
        }

        public List<Car> GetAllByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c=>c.DailyPrice>=min && c.DailyPrice<=max);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

         public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        
    }
}
