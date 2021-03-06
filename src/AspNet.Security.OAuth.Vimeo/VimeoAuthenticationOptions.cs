/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace AspNetCore.Security.OAuth.Vimeo {
    /// <summary>
    /// Defines a set of options used by <see cref="VimeoAuthenticationHandler"/>.
    /// </summary>
    public class VimeoAuthenticationOptions : OAuthOptions {
        public VimeoAuthenticationOptions() {
            AuthenticationScheme = VimeoAuthenticationDefaults.AuthenticationScheme;
            DisplayName = VimeoAuthenticationDefaults.DisplayName;
            ClaimsIssuer = VimeoAuthenticationDefaults.Issuer;

            CallbackPath = new PathString(VimeoAuthenticationDefaults.CallbackPath);

            AuthorizationEndpoint = VimeoAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = VimeoAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = VimeoAuthenticationDefaults.UserInformationEndpoint;
        }
    }
}
