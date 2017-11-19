using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public class Data
    {
        public double Value { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public string Name { get; set; }
        public bool Ignore { get; set; }


        public Data()
        {
            Ignore = false;
            Min = -1000;
            Max = 1000;
        }

        public Data(string N)
        {
            Name = N;
            Ignore = false;
            Min = -1000;
            Max = 1000;
        }


        public Data(Data pom)
        {
            this.Name = pom.Name;
            Ignore = pom.Ignore;
            Min = pom.Min;
            Max = pom.Max;
            this.Value = pom.Value;
        }

        public bool Validation(double temp)
        {
            if(Min < temp && temp < Max)
                return true;
            return false;
        }


       
    }
}
