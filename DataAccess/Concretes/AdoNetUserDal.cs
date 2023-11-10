using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetUserDal
    {
        public void Add(User user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı ADO NET ile eklendi");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı ADO NET ile silindi");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.UserName + " isimli kullanıcı ADO NET ile güncellendi");
        }
    }
}
