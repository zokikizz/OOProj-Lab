using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extendion
{
    public static class StringExtend
    {
        public static string Path(this string s)
        {
            char[] niz = s.ToCharArray();
            for(int i = 0; i < s.Length-1; i++)
            {
                if(niz[i] == '\\' && niz[i+1] == '\\')
                {
                    for (int j = i + 1; j < s.Length - 1; j++)
                        niz[j] = niz[j + 1];
                }
            }
            s = new string(niz);
            return s;
        }

       /* public static string PathC(this char[]c)
        {
            string r = new string(;
            for(int i = 0; i < c.Length; i++)
            {
                string+
            }
        }*/
    }
}
