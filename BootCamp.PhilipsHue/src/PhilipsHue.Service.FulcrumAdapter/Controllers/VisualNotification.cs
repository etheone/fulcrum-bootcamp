﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using PhilipsHue.Service.FulcrumAdapter.Contract;
using Xlent.Lever.Libraries2.Core.Assert;
using Xlent.Lever.Libraries2.Core.Storage.Logic;
using Xlent.Lever.Libraries2.Core.Storage.Model;

namespace PhilipsHue.Service.FulcrumAdapter.Controllers
{
    /// <inheritdoc cref="IVisualNotification" />
    // TODO: Add authentication
    // [FulcrumAuthorize(AuthenticationRoleEnum.InternalSystemUser)]
    [RoutePrefix("api/Notifications")]
    public class VisualNotification : ApiController, IVisualNotification
    {
        /// <inheritdoc />
        [HttpPost]
        [Route("Success")]
        public Task SuccessAsync(double? seconds = null)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        [HttpPost]
        [Route("Warning")]
        public Task WarningAsync(double? seconds = null)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        [HttpPost]
        [Route("Error")]
        public Task ErrorAsync(double? seconds = null)
        {
            throw new System.NotImplementedException();
        }
    }
}