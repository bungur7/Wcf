using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public class User
    {
        public User()
        {
        }

        #region Properties

        /// <summary>
        /// Gets or sets UserName
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets Claims
        /// </summary>
        public IEnumerable<UserClaim> Claims { get; set; }

        #endregion
    }
}
