using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class WcfServer
    {
        private ServiceHost serviceHost;


        public void Open()
        {
            try
            {
                serviceHost.Open();
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
                serviceHost.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
