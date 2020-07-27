using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class WarpCoilInductionService : IWarpCoilInductionService
    {
        private readonly INacelleServiceLayer _nacelles;
        private readonly IDeflectorServiceLayer _deflector;
        private readonly IWarpCoreServiceLayer _warpCore;

        public WarpCoilInductionService(INacelleServiceLayer nacelles, 
                                        IDeflectorServiceLayer deflector, 
                                        IWarpCoreServiceLayer warpCore)
        {
            _nacelles = nacelles;
            _deflector = deflector;
            _warpCore = warpCore;
        }

        public WarpCoilInductionServiceDiagnostics GenerateDiagnosticInfo()
        {
            return new WarpCoilInductionServiceDiagnostics(_deflector.CurrentReadings, 
                                                           _nacelles.CurrentReadings, 
                                                           _warpCore.CurrentMetrics);
        }
    }
}
