using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public static class UserManager
    {
        private static IList<User> _users = new List<User>()
        {
            new User()
            {
                UserName = "Tester01",
                Password = "Tester01@Test01DotCom",
                Claims = new List<UserClaim>()
                {
                    new UserClaim()
                    {
                        ClaimType = "http://localhost:8733/Design_Time_Addresses/AccountingServices",
                        ClaimValue = "http://tempuri.org/IAccountService/GetAccounts"
                    },
                    new UserClaim()
                    {
                        ClaimType = "Account",
                        ClaimValue = "GetAccounts"
                    }
                }
            },
            new User()
            {
                UserName = "Tester02",
                Password = "Tester02@Test02DotCom",
                Claims = new List<UserClaim>()
                {
                    new UserClaim()
                    {
                        ClaimType = "http://localhost:8733/Design_Time_Addresses/AccountingServices",
                        ClaimValue = "http://tempuri.org/IAccountService/GetAccounts"
                    },
                    new UserClaim()
                    {
                        ClaimType = "Account",
                        ClaimValue = "AddAccount"
                    }
                }
            }
        };

        public static User GetUser(string userName)
        {
            return _users.FirstOrDefault(x => x.UserName.Equals(userName));
        }
    }
}
