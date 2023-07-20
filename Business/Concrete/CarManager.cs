using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarService _carDal;
        private InMemoryCarDal ınMemoryCarDal;

        public CarManager(ICarService carDal)
        {
            _carDal = carDal;
        }

        public CarManager(InMemoryCarDal ınMemoryCarDal)
        {
            this.ınMemoryCarDal = ınMemoryCarDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }
    }
}
