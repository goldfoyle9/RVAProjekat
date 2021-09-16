using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.CommandInterfaces.PatientInterfaces
{
    public interface IRemovePatientCommand
    {
        void Execute(string patientUsername);
    }
}
