using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.Accounting.Contracts.Data
{
    [DataContract(IsReference = true)]
    public class AccountData
    {
        public AccountData()
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets Number
        /// </summary>
        [DataMember()]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>
        [DataMember()]
        public string Name { get; set; }

        #endregion
    }
}
