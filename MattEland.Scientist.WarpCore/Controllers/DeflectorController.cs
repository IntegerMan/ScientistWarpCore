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
        private readonly IWarpCoilInductionService _coil;

        public DeflectorController(IDeflectorServiceLayer deflectorServiceLayer,
                                   IWarpCoilInductionService coil)
        {
            _deflectorServiceLayer = deflectorServiceLayer;
            _coil = coil;
        }

        [HttpPost]
        public IActionResult HandleDeflectorInformation([FromBody] DeflectorInformation deflectorInfo)
        {
            _deflectorServiceLayer.ClearReadings();

            deflectorInfo.Readings.ForEach(reading => _deflectorServiceLayer.RegisterSensorReading(reading));

            _coil.RegisterNewReadings();

            return Ok();
        }
    }
}