using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.CustomCommands
{
    public interface IRetrievePatientsCommand
    {
        BindingList<PatientModel> RetrieveData();
    }
}
