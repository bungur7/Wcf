using Makarim.Accounting.ClaimsIdentityConsoleClient.ServiceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.ClaimsIdentityConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AccountingServicesClient client = new AccountingServicesClient();
                // Tester01 has GetAccountsAsync claim. See UserManager class in Makarim.WcfInfrastructures.
                //
                client.ClientCredentials.UserName.UserName = "Tester01";
                client.ClientCredentials.UserName.Password = "Tester01@Test01DotCom";

                Console.WriteLine("Tester01 call GetAccountsAsync()");
                var result = client.GetAccountsAsync().Result;
                if (result != null)
                {
                    Console.WriteLine($"Result count: {result.Count()}");
                }
                else
                {
                    Console.WriteLine("No result");
                }

                Console.WriteLine();

                if (client != null)
                {
                    client.Close();
                }

                client = new AccountingServicesClient();
                // Tester02 has no GetAccountsAsync claim.
                //
                client.ClientCredentials.UserName.UserName = "Tester02";
                client.ClientCredentials.UserName.Password = "Tester02@Test02DotCom";

                Console.WriteLine("Tester02 call GetAccountsAsync()");
                result = client.GetAccountsAsync().Result;
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
            catch (System.AggregateException aex)
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
