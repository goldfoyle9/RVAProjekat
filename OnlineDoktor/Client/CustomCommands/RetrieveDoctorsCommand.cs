using Client.Model;
using Common;
using Common.ServiceContracts.DoctorServiceContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client.CustomCommands
{
    public class RetrieveDoctorsCommand : IRetrieveDoctorsCommand
    {
        public BindingList<DoctorModel> RetrieveData()
        {
            ChannelFactory<IRetrieveDoctors> channel = new ChannelFactory<IRetrieveDoctors>("RetrieveDoctorsService");
            IRetrieveDoctors proxy = channel.CreateChannel();
            List<Doctor> doctors = new List<Doctor>();
            try
            {
                doctors= proxy.RetrieveDoctors();
            }
            catch (Exception e)
            {

            }

            BindingList<DoctorModel> doctorModels = new BindingList<DoctorModel>();

            foreach (Doctor d in doctors)
            {
                doctorModels.Add(new DoctorModel { Name = d.Name, LastName = d.LastName, FieldOfWork = d.FieldOfWork});
            }
            return doctorModels;

        }
    }
}
