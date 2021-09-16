using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            WcfService wcfService = new WcfService();
            wcfService.Open();
            Console.ReadKey();
            wcfService.Close();
            Console.ReadKey();
        }

    }
}
