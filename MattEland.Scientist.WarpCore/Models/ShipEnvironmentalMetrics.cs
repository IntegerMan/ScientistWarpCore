namespace MattEland.Scientist.WarpCore.Models
{
    public class ShipEnvironmentalMetrics
    {
        public decimal CurrentWarp { get; set; }

        public decimal DesiredWarp { get; set; }

        public decimal NebulaDensity { get; set; }

        public decimal GravitationalPull { get; set; }

        public decimal AvailablePowerInGigawats { get; set; }
    }
}