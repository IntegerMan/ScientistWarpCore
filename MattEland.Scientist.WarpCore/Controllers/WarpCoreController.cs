using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattEland.Scientist.WarpCore.Models;
using MattEland.Scientist.WarpCore.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

namespace MattEland.Scientist.WarpCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarpCoreController : ControllerBase
    {
        private readonly IWarpCoreServiceLayer _warpServiceLayer;

        public WarpCoreController(IWarpCoreServiceLayer warpServiceLayer)
        {
            _warpServiceLayer = warpServiceLayer;
        }

        [HttpGet]
        public WarpCoreMetrics CurrentMetrics()
        {
            return _warpServiceLayer.CurrentMetrics;
        }
    }
}
