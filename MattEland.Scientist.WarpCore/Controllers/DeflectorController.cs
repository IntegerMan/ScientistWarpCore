using MattEland.Scientist.WarpCore.Models;
using MattEland.Scientist.WarpCore.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace MattEland.Scientist.WarpCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeflectorController : ControllerBase
    {
        private readonly IDeflectorServiceLayer _deflectorServiceLayer;

        public DeflectorController(IDeflectorServiceLayer deflectorServiceLayer)
        {
            _deflectorServiceLayer = deflectorServiceLayer;
        }

        [HttpPost]
        public IActionResult HandleDeflectorInformation([FromBody] DeflectorInformation deflectorInfo)
        {
            _deflectorServiceLayer.ClearReadings();

            deflectorInfo.Readings.ForEach(reading => _deflectorServiceLayer.RegisterSensorReading(reading));

            return Ok();
        }
    }
}