﻿using Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByCategoryId(int id);
        List<Car> GetAllByDailyPrice(decimal min,decimal max);
    }
}