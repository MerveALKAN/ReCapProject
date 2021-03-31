using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<2)
            {
                return new ErrorResult(Messages.BrandInValid);
                
               
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);      
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true);
        }

        public IDataResult<Brand>Get(int Id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == Id));
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public Brand GetById(int Id)
        {
            return _brandDal.Get(b => b.Id == Id);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true);
        }

       IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
