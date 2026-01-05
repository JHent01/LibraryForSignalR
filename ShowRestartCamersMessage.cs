using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class ShowRestartCamersMessage
    {
       public bool CanSendRestartCameraMessage { get; set; }
        public ShowRestartCamersMessage( bool canSendRestartCameraMessage)
        {
             CanSendRestartCameraMessage = canSendRestartCameraMessage;
        }
    }
}
