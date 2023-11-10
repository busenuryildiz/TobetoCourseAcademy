using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager
    {
        public void Add(User user)
        {
            AdoNetUserDal adoNetUserDal = new AdoNetUserDal();
            adoNetUserDal.Add(user);
        }

        public void Delete(User user)
        {
            AdoNetUserDal adoNetUserDal = new AdoNetUserDal();
            adoNetUserDal.Delete(user);
        }

        public void Update(User user)
        {
            AdoNetUserDal adoNetUserDal = new AdoNetUserDal();
            adoNetUserDal.Update(user);
        }
    }
}
