using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringExtension
    {
        public static string VelikoSlovo(this string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            char[] r = s.ToArray();
            for (int i = 0; i < s.Length; i++)
                if (i == 0)
                    r[i] = Char.ToUpper(r[i]);
                else
                    r[i] = Char.ToLower(r[i]);
            s = r.PretvoriUString();
            return s;
        }
    }
}
