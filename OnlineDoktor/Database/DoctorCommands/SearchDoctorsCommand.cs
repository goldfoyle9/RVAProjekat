using Common;
using Database.CommandInterfaces.DoctorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DoctorCommands
{
    public class SearchDoctorsCommand : ISearchDoctorsCommand
    {
        public List<Doctor> Execute(string searchCriteria)
        {
            throw new NotImplementedException();
        }
    }
}
