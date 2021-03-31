using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rentals rental)
        {
            if (rental.ReturnDate == null)
            {
                _rentalDal.Add(rental);
                return new ErrorResult(Messages.CarMustReturn);
            }


            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rentals rental)
        {

            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Rentals>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rentals>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rentals>> GetReturnDate(int CarId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Rentals rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
