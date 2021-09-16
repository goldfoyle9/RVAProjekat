using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    [DataContract]
    public class Examination
    {
        public Examination()
        {

        }

        [DataMember]
        [Key]
        public string ExaminationID { get; set; }
        [DataMember]
        public DateTime ExaminationDate { get; set; }
        [DataMember]
        public DateTime ExaminationTime { get; set; }
        [DataMember]
        public Doctor ExaminationDoctor { get; set; }
    }
}
