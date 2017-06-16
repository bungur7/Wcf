using Makarim.Accounting.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.ClaimsIdentityConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;

            try
            {
                host = new ServiceHost(typeof(ClaimsIdentityAccountingServices));
                host.Open();

                Console.WriteLine("Accounting services are up and running at the following addresses:");
                host.Description.Endpoints.ToList().ForEach(x => Console.WriteLine(x.Address));

                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.ReadLine();
            }
            finally
            {
                if (host != null)
                {
                    if (host.State != CommunicationState.Faulted)
                    {
                        host.Close();
                        host = null;
                    }
                    else
                    {
                        host = null;
                    }
                }
            }
        }
    }
}
