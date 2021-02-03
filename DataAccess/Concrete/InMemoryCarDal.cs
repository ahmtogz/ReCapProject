﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>{
                new Car {Id=1, BrandId=1, ColorId=2, ModelYear="2018", DailyPrice=23000, Description="Benzin"},
                new Car {Id=2, BrandId=1, ColorId=2, ModelYear="2019", DailyPrice=32000, Description="Benzin"},
                new Car {Id=3, BrandId=2, ColorId=1, ModelYear="2018", DailyPrice=26000, Description="Electric"},
                new Car {Id=4, BrandId=3, ColorId=1, ModelYear="2018", DailyPrice=14000, Description="Dizel"},
                new Car {Id=5, BrandId=2, ColorId=3, ModelYear="2020", DailyPrice=30000, Description="Dizel"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
