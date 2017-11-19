using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class CharExtension
    {
        public static string PretvoriUString(this char[] r )
        {
           string s = new string(r);
            return s; 
        }
    }
}
