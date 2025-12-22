using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class PointsForZoom
    {
        
        public double xTL { get; set; }
        public double yTL { get; set; }   
        public double xBR { get; set; }
        public double yBR { get; set; }
       public PointsForZoom(double xTL, double yTL, double xBR, double yBR)
        {
            this.xTL = xTL;
            this.yTL = yTL;
            this.xBR = xBR;
            this.yBR = yBR;
            
        }
    }
}
