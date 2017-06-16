using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public class MyClaimsAuthenticationManager : ClaimsAuthenticationManager
    {
        public override ClaimsPrincipal Authenticate(string resourceName, ClaimsPrincipal incomingPrincipal)
        {

            // Somewhere in your application, you have user claims storage.
            // Current user claims storage available in UserManager class. See UserManager class in this library.
            // Add custom user claims here.
            //

            var user = UserManager.GetUser(incomingPrincipal.Identity.Name);
            if (user != null)
            {
                var claimsIdentity = incomingPrincipal.Identities.First();
                user.Claims.ToList().ForEach(x =>
                {
                    claimsIdentity.AddClaim(new Claim(x.ClaimType, x.ClaimValue));
                });
            }

            // Add claim to allow client get wcf metadata.
            //
            var claimType = "http://localhost:8733/Design_Time_Addresses/AccountingServices/mex";
            var claimValue = "http://schemas.xmlsoap.org/ws/2004/09/transfer/Get";

            if (incomingPrincipal.Identities.First().HasClaim(
                claimType, claimValue) == false)
            {
                incomingPrincipal.Identities.First().AddClaim(
                    new Claim(claimType, claimValue));
            };

            return incomingPrincipal;
        }
    }
}
