using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class WarpCoreServiceLayer : IWarpCoreServiceLayer
    {
        private WarpContainmentFieldSettings _containmentSettings;

        public WarpCoreServiceLayer()
        {
        }

        public WarpCoreMetrics CurrentMetrics => new WarpCoreMetrics
        {
            CurrentOutput = 1.21M,
            DesiredOutput = 12M,
            DilithiumCrystalIntegrity = 0.98M,
            TemperatureFahrenheit = 121.4M,
            ContainmentSettings = _containmentSettings
        };

        public void UpdateSettings(WarpContainmentFieldSettings containmentSettings)
        {
            _containmentSettings = containmentSettings;
        }
    }
}