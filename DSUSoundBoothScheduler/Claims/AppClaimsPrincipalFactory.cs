using Microsoft.AspNetCore.Identity;
using Data;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

public class AppClaimsPrincipalFactory : UserClaimsPrincipalFactory<DSUSoundBoothSchedulerUser, IdentityRole>
{
    public AppClaimsPrincipalFactory(
        UserManager<DSUSoundBoothSchedulerUser> userManager
        , RoleManager<IdentityRole> roleManager
        , IOptions<IdentityOptions> optionsAccessor)
    : base(userManager, roleManager, optionsAccessor)
    { }

    public async override Task<ClaimsPrincipal> CreateAsync(DSUSoundBoothSchedulerUser user)
    {
        var principal = await base.CreateAsync(user);
        Claim isCertifiedClaim = new Claim("IsCertified", "True");
        Claim isAdminClaim = new Claim("IsAdmin", "True");
        if (user.IsCertified)
        {
            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
                isCertifiedClaim
            });
        }

        if (user.IsAdmin)
        {
            ((ClaimsIdentity)principal.Identity).AddClaims(new[]
            {
                isAdminClaim
            });
        }

        if (!string.IsNullOrWhiteSpace(user.LastName))
        {
            ((ClaimsIdentity)principal.Identity).AddClaims(new[] {
         new Claim(ClaimTypes.Surname, user.LastName),
    });
        }

        return principal;
    }
}