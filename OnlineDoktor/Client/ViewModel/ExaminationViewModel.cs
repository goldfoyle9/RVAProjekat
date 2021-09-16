using Client.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class ExaminationViewModel : BaseViewModel
    {
        private BindingList<ExaminationModel> _ExaminationList;

        public ExaminationViewModel()
        {
            _ExaminationList = new BindingList<ExaminationModel>
            {
                new ExaminationModel{ExaminationDate = DateTime.Today.Date, ExaminationTime = DateTime.Now, ExaminationDoctorName = "Doktorko", ExaminationDoctorLastName = "Doktorkovic"},
                new ExaminationModel{ExaminationDate = DateTime.Today.Date, ExaminationTime = DateTime.Now, ExaminationDoctorName = "Doktorko", ExaminationDoctorLastName = "Doktorkovic"},
                new ExaminationModel{ExaminationDate = DateTime.Today.Date, ExaminationTime = DateTime.Now, ExaminationDoctorName = "Doktorko", ExaminationDoctorLastName = "Doktorkovic"},
                new ExaminationModel{ExaminationDate = DateTime.Today.Date, ExaminationTime = DateTime.Now, ExaminationDoctorName = "Doktorko", ExaminationDoctorLastName = "Doktorkovic"},
                new ExaminationModel{ExaminationDate = DateTime.Today.Date, ExaminationTime = DateTime.Now, ExaminationDoctorName = "Doktorko", ExaminationDoctorLastName = "Doktorkovic"}
            };
        }

        public BindingList<ExaminationModel> ExaminationList
        {
            get { return _ExaminationList; }
            set { _ExaminationList = value; }
        }
        

    }
}
