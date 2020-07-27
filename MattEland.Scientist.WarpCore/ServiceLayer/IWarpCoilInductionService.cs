using MattEland.Scientist.WarpCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public interface IWarpCoilInductionService
    {
        WarpCoilInductionServiceDiagnostics GenerateDiagnosticInfo();
        WarpContainmentFieldSettings ComputeWarpCoreSettings();
        void RegisterNewReadings();
    }
}