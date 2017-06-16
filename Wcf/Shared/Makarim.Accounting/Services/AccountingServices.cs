using Makarim.Accounting.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Makarim.Accounting.Contracts.Data;

namespace Makarim.Accounting.Services
{
    public class AccountingServices : IAccountingServices
    {
        public AccountingServices()
        {
        }

        #region AccountService

        private static IList<AccountData> _accounts = new List<AccountData>()
        {
            new AccountData() { Number = "1010", Name = "Cash" },
            new AccountData() { Number = "1012", Name = "Bank" }
        };

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
