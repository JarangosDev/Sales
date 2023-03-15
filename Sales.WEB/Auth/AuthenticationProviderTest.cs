using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Sales.WEB.Auth
{
    public class AuthenticationProviderTest : AuthenticationStateProvider
    {
        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonimous = new ClaimsIdentity();
            var jarangosUser = new ClaimsIdentity(new List<Claim>
            {
                new Claim("FirstName", "Jair"),
                new Claim("LastName", "Arango"),
                new Claim(ClaimTypes.Name, "jarangosdev@yopmail.com"),
                new Claim(ClaimTypes.Role, "Admin")
            },
            authenticationType: "test");
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(jarangosUser)));
        }
    }
}