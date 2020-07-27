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

        public NacelleController(INacelleServiceLayer nacelleServiceLayer)
        {
            _nacelleServiceLayer = nacelleServiceLayer;
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
            return Ok();
        }
    }
}