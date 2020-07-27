using System.Collections.Generic;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public interface INacelleServiceLayer
    {
        void UpdateInfo(NacelleIdentifier id, NacelleInformation info);
        IList<NacelleInformation> CurrentReadings { get; }
    }
}