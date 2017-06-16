using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Makarim.WcfInfrastructures
{
    public class MyClaimsAuthorizationManager : ClaimsAuthorizationManager
    {
        public override bool CheckAccess(AuthorizationContext context)
        {
            //Console.WriteLine("Available claims:");
            //foreach (var item in context.Principal.Claims)
            //{
            //    Console.WriteLine($"ClaimType: {item.Type}");
            //    Console.WriteLine($"ClaimValue: {item.Value}");
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("Requested claims:");
            //Console.WriteLine($"ClaimType: {context.Resource[0].Value}");
            //Console.WriteLine($"ClaimValue: {context.Action[0].Value}");

            return context.Principal.HasClaim(context.Resource[0].Value, context.Action[0].Value);
        }
    }
}
