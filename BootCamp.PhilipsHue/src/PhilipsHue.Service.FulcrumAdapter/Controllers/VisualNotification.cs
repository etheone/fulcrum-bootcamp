﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using PhilipsHue.Service.FulcrumAdapter.Contract;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using Q42.HueApi.Interfaces;
using Q42.HueApi.ColorConverters.HSB;
using Xlent.Lever.Libraries2.Core.Assert;

namespace PhilipsHue.Service.FulcrumAdapter.Controllers
{
    /// <inheritdoc cref="IVisualNotification" />
    // TODO: Add authentication
    // [FulcrumAuthorize(AuthenticationRoleEnum.InternalSystemUser)]
    [RoutePrefix("api/Notifications")]
    public class VisualNotification : ApiController, IVisualNotification
    {
        private const string GreenColorHex = "0x00FF00";
        private const string YellowColorHex = "0xFFFF00";
        private const string RedColorHex = "0xFF0000";
        private readonly IHueClient _hueClient;
        private readonly List<string> _lamps;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hueClient">The client to use for communication with the Philips Hue</param>
        public VisualNotification(IHueClient hueClient)
        {
            _hueClient = hueClient;
            _lamps = new List<string> { "1" };
        }

        /// <inheritdoc />
        [HttpPost]
        [Route("Success")]
        public async Task SuccessAsync(double? seconds = null)
        {
            FulcrumAssert.IsNotNull(_hueClient, null, "Must have a valid HueClient.");
            var command = new LightCommand();
            command.SetColor(new RGBColor(GreenColorHex));
            command.Alert = Alert.Once;
            await _hueClient.SendCommandAsync(command, _lamps);
        }

        /// <inheritdoc />
        [HttpPost]
        [Route("Warning")]
        public async Task WarningAsync(double? seconds = null)
        {
            FulcrumAssert.IsNotNull(_hueClient, null, "Must have a valid HueClient.");
            var command = new LightCommand();
            command.SetColor(new RGBColor(YellowColorHex));
            command.Alert = Alert.Once;
            await _hueClient.SendCommandAsync(command, _lamps);
        }

        /// <inheritdoc />
        [HttpPost]
        [Route("Error")]
        public async Task ErrorAsync(double? seconds = null)
        {
            FulcrumAssert.IsNotNull(_hueClient, null, "Must have a valid HueClient.");
            var command = new LightCommand();
            command.SetColor(new RGBColor(RedColorHex));
            command.Alert = Alert.Once;
            await _hueClient.SendCommandAsync(command, _lamps);
        }
    }
}
