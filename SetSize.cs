using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class SetSize
    {
        public int width { get; set; }
        public int height { get; set; }
        public int ID { get; set; }
        public SetSize( int width, int height, int ID)
        {
            this.width = width;
            this.height = height;
            this.ID = ID;
        }
    }
}
