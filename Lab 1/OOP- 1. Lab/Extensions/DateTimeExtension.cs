using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class DateTimeExtension
    {  // 20.
        public static string TrenutnoVreme(this DateTime d)
        {
            DateTime d1 = DateTime.Now;
            return d1.ToString("dd.MM.yyyy. HH:mm");
        }

    }
}
