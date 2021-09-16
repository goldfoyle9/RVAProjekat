using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.PatientCommands
{
    public interface IAddPatientCommand
    {
        void Execute(Patient newPatient);
    }
}
