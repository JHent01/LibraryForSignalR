using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class MessageClousedModul
    {
        public string ModulName { get; set; }
        public string Message { get; set; }
        public MessageClousedModul(string ModulName, string Message  )
        {
            this.ModulName = ModulName;

            this.Message = Message;
        }
    }
}
