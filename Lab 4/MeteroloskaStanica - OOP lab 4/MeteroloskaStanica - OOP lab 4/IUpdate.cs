using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectData;

namespace MeteroloskaStanica___OOP_lab_4
{
    public interface IUpdate
    {
        void UpdateTemp(Data t);
        void UpdatePress(Data p);
        void UpdateAH(Data ah);
    }
}
