using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Requests
    {
        [Key]
        public int Id { get; set; }
        public DateTime  StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public int  WorkDay { get; set; }
        public Users users { get; set; }
    }
}
