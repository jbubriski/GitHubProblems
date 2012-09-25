using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using GitHubProblems.Models;
using GitHubProblems.Authentication;
using System.Configuration;

namespace GitHubProblems
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            //OAuthWebSecurity.RegisterMicrosoftClient(
            //    clientId: "",
            //    clientSecret: "");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            //OAuthWebSecurity.RegisterFacebookClient(
            //    appId: "",
            //    appSecret: "");

            //OAuthWebSecurity.RegisterGoogleClient();

            var gitHubClientId = ConfigurationManager.AppSettings["GitHub.ClientId"];
            var gitHubClientSecret = ConfigurationManager.AppSettings["GitHub.ClientSecret"];

            OAuthWebSecurity.RegisterClient(new GitHubOAuth2Client(gitHubClientId, gitHubClientSecret), "GitHub", null);
        }
    }
}
