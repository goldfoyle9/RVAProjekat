using Database.CommandInterfaces;
using Database.CommandInterfaces.DoctorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.PatientCommands
{
    public class PatientExistanceCommand : ICheckPatientExistanceCommand
    {
        private string _username;
        private string _password;
        public PatientExistanceCommand(string username, string password)
        {
            AllDbContext context = new AllDbContext();

            //context.Patients.Add(new Common.Patient { Name = "Djole", LastName = "Djole", Username = "djole", Password = "djole", SocialSecurityNumber = 123456 });
            //context.SaveChanges();
            _username = username;
            _password = password;
        }

        public bool Execute()
        {
            using (AllDbContext context = new AllDbContext())
            {
              
                var query = context.Patients.Where(p => p.Username == _username && p.Password == _password);
                if(query != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
