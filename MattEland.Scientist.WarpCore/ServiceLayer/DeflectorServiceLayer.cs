using System.Collections.Generic;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class DeflectorServiceLayer : IDeflectorServiceLayer
    {
        public void ClearReadings() => CurrentReadings.Clear();

        public void RegisterSensorReading(DeflectorReading reading) => CurrentReadings.Add(reading);

        public IList<DeflectorReading> CurrentReadings { get; } = new List<DeflectorReading>();
    }
}