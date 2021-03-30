using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetailDtos()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             join color in context.Colors
                             on c.Id equals color.Id
                             select new CarDetailDto
                             {
                               Id =c.Id , 
                               CarName=c.CarName,
                               DailyPrice = c.DailyPrice, 
                               BrandName=b.BrandName,
                               ColorName=color.ColorName
                             };
                return result.ToList();



            }
           
        }
    }
}
