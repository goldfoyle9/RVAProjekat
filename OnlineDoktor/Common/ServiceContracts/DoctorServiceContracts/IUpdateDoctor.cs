using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
namespace Common.ServiceContracts.DoctorServiceContracts
{
    [ServiceContract]
    public interface IUpdateDoctor
    {
        [OperationContract]
        void UpdateDoctor(string doctorLicenseID);
    }
}
