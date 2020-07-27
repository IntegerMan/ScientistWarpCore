using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public interface IWarpCoreServiceLayer
    {
        WarpCoreMetrics CurrentMetrics { get; }
    }
}