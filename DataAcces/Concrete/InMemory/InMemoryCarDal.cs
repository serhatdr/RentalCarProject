using DataAcces.Abstract;
using Entitites.Concrete;
using Entitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            //oracle,sql server/portgres, MongoDb
            _car = new List<Car>
            {
            new Car{Id=1, CategoryId=1,BrandId=1,ColorId=1,DailyPrice=1000,
                Description="new model 1",ModelYear=2022},
            new Car { Id = 2,CategoryId=2,BrandId = 2, ColorId = 2, DailyPrice = 2000,
                Description = "new model 2", ModelYear = 2022 },
            new Car { Id = 3, CategoryId = 3, BrandId = 3, ColorId = 3, DailyPrice = 3000,
                Description = "new model 3", ModelYear = 2022 },
            new Car { Id = 4, CategoryId = 4, BrandId = 4, ColorId = 4, DailyPrice = 4000,
                Description = "new model 4", ModelYear = 2022 },
            new Car { Id = 5, CategoryId = 5, BrandId = 5, ColorId = 5, DailyPrice = 5000,
                Description = "new model 5", ModelYear = 2022 },

        };

        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query
            Car carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            return _car.Where(c => c.CategoryId == categoryId).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(string colorId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}

