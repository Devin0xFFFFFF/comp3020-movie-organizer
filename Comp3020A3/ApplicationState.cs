using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    class ApplicationState
    {
        public MainForm form { get; set; }
        public object obj { get; set; }
        public string user { get; set; }

        public bool valid()
        {
            return (ApplicationManager.loggedIn == null && user == null) || (ApplicationManager.loggedIn != null && ApplicationManager.loggedIn.username.Equals(user));
        }
    }
}
