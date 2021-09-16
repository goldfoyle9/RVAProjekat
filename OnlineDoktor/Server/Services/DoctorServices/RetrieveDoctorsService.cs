using Common;
using Common.ServiceContracts.DoctorServiceContracts;
using Database.CommandInterfaces;
using Database.DoctorCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services.DoctorServices
{
    public class RetrieveDoctorsService : IRetrieveDoctors
    {
        public List<Doctor> RetrieveDoctors()
        {
            IGetDoctorsCommand command = new GetDoctorsCommand();
            return command.Execute();
        }
    }
}
