using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public enum Discipline { Cardiology, Dermatology, Orthopedics, Pediatrics, Psychiatry, Surgery, Public_Health };

    [DataContract]
    public class Doctor
    {


        public Doctor()
        {

        }

        [DataMember]
        [Key]
        public string LicenseID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public Discipline FieldOfWork { get; set; }
        [DataMember]
        public List<DateTime> AvailableDates { get; set; }
        
    }
}
