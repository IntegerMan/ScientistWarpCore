using System.Collections.Generic;

namespace MattEland.Scientist.WarpCore.Models
{
    public class WarpCoilInductionServiceDiagnostics
    {
        public IList<DeflectorReading> CurrentReadings { get; }
        public IList<NacelleInformation> NacelleInfo { get;  }
        public WarpCoreMetrics WarpCoreMetrics { get; }

        public WarpCoilInductionServiceDiagnostics(IList<DeflectorReading> currentReadings, 
                                                   IList<NacelleInformation> nacelleInfo, 
                                                   WarpCoreMetrics warpCoreMetrics)
        {
            CurrentReadings = currentReadings;
            NacelleInfo = nacelleInfo;
            WarpCoreMetrics = warpCoreMetrics;
        }
    }
}