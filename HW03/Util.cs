using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    internal class Util
    {
        public Util()
        { 
        }

        public string StringReverse(string str)
        {
            return string.Join("", str.Reverse());
        }
    }
}
