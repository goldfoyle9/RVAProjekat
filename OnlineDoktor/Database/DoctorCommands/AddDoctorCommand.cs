using Common;
using Database.CommandInterfaces.DoctorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DoctorCommands
{
    public class AddDoctorCommand : IAddDoctorCommand
    {
        public void Execute(Doctor newDoctor)
        {
            using(AllDbContext context = new AllDbContext())
            {
                context.Doctors.Add(newDoctor);
                context.SaveChanges();
            }
        }
    }
}
