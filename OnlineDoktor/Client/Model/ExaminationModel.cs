using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class ExaminationModel : INotifyPropertyChanged
    {

        private DateTime examinationDate;
        private DateTime examinationTime;
        private string examinationDoctorName;
        private string examinationDoctorLastName;

        public DateTime ExaminationDate
        {
            get 
            { 
                return examinationDate;
            }
            set 
            { 
                examinationDate = value;
                OnPropertyChanged("ExaminationDate");
            }
        }

        public DateTime ExaminationTime
        {
            get 
            { 
                return examinationTime; 
            }
            set
            {
                examinationTime = value;
                OnPropertyChanged("ExaminationTime");
            }
        }


        public string ExaminationDoctorName 
        {
            get
            {
                return examinationDoctorName;
            }
            set
            {
                examinationDoctorName = value;
                OnPropertyChanged("ExaminationDoctorName");
            }  
        }
        public string ExaminationDoctorLastName
        {
            get
            {
                return examinationDoctorLastName;
            }
            set
            {
                examinationDoctorLastName = value;
                OnPropertyChanged("ExaminationDoctorLastName");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
