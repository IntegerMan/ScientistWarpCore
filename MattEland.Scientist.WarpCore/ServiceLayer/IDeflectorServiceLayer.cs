using System.Collections.Generic;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public interface IDeflectorServiceLayer
    {
        void ClearReadings();
        void RegisterSensorReading(DeflectorReading reading);
        IList<DeflectorReading> CurrentReadings { get; }
    }
}