using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkStatus
{
    public class SpeedtestEntry
    {
        public double DownloadSpeedMbps
        {
            get;
            set;
         }
        public SpeedtestEntry(double DownloadSpeedMbps)
        {
            this.DownloadSpeedMbps = DownloadSpeedMbps;
        }
    }
}
