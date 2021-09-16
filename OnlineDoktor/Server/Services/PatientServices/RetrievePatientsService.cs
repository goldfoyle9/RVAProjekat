using Common;
using Common.ServiceContracts.PatientServiceContracts;
using Database.CommandInterfaces.DoctorInterfaces;
using Database.PatientCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services.PatientServices
{
    public class RetrievePatientsService : IRetrievePatients
    {
        public List<Patient> RetrievePatients()
        {
            IGetPatientsCommand command = new GetPatientsCommand();
            List<Patient> lista = new List<Patient>();
            lista = command.Execute();
            return lista;
        }
    }
}
