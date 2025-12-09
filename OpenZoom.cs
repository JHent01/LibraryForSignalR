using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class OpenZoom
    {
        public bool usSwapCain { get; set; }
        public int wind { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int ID { get; set; }
        public OpenZoom(bool usSwapCain, int wind, int width, int height, int ID)
        {
            this.usSwapCain = usSwapCain;
            this.wind = wind;
            this.width = width;
            this.height = height;
            this.ID = ID;
        }
    }
}
