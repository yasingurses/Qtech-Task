using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Users
    {
        [Key]
        public int  UserID { get; set; }
        public string  UserName { get; set; }
        public string  UserPassword { get; set; }
        public int UserLimit { get; set; }  
      

    }
}
