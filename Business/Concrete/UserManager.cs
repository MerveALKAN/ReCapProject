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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new Result(true);
        }

        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new Result(true);
        }

        public IDataResult<Users> Get(int Id)
        {
            return new SuccessDataResult<Users>(_userDal.Get(u=>u.Id==Id));
        }

        public IDataResult<List<Users>> GetAll()
        {
            if (DateTime.Now.Hour == 18)
            {
                return new ErrorDataResult<List<Users>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new Result(true);
        }
    }
}
