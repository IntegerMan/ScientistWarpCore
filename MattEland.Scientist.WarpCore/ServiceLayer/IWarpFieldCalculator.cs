using System.Collections.Generic;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public interface IWarpFieldCalculator
    {
        WarpContainmentFieldSettings CalculateContainmentFieldSettings(WarpCoreMetrics currentMetrics,
                                                                       IList<DeflectorReading> deflectorCurrentReadings,
                                                                       IList<NacelleInformation> nacellesCurrentReadings);
    }
}