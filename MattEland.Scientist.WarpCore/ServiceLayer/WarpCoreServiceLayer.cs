using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class WarpCoreServiceLayer : IWarpCoreServiceLayer
    {
        public WarpCoreServiceLayer()
        {
            CurrentMetrics = new WarpCoreMetrics()
            {
                CurrentOutput = 1.21M,
                DesiredOutput = 12M,
                DilithiumCrystalIntegrity = 0.98M,
                TemperatureFahrenheit = 121.4M,
            };
        }

        public WarpCoreMetrics CurrentMetrics { get; }
    }
}