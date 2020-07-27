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
    public class WarpCoilInductionController : ControllerBase
    {
        private readonly IWarpCoilInductionService _coilInductionService;

        public WarpCoilInductionController(IWarpCoilInductionService coilInductionService)
        {
            _coilInductionService = coilInductionService;
        }

        [HttpGet]
        public IActionResult GetDiagnosticInformation()
        {
            return Ok(_coilInductionService.GenerateDiagnosticInfo());
        }
    }
}
