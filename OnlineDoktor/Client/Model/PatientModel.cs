using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    public class PatientModel :  INotifyPropertyChanged
    {
        private int socialSecurityNumber;
        private string name;
        private string lastName;

        public int SocialSecurityNumber
        {
            get
            { 
                return socialSecurityNumber; 
            }
            set 
            { 
                socialSecurityNumber = value;
                OnPropertyChanged("SocialSecurityNumber");

            }
        }

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
