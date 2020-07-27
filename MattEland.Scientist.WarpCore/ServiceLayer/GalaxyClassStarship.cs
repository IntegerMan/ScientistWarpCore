using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class GalaxyClassStarship : IStarship
    {
        private readonly IDeflectorServiceLayer _deflectors;
        private readonly INacelleServiceLayer _nacelles;
        private readonly IWarpCoilInductionService _coil;
        private readonly IWarpCoreServiceLayer _core;

        public GalaxyClassStarship(IDeflectorServiceLayer deflectors, 
                                   INacelleServiceLayer nacelles, 
                                   IWarpCoilInductionService coil, 
                                   IWarpCoreServiceLayer core)
        {
            _deflectors = deflectors;
            _nacelles = nacelles;
            _coil = coil;
            _core = core;

            Initialize();
        }

        private void Initialize()
        {
            _nacelles.UpdateInfo(NacelleIdentifier.Port, new NacelleInformation());
            _nacelles.UpdateInfo(NacelleIdentifier.Starboard, new NacelleInformation());
            _deflectors.RegisterSensorReading(new DeflectorReading());
        }
    }
}