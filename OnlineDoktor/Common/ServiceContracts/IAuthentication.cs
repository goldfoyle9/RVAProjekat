using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common.ServiceContracts
{
    [ServiceContract]
    public interface IAuthentication
    {
        [OperationContract]
        bool Login(string username, string password, string type);
        [OperationContract]
        void Logout();
        

    }
}
