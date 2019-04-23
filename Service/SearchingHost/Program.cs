using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace SearchingHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(SearchingService.SearchService)))
            {
                host.Open();
                Console.WriteLine("Host startes @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
