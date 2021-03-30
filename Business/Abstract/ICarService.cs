using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICarService
    {
        IDataResult<List<Car>>  GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<List<Car>> GetCarsByColorId(int Id);
        IResult Add(Car car);
        IDataResult<List<CarDetailDto>> GetCarDetails();

      


    }
}
