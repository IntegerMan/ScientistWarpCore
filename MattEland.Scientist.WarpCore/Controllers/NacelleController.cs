using MattEland.Scientist.WarpCore.Models;
using MattEland.Scientist.WarpCore.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace MattEland.Scientist.WarpCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NacelleController : ControllerBase
    {
        private readonly INacelleServiceLayer _nacelleServiceLayer;
        private readonly IWarpCoilInductionService _coil;

        public NacelleController(INacelleServiceLayer nacelleServiceLayer,
                                 IWarpCoilInductionService coil)
        {
            _nacelleServiceLayer = nacelleServiceLayer;
            _coil = coil;
        }

        [HttpPost("Port")]
        public IActionResult HandlePortNacelleUpdate([FromBody] NacelleInformation info)
        {
            return HandleUpdate(info);
        }

        [HttpPost("Starboard")]
        public IActionResult HandleStarboardNacelleUpdate([FromBody] NacelleInformation info)
        {
            return HandleUpdate(info);
        }

        private IActionResult HandleUpdate(NacelleInformation info)
        {
            _nacelleServiceLayer.UpdateInfo(info.Id, info);

            _coil.RegisterNewReadings();
            
            return Ok();
        }
    }
}