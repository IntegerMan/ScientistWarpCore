using System.Collections.Generic;
using System.Linq;
using MattEland.Scientist.WarpCore.Models;

namespace MattEland.Scientist.WarpCore.ServiceLayer
{
    public class NacelleServiceLayer : INacelleServiceLayer
    {
        public NacelleServiceLayer()
        {
        }

        private readonly IDictionary<NacelleIdentifier, NacelleInformation> _nacelleInfo 
            = new Dictionary<NacelleIdentifier, NacelleInformation>();

        public void UpdateInfo(NacelleIdentifier id, NacelleInformation info)
        {
            _nacelleInfo[id] = info;
        }

        public IList<NacelleInformation> CurrentReadings => _nacelleInfo.Values.ToList();
    }
}