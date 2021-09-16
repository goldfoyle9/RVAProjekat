using Common;
using Common.ServiceContracts.DoctorServiceContracts;
using Database.CommandInterfaces.DoctorInterfaces;
using Database.DoctorCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services.DoctorServices
{
    public class SearchDoctorService : ISearchDoctors
    {
        public List<Doctor> FoundDoctors(string searchCriteria)
        {
            ISearchDoctorsCommand command = new SearchDoctorsCommand();
            return command.Execute(searchCriteria);
        }
    }
}
