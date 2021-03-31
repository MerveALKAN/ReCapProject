using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public   interface ICustomerService
    {

        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> Get(int Id);
        IResult Add(Customers customer);
        IResult Delete(Customers customer);
        IResult Update(Customers customer);
    }
}
