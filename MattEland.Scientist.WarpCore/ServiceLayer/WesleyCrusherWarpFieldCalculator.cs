using System;
using System.Collections.Generic;
using System.Linq;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class WesleyCrusherWarpFieldCalculator : IWarpFieldCalculator
    {
        public WarpContainmentFieldSettings CalculateContainmentFieldSettings(
            WarpCoreMetrics coreMetrics,
            IList<DeflectorReading> deflectorReadings,
            IList<NacelleInformation> nacelleReadings)
        {
            var requiredIntesity = Math.Max(coreMetrics.CurrentOutput, coreMetrics.DesiredOutput) + 0.25M;

            return new WarpContainmentFieldSettings
            {
                Harmonics = requiredIntesity % nacelleReadings.Average(n => n.BussardsScooped),
                Polarity = coreMetrics.DilithiumCrystalIntegrity * deflectorReadings.Average(r => r.SignalModularity),
                Strength = requiredIntesity * nacelleReadings.Sum(n => n.SetIntensity) / nacelleReadings.Sum(n => n.CurrentIntensity),
            };
        }
    }
}