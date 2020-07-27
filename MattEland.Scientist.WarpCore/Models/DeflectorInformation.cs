using System.Collections.Generic;
using MattEland.Scientist.WarpCore.Controllers;

namespace MattEland.Scientist.WarpCore.Models
{
    public class DeflectorInformation
    {
        public List<DeflectorReading> Readings { get; set; } = new List<DeflectorReading>();
    }
}