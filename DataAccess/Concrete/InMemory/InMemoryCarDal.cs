using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car { CarId = 1, BrandId = 1, BrandName = "Toyota", CarName = "Corolla", ColorId = 1, ColorName = "Gray",
                    DailyPrice = 15, Description = "Temiz Araba", ModelYear = 2023 }
                new Car { CarId = 2,BrandId= 1,BrandName= "AlfaRomeo",CarName="Guilette",ColorId=2,ColorName="White",DailyPrice=7, Description="Genç sürücüden ucuza",ModelYear=2015}
            };
            }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
        Car carToDelete=_cars.SingleOrDefault(c=>c.BrandId== car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public List<Car> GetAllByCar(int carId)
        {
            return _cars.Where(c=>c.CarId==carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            carToUpdate.CarName=car.CarName;
            carToUpdate.BrandName=car.BrandName;
            carToUpdate.CarId=car.CarId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ColorName=car.ColorName;

        }
    }
}
