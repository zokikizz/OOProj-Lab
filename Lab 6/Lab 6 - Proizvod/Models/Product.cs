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
    [Serializable]
    public class Product
    {
        #region atributs
        public string Code
        { get; set; }

        public string Name
        { get; set; }

        public string Producer
        {   get; set; }

        public int ShelfLife
        {  get; set; }

        public int FitAfterOpening
        { get; set; }
        #endregion


        public Product()
        {
            Code = GenerateCode();
        }

        public Product(string n, string p, int sl, int fao)
        {
            Code = GenerateCode();
            Name = n;
            Producer = p;
            ShelfLife = sl;
            FitAfterOpening = fao;
        }

        public string GenerateCode()
        {
            Random r = new Random();
            string bounds = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = new string(
                Enumerable.Repeat(bounds, 15)
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
                XmlSerializer sr = new XmlSerializer(typeof(StorageUnit));

                ///poziva se serijalizacija
                sr.Serialize(wr, this);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (wr != null)
                    wr.Close();
            }
        }
        public void ReadXML(string filename, Product r)
        {
            StreamReader rd = null;
            try
            {
                /// napravi se objekat koji je u stanju da cita podatke iz fajla
                rd = new StreamReader(filename, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da deserijalizuje 
                /// objekte klase student
                XmlSerializer sr = new XmlSerializer(typeof(Product));

                ///poziva se deserijalizacija
                Product loadedData = (Product)sr.Deserialize(rd);
                r.Name = loadedData.Name;
                r.Code = loadedData.Code;
                r.FitAfterOpening = loadedData.FitAfterOpening;
                r.ShelfLife = loadedData.ShelfLife;
                r.Producer = loadedData.Producer;
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

        public override string ToString()
        {
            return this.Name;
        }
    
    }
}
