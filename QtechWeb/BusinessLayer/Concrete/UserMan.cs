using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMan : IUserService
    {
            IUser us;
 

       

        public UserMan(IUser us)
        {
            this.us = us;
        }

        public void Adding(Users use)
        {
            us.ekle(use);
        }

        public void Deleteing(Users use)
        {
           us.Sil(use);
        }

        public Users Getir(int id)
        {
            return us.Get(id);
        }

        public List<Users> Listing()
        {
            return us.Listele();
        }

        public void Updating(Users use)
        {
            us.guncelle(use);
        }
    }
}
