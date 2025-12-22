using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForSignalR
{
    public class MassegeFromModul
    {
        public string ModulName { get; set; }
        public string Message { get; set; }
        public string IDprocces { get; set; }
        public MassegeFromModul(string ModulName, string Message, string iDprocces)
        {
            this.ModulName = ModulName;

            this.Message = Message;
            IDprocces = iDprocces;
        }
    }
}
