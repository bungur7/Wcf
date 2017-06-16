using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public class UserClaim
    {
        public UserClaim()
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets ClaimType
        /// </summary>
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or sets ClaimValue
        /// </summary>
        public string ClaimValue { get; set; }

        #endregion
    }
}
