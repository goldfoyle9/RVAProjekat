using Client.CustomCommands;
using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class PatientViewModel : BaseViewModel
    {
        private BindingList<PatientModel> _PatientList;


        public PatientViewModel()
        {
            IRetrievePatientsCommand command = new RetrievePatientsCommand();
            _PatientList = command.RetrieveData();

         
        }


        public BindingList<PatientModel> PatientList
        {
            get { return _PatientList; }
            set { _PatientList = value; }
        }

    }
}
