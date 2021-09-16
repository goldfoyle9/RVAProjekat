using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.PatientCommands
{
    public interface IUpdatePatientCommand 
    {
        void Execute();
    }
}
