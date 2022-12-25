using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        void Adding(Users use);
        void Updating(Users use);
        void Deleteing(Users use);
        List<Users> Listing();
        Users Getir(int id);
    }
}
