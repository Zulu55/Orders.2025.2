using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Orders.Frontend.AuthenticationProviders;

public class AuthenticationProviderTest : AuthenticationStateProvider
{
    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var anonimous = new ClaimsIdentity();
        var user = new ClaimsIdentity(authenticationType: "test");
        var admin = new ClaimsIdentity(
        [
            new("FirstName", "Juan"),
            new("LastName", "Zulu"),
            new(ClaimTypes.Name, "zulu@yopmail.com"),
            new(ClaimTypes.Role, "Admin")
        ],
        authenticationType: "test");

        return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(user)));
    }
}