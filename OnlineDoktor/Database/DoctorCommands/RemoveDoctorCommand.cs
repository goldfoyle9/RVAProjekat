using Database.CommandInterfaces.DoctorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DoctorCommands
{
    public class RemoveDoctorCommand : IRemoveDoctorCommand
    {
        public void Execute(string doctorLicenseID)
        {
            using (AllDbContext context = new AllDbContext())
            {
                context.Doctors.Remove(context.Doctors.Where(p => p.LicenseID == doctorLicenseID).FirstOrDefault());
            }
        }

    }
}
