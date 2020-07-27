using MattEland.Scientist.WarpCore.Controllers;

namespace MattEland.Scientist.WarpCore.Models
{
    public class DeflectorReading
    {
        public SpacePos Pos { get; set; }

        public decimal SignalStrength { get; set; }
        public decimal SignalBand { get; set; }
        public decimal SignalModularity { get; set; }
    }
}