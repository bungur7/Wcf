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
            if (userName.Equals(password) == true)
            {
                throw new SecurityTokenValidationException();
            }
        }
    }
}
