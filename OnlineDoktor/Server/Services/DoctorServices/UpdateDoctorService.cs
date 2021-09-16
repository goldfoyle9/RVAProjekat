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
    public class UpdateDoctorService : IUpdateDoctor
    {
        public void UpdateDoctor(string doctorLicenseID)
        {
            IUpdateDoctorCommand command = new UpdateDoctorCommand();
            command.Execute(doctorLicenseID);
        }
    }
}
