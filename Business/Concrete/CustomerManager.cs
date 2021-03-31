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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult Add(Customers customer)
        {
            _customerdal.Add(customer);
            return new Result(true);
        }

        public IResult Delete(Customers customer)
        {
            _customerdal.Delete(customer);
            return new Result(true);
        }

        public IDataResult<Customers> Get(int Id)
        {
            return new SuccessDataResult<Customers> (_customerdal.Get(c => c.UserId == Id));
        }

        public IDataResult<List<Customers>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Customers>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Customers>>(_customerdal.GetAll(),Messages.CustomersListed);
        }

        public IResult Update(Customers customer)
        {
            _customerdal.Update(customer);
                return new Result(true);
        }
    }
}
