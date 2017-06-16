using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public class CustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public CustomUserNamePasswordValidator()
        {
        }

        public override void Validate(string userName, string password)
        {
            // Somewhere in your application, you have user account storage.
            // Validate user account here.
            //
            if (userName.Equals(password) == true)
            {
                throw new SecurityTokenValidationException();
            }
        }
    }
}
