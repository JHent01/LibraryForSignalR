using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class ShowRestartCamersMessage
    {
       public bool CanSendRestartCameraMessage;
        public ShowRestartCamersMessage( bool canSendRestartCameraMessage)
        {
            this.CanSendRestartCameraMessage = canSendRestartCameraMessage;
        }
    }
}
