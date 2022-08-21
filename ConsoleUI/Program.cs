using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using DataAcces.Concrete.InMemory;
using System;

namespace ConsoleUI

{
    class Program
    {
        static void Main(string[] args)
        {
            CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName + "" + category.CategoryId);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(car.Id + "," + car.BrandId + "," + car.ModelYear + "," + car.ColorId);
            }

            foreach (var car in carManager.GetAllByDailyPrice(20, 100))
            {
                Console.WriteLine(car.Id + "," + car.BrandId + "," + car.ModelYear + "," + car.ColorId);
            }
        }
    }
}