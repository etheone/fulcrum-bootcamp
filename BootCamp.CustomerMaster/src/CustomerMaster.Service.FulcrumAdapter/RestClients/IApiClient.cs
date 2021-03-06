﻿using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Xlent.Lever.Libraries2.Core.Logging;

namespace CustomerMaster.Service.FulcrumAdapter.RestClients
{
    /// <summary>
    /// Publish business events
    /// </summary>
    public interface IApiClient : IFulcrumFullLogger
    {
        /// <summary>
        /// Publish an event
        /// </summary>
        /// <param name="id">The publication id</param>
        /// <param name="eventBody">The event body</param>
        Task PublishAsync(Guid id, JObject eventBody);
    }
}