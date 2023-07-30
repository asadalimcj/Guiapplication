using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAplication
{
    class validation
    {
        public static bool StringCon(string fare)
        {
            int count = 0;
            foreach(var i in fare)
            {
                if (i >= 48 && i <= 57)
                {
                    count++;
                }
            }
            if (count == fare.Length)
            {
                return true;
            }
            return false;
        }
    }
}
