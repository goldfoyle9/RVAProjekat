using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.CommandInterfaces.DoctorInterfaces
{
    public interface IAddDoctorCommand
    {
        void Execute(Doctor newDoctor);
    }
}
