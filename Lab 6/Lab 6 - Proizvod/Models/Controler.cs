using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Models
{
    [Serializable]
    public class Controler :IContorler
    {

        #region atributs   
        private List<InstanceOfProduct> _listOfProducts;
        private List<StorageUnit> _listOfStorage; 

        public List<StorageUnit> ListOfStorage
        {
            get
            {
                return _listOfStorage;
            }

            set
            {
                _listOfStorage = value;
            }
        }

        public List<InstanceOfProduct> ListOfProducts
        {
            get
            {
                return _listOfProducts;
            }

            set
            {
                _listOfProducts = value;
            }
        }
        #endregion

        public Controler()
        {
            ListOfProducts = new List<InstanceOfProduct>();
            ListOfStorage = new List<StorageUnit>();
        }

        public void AddProduct(Product p, StorageUnit s)
        {
            ListOfProducts.Add(new InstanceOfProduct(p, s, DateTime.Now));
            bool b = true;
            foreach (InstanceOfProduct i in ListOfProducts)
                if (i.RefOfStorage.Code == s.Code)
                    b = true;
            if (b)
                ListOfStorage.Add(s);
        }

        public void Create()
        {
           


        }

        public void Read(StreamReader reader)
        {
            XmlSerializer sr = new XmlSerializer(typeof(Controler));

            Controler loadedData = (Controler)sr.Deserialize(reader);

            this.ListOfProducts = loadedData.ListOfProducts;
            this.ListOfStorage = loadedData.ListOfStorage;
        }

        public void Update(XmlTextWriter stream)
        {
            XmlSerializer Serial = new XmlSerializer(typeof(Controler));

            Serial.Serialize(stream, this);
        }

        public void Delete(StorageUnit s)
        {
            for(int i = 0; i < ListOfProducts.Count; i++)
                if (ListOfProducts[i].RefOfStorage.Code == s.Code)
                    ListOfProducts.Remove(ListOfProducts[i]);
        }


    }
}
