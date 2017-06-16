using Makarim.Accounting.Contracts.Data;
using Makarim.Accounting.Contracts.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.Services
{
    public class ClaimsIdentityAccountingServices : IAccountingServices
    {
        public ClaimsIdentityAccountingServices()
        {
        }

        #region AccountService

        private static IList<AccountData> _accounts = new List<AccountData>()
        {
            new AccountData() { Number = "1010", Name = "Cash" },
            new AccountData() { Number = "1012", Name = "Bank" }
        };

        [ClaimsPrincipalPermission(System.Security.Permissions.SecurityAction.Demand, Operation = "GetAccounts", Resource = "Account")]
        public async Task<IEnumerable<AccountData>> GetAccountsAsync()
        {
            return await Task.Run<IEnumerable<AccountData>>(() =>
            {
                return _accounts;
            });
        }

        #endregion

    }
}
