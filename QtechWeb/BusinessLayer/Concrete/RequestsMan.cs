using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class RequestsMan : IRequestsService
    {
        IRequests reqo;

        public RequestsMan(IRequests reqo)
        {
            this.reqo = reqo;
        }

        public void Adding(Requests requests)
        {
           reqo.ekle(requests);
        }

        public void Deleteing(Requests requests)
        {
            reqo.Sil(requests);
        }

        public Requests Getir(int id)
        {
            return reqo.Get(id);  
        }

        public List<Requests> Listing()
        {
            return reqo.Listele();
        }

        public void Updating(Requests requests)
        {
            reqo.guncelle(requests);
        }
    }
}
