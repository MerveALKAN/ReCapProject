using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear=2018, Description="Mercedes" },
            new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 100, ModelYear = 2017, Description = "Fiat" },
            new Car { Id = 3, BrandId = 2, ColorId = 2, DailyPrice = 250, ModelYear = 2015, Description = "Bmw" },
            new Car { Id = 4, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 2017, Description = "Peugeot" },
            new Car { Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 170, ModelYear = 2016, Description = "Audi" },
           

            };
    }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == c.Id);
            _cars.Remove(carToDelete);


        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByCategory(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void GetCarsByBrandId(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == c.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
