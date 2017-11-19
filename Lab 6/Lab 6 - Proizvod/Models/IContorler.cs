using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Models
{
    interface IContorler
    {
        void Create();


        void Read(StreamReader reader);

        void Update(XmlTextWriter stream);

         void Delete(StorageUnit s);

    }
}
