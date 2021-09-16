using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.CommandInterfaces.PatientInterfaces
{
    public interface ISearchPatientsCommand
    {
        List<Patient> Execute(string searchCriteria);
    }
}
