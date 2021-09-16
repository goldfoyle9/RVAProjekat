
using Common.ServiceContracts;
using Database.CommandInterfaces;
using Database.CommandInterfaces.DoctorInterfaces;
using Database.PatientCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Services
{
    public class AuthenticationService : IAuthentication
    {
        public bool Login(string username, string password, string type)
        {

            ICheckPatientExistanceCommand command = new PatientExistanceCommand(username, password);
            if (command.Execute())
            {
                return true;
            }
            return false;
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
