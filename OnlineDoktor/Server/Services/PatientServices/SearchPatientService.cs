using Common;
using Common.ServiceContracts.PatientServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services.PatientServices
{
    public class SearchPatientService : ISearchPatient
    {
        public List<Patient> FoundPatients(string searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
