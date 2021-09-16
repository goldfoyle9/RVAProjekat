using Common;
using Database.CommandInterfaces.DoctorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.PatientCommands
{
    public class GetPatientsCommand : IGetPatientsCommand
    {

        public GetPatientsCommand()
        {       
        }

        public List<Patient> Execute()
        {
            using(AllDbContext context = new AllDbContext())
            {
                List<Patient> pacijenti = context.Patients.ToList();
                return context.Patients.ToList();
            }
        }
    }
}
