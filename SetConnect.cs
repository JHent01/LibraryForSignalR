using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class SetConnect
    {
        public bool usSwapCain { get; set; }
        
        public int ID { get; set; }
        public SetConnect(bool usSwapCain , int ID)
        {
            this.usSwapCain = usSwapCain;
           
            this.ID = ID;
        }
    }
}
