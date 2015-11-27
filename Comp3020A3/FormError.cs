using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp3020A3
{
    public class FormError
    {
        public string err_code { get; set; }
        public string err_msg { get; set; }

        public static string getErrorMessage(string code, List<FormError> errors)
        {
            string msg = "";
            int i = 0;

            while(i < errors.Count && !errors.ElementAt(i).err_code.Equals(code))
            {
                i++;
            }

            if(i < errors.Count)
            {
                msg = errors.ElementAt(i).err_msg;
            }

            return msg;
        }
    }
}
