using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class Admin
    {

       
        public Admin() { 

        }

        [DataMember]
        [Key]
        public string Username { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
