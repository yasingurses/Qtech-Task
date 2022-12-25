using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRequestsService
    {
        void Adding(Requests requests);
        void Updating(Requests requests);
        void Deleteing(Requests requests);
        List<Requests> Listing();
        Requests Getir(int id);
    }
}
