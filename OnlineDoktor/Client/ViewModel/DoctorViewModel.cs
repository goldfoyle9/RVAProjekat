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
   
    public class DoctorViewModel : BaseViewModel
    {
        private BindingList<DoctorModel> _DoctorList;


        public DoctorViewModel()
        {
            IRetrieveDoctorsCommand command = new RetrieveDoctorsCommand();
            _DoctorList = command.RetrieveData();

        }

        public BindingList<DoctorModel> DoctorList
        {
            get { return _DoctorList; }
            set { _DoctorList = value; }
        }


    }
}
