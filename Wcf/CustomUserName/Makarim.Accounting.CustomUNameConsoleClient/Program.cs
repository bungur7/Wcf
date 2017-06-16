using Makarim.Accounting.CustomUNameConsoleClient.ServiceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.CustomUNameConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AccountingServicesClient client = new AccountingServicesClient();

                // UserName validation on server.
                // The validation code is on Makarim.WcfInfrastructure.CustomUserNamePasswordValdator class.
                //
                //  if (userName.Equals(password) == true)
                //  {
                //      throw new SecurityTokenValidationException();
                //  }
                //

                client.ClientCredentials.UserName.UserName = "test";
                client.ClientCredentials.UserName.Password = "test1";

                var result = client.GetAccountsAsync().Result;
                if (result != null)
                {
                    Console.WriteLine($"Result count: {result.Count()}");
                }
                else
                {
                    Console.WriteLine("No result");
                }
                Console.ReadLine();
            }
            catch(System.AggregateException aex)
            {
                Exception ex = aex.InnerException;
                while (ex != null)
                {
                    DisplayException(ex);
                    ex = ex.InnerException;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    DisplayException(ex);
                    ex = ex.InnerException;
                }
                Console.ReadLine();
            }
        }

        private static void DisplayException(Exception ex)
        {
            Console.WriteLine($"- ({ex.GetType().FullName}) {ex.Message}");
        }
    }
}
