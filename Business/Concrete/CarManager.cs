using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public Car Add(Car car)
        {
            if (car.CarName.Length <= 2)
            {
                Console.WriteLine("Araba adı minumum iki karakterli olmalıdır!");
            }
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Günlük fiyat sıfırdan büyük olmalıdır!");
            }
            _carDal.Add(car);
            Console.WriteLine("Başarıyla Eklendi");
            return car;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(c => c.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(c => c.ColorId == Id);
        }
    }
}
