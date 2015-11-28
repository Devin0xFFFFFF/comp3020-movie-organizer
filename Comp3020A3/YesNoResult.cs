using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class YesNoResult
    {
        public static bool yes()
        {
            int yes = -1;
            ConfirmationForm form = new ConfirmationForm(ref yes);
            form.Show();
            

            return yes == 1;
        }
    }
}
