using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class DoctorModel :   INotifyPropertyChanged
    {
        private string name;
        private string lastName;
        private Discipline fieldOfWork;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string LastName
        {
            get 
            { 
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public Discipline FieldOfWork
        {
            get 
            { 
                return fieldOfWork; 
            }
            set
            {
                fieldOfWork = value;
                OnPropertyChanged("FieldOfWork");
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
