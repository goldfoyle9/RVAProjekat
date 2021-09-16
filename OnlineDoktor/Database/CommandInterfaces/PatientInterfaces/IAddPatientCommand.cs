using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.CommandInterfaces.PatientInterfaces
{
    public interface IAddPatientCommand
    {
        void Execute(Patient newPatient);
    }
}
