using System.Collections.Generic;

namespace FSync.Models
{
    public class Water
    {
        public IList<WaterLog> Log { get; private set; }

        public Water(IList<WaterLog> log)
        {
            Log = log;
        }
    }

    public class WaterLog
    {
        public int Amount { get; set; }
        public int LogId { get; set; } 
    }
}