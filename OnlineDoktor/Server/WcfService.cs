
using Server.Services;
using Server.Services.DoctorServices;
using Server.Services.ExaminationServices;
using Server.Services.PatientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class WcfService
    {
        private ServiceHost AuthenticationServiceHost = new ServiceHost(typeof(AuthenticationService));


        private ServiceHost RetrievePatientsServiceHost = new ServiceHost(typeof(RetrievePatientsService));
        private ServiceHost AddPatientServiceHost = new ServiceHost(typeof(AddPatientService));
        private ServiceHost RemovePatientServiceHost = new ServiceHost(typeof(RemovePatientService));
        private ServiceHost SearchPatientServiceHost = new ServiceHost(typeof(SearchPatientService));
        private ServiceHost UpdatePatientServiceHost = new ServiceHost(typeof(UpdatePatientService));



        private ServiceHost RetrieveDoctorsServiceHost = new ServiceHost(typeof(RetrieveDoctorsService));
        private ServiceHost AddDoctorServiceHost = new ServiceHost(typeof(AddDoctorService));
        private ServiceHost RemoveDoctorServiceHost = new ServiceHost(typeof(RemoveDoctorService));
        private ServiceHost SearchDoctorServiceHost = new ServiceHost(typeof(SearchDoctorService));
        private ServiceHost UpdateDoctorServiceHost = new ServiceHost(typeof(UpdateDoctorService));


        private ServiceHost AddExaminationServiceHost = new ServiceHost(typeof(AddExaminationService));
        private ServiceHost RemoveExaminationServiceHost = new ServiceHost(typeof(RemoveExaminationService));
        private ServiceHost RetrieveExaminationServiceHost = new ServiceHost(typeof(RetrieveExaminationService));
        private ServiceHost RetrieveAllExaminationsServiceHost = new ServiceHost(typeof(RetrieveAllExaminationsService));
        private ServiceHost SearchExaminationServiceHost = new ServiceHost(typeof(SearchExaminationService));
        private ServiceHost UpdateExaminationServiceHost = new ServiceHost(typeof(UpdateExaminationService));




        public WcfService()
        {
        }

        public void Open()
        {
            try
            {
                AuthenticationServiceHost.Open();

                RetrievePatientsServiceHost.Open();
                AddPatientServiceHost.Open();
                RemovePatientServiceHost.Open();
                SearchPatientServiceHost.Open();
                UpdatePatientServiceHost.Open();
               

                RetrieveDoctorsServiceHost.Open();
                AddDoctorServiceHost.Open();
                RemoveDoctorServiceHost.Open();
                SearchDoctorServiceHost.Open();
                UpdateDoctorServiceHost.Open();

                AddExaminationServiceHost.Open();
                RemoveExaminationServiceHost.Open();
                SearchExaminationServiceHost.Open();
                UpdateExaminationServiceHost.Open();
                RetrieveExaminationServiceHost.Open();
                RetrieveAllExaminationsServiceHost.Open();



                Console.WriteLine("Service hosts are opened at " + DateTime.Now);   
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Close()
        {
            try
            {
                AuthenticationServiceHost.Close();

                RetrievePatientsServiceHost.Close();
                AddPatientServiceHost.Close();
                RemovePatientServiceHost.Close();
                SearchPatientServiceHost.Close();
                UpdatePatientServiceHost.Close();


                RetrieveDoctorsServiceHost.Close();
                AddDoctorServiceHost.Close();
                RemoveDoctorServiceHost.Close();
                SearchDoctorServiceHost.Close();
                UpdateDoctorServiceHost.Close();

                AddExaminationServiceHost.Close();
                RemoveExaminationServiceHost.Close();
                SearchExaminationServiceHost.Close();
                UpdateExaminationServiceHost.Close();
                RetrieveExaminationServiceHost.Close();
                RetrieveAllExaminationsServiceHost.Close();
                Console.WriteLine("Service hosts are closed at " + DateTime.Now);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
