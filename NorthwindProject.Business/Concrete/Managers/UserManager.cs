using NorthwindProject.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindProject.Entities.Concrete;
using NorthwindProject.DataAccess.Abstract;

namespace NorthwindProject.Business.Concrete.Managers
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User GetByUserNameAndPassword(User user)
        {
            return _userDal.Get(u => u.UserName == user.UserName && u.Password == user.Password);
        }
    }
}
