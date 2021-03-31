using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<Rentals>> GetAll();
        IDataResult<List<Rentals>> Get(int Id);
        IDataResult<List<Rentals>> GetReturnDate(int CarId);
        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
        IResult Update(Rentals rental);
    }
}
