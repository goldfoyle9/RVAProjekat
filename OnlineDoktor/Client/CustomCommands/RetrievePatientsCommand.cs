using Client.Model;
using Common;
using Common.ServiceContracts;
using Common.ServiceContracts.PatientServiceContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;

namespace Client.CustomCommands
{
    public class RetrievePatientsCommand : IRetrievePatientsCommand
    {
        public BindingList<PatientModel> RetrieveData()
        {
            ChannelFactory<IRetrievePatients> channel = new ChannelFactory<IRetrievePatients>("RetrievePatientsService");
            IRetrievePatients proxy = channel.CreateChannel();
            List<Patient> patients = new List<Patient>();
            try
            {
                patients = proxy.RetrievePatients();
            }
            catch(Exception e)
            {
                
            }

            BindingList<PatientModel> patientModels = new BindingList<PatientModel>();

            foreach(Patient p in patients)
            {
                patientModels.Add(new PatientModel { Name = p.Name, LastName = p.LastName, SocialSecurityNumber = p.SocialSecurityNumber });
            }
            return patientModels;

        }
    }
}
