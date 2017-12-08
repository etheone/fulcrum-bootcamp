﻿using System.Threading.Tasks;
using Microsoft.Rest;

#pragma warning disable 1591

namespace PhilipsHue.Service.FulcrumAdapter.RestClients
{
    public class VisualNotificationClient : BaseClient, IVisualNotificationClient
    {
        public VisualNotificationClient(string baseUri, ServiceClientCredentials authenticationCredentials) : base(baseUri, authenticationCredentials)
        {
        }

        public async Task VisualNotificationSuccessAsync()
        {
            var relativeUrl = $"api/Notifications/Success";
            await RestClient.PostNoResponseContentAsync(relativeUrl);
        }

        public async Task VisualNotificationWarningAsync()
        {
            var relativeUrl = $"api/Notifications/Warning";
            await RestClient.PostNoResponseContentAsync(relativeUrl);
        }

        public async Task VisualNotificationErrorAsync()
        {
            var relativeUrl = $"api/Notifications/Error";
            await RestClient.PostNoResponseContentAsync(relativeUrl);
        }
    }
}