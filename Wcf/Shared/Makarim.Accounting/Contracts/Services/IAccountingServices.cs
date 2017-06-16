using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.Contracts.Services
{
    [ServiceContract()]
    public interface IAccountingServices :
        IAccountService
    {
    }
}
