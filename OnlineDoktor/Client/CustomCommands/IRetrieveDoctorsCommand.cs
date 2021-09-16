using Client.Model;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.CustomCommands
{
    public interface IRetrieveDoctorsCommand
    {
        BindingList<DoctorModel> RetrieveData();
    }
}
