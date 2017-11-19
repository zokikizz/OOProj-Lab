using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Models
{
    public enum State
    {
        OPENED,
        PACKED
    }

    [Serializable]
    public class InstanceOfProduct
    {
        #region atributs

        public String ProductCode
        {
            get { return RefOfProduct.Code; }
        }
        public String Name
        {
            get { return RefOfProduct.Name; }
        }

        public string Producer
        { get { return this.RefOfProduct.Producer; } }

        public string FixedStorageIndetifiner
        { get; set; }

        public string InternalRunningNumber
        { get; set; }

        public StorageUnit RefOfStorage
        { get; set; }

        public Product RefOfProduct
        { get; set; }

        public State StateOfProduct
        { get; set; }

        public DateTime DateOfStorage
        { get; set; }

        private DateTime usuableTo = new DateTime();

        public DateTime UsuableTo
        {
            get
            {
                if (StateOfProduct == State.OPENED)
                    return usuableTo = DateOfStorage.AddDays(this.RefOfProduct.FitAfterOpening);
                else
                    return usuableTo = DateOfStorage.AddDays(this.RefOfProduct.ShelfLife);
            }
            set
            {
                this.usuableTo = value;
            }
        }

        public int NumberOfPackage
        { get; set; }

        public double Weight
        { get; set; }



        #endregion

        public InstanceOfProduct()
        {
            InternalRunningNumber = GenerateInternal();
            FixedStorageIndetifiner = GenerateFixed();
            RefOfProduct = new Product();
        }
        public InstanceOfProduct(Product p, StorageUnit s, DateTime stored)
        {
            InternalRunningNumber = GenerateInternal();
            FixedStorageIndetifiner = GenerateFixed();
            RefOfProduct = p;
            RefOfStorage = s;
            DateOfStorage = stored;
        }

        public string GenerateFixed()
        {
            Random r = new Random();
            string bounds = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = new string(
                Enumerable.Repeat(bounds, 12)
                          .Select(s => s[r.Next(s.Length)])
                          .ToArray());
            return code;
        }

        public string GenerateInternal()
        {
            Random r = new Random();
            string bounds = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = new string(
                Enumerable.Repeat(bounds, 22)
                          .Select(s => s[r.Next(s.Length)])
                          .ToArray());
            return code;
        }

        public void WriteXML(string filename)
        {
            XmlTextWriter wr = null;
            try
            {
                /// napravi se objekat koji je u stanju da upisuje u fajl
                wr = new XmlTextWriter(filename, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da serijalizuje 
                /// objekte klase student
                XmlSerializer sr = new XmlSerializer(typeof(InstanceOfProduct));

                ///poziva se serijalizacija
                sr.Serialize(wr, this);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if(wr != null)
                    wr.Close();
            }
        }
        public void ReadXML(string filename, InstanceOfProduct r)
        {
            StreamReader rd = null;
            try
            {
                /// napravi se objekat koji je u stanju da cita podatke iz fajla
                rd = new StreamReader(filename, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da deserijalizuje 
                /// objekte klase student
                XmlSerializer sr = new XmlSerializer(typeof(InstanceOfProduct));

                ///poziva se deserijalizacija
                InstanceOfProduct loadedData = (InstanceOfProduct)sr.Deserialize(rd);
                r.FixedStorageIndetifiner = loadedData.FixedStorageIndetifiner;
                r.InternalRunningNumber = loadedData.InternalRunningNumber;
                r.RefOfStorage = loadedData.RefOfStorage;
                r.StateOfProduct = loadedData.StateOfProduct;
                r.DateOfStorage = loadedData.DateOfStorage;
                r.UsuableTo = loadedData.UsuableTo;
                /// vraca se restaurirani objekat
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (rd != null)
                    rd.Close();
            }
        }
    }
 }
