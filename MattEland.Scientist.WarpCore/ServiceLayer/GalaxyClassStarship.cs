using System;
using Bogus;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class GalaxyClassStarship : IStarship
    {
        private static readonly Random _random = new Random(42);
        private static readonly Faker _faker = new Faker();

        private static readonly Faker<DeflectorReading> _sensorFaker = 
            new Faker<DeflectorReading>()
                .RuleFor(r => r.Pos, BuildRandomPos)
                .RuleForType(typeof(decimal),f => f.Random.Decimal(0M, 100M));

        private static SpacePos BuildRandomPos() => new SpacePos
            {
                X = _faker.Random.Decimal(min: -500000M, max: 500000M),
                Y = _faker.Random.Decimal(min: -500000M, max: 500000M),
                Z = _faker.Random.Decimal(min: -500000M, max: 500000M),
            };

        private readonly IDeflectorServiceLayer _deflectors;
        private readonly INacelleServiceLayer _nacelles;
        private readonly IWarpCoilInductionService _coil;
        private readonly IWarpCoreServiceLayer _core;

        static GalaxyClassStarship()
        {
            Randomizer.Seed = _random;
        }

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
            _nacelles.UpdateInfo(NacelleIdentifier.Port, BuildNacelle(NacelleIdentifier.Port));
            _nacelles.UpdateInfo(NacelleIdentifier.Starboard, BuildNacelle(NacelleIdentifier.Starboard));

            _deflectors.RegisterSensorReading(GenerateSensorReading());

            _coil.ComputeWarpCoreSettings();
        }

        private static DeflectorReading GenerateSensorReading() => _sensorFaker.Generate();

        private static NacelleInformation BuildNacelle(NacelleIdentifier id)
        {
            return new NacelleInformation
            {
                Id = id,
                BussardsScooped = _faker.Random.Decimal(max: 154M),
                CurrentIntensity = _faker.Random.Decimal(max: 50M),
                SetIntensity = _faker.Random.Decimal(max: 50M)
            };
        }
    }
}