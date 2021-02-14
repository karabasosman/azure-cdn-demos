using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using System;
using System.Collections.Generic;

namespace Az.Demos.Cdn
{
    class Program
    {
        static readonly string AZURE_CLIENT_ID = "";
        static readonly string AZURE_CLIENT_SECRET = "";
        static readonly string AZURE_TENANT_ID = "";
        static readonly string AZURE_SUBSCRIPTION_ID = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var creds = new AzureCredentialsFactory().FromServicePrincipal(AZURE_CLIENT_ID, AZURE_CLIENT_SECRET, AZURE_TENANT_ID, AzureEnvironment.AzureGlobalCloud);
            var azure = Azure.Authenticate(creds).WithSubscription(AZURE_SUBSCRIPTION_ID);

            List<string> purgedContent = new List<string> { "/images/*" };

            azure.CdnProfiles.PurgeEndpointContent("RESOURCE_GROUP_NAME", "CDN_PROFILE_NAME", "CDN_ENDPOINT_NAME", purgedContent);

        }

    }
}
