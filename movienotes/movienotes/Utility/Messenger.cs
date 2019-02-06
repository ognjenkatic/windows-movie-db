using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.Utility
{
    public class Messenger
    {
        private static Messenger _instance;

        public static Messenger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Messenger();
                }
                return _instance;
            }
        }

        private Messenger()
        {

        }

        public event EventHandler<NavigateMessageArgs> NavigateEvent;

        public void SendNavigateMessage(string pageName)
        {
            NavigateEvent?.Invoke(this, new NavigateMessageArgs
            {
                PageName = pageName
            });
;
        }

    }

    public class NavigateMessageArgs
    {
        public string PageName { get; set; }
    }
}
