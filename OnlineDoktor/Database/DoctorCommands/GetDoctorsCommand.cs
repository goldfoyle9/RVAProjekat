using Common;
using Database.CommandInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.DoctorCommands
{
    public class GetDoctorsCommand : IGetDoctorsCommand
    {
        public List<Doctor> Execute()
        {
            using (AllDbContext context = new AllDbContext())
            {
                return context.Doctors.ToList();
            }
        }
    }
}
