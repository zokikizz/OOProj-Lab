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
    public class StorageUnit
    {

        #region atributs
        public string Code
        { get; set; }
        public string Name
        { get; set; }
        public int CapacityInPieces
        { get; set; }
        public double CapsityInWeight
        { get; set; }
        public double TempWeight
        { get; set; }

        #endregion

        public StorageUnit()
        {

        }


        public StorageUnit(StorageUnit s)
        {
            Code = s.Code;
            Name = s.Name;
            CapacityInPieces = s.CapacityInPieces;
            CapsityInWeight = s.CapsityInWeight;

        }


        public StorageUnit(string c, string n, int cip, double ciw)
        {
            Code = GenerateCode(null);
            Name = n;
            CapacityInPieces = cip;
            CapsityInWeight = ciw;
        }

        public StorageUnit(List<StorageUnit>s)
        {
            Code = GenerateCode(s);
        }


        public string GenerateCode(List<StorageUnit> lista)
        {
            string code = "";
            if (lista == null)
            {
                Random r = new Random();
                string bounds = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                code = new string(
                    Enumerable.Repeat(bounds, 8)
                              .Select(s => s[r.Next(s.Length)])
                              .ToArray());
                return code;
            }
            else
            {
                bool b = false;
                while (!b)
                {
                    Random r = new Random();
                    string bounds = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                    code = new string(
                        Enumerable.Repeat(bounds, 8)
                                  .Select(s => s[r.Next(s.Length)])
                                  .ToArray());
                    foreach (StorageUnit i in lista)
                    {
                        if (i.Code == code)
                            b = true;
                    }
                    if (b)
                        b = !b;
                    else
                        b = true;
                }
                return code;
            }
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
        public void ReadXML(string filename, StorageUnit r)
        {
            StreamReader rd = null;
            try
            {
                /// napravi se objekat koji je u stanju da cita podatke iz fajla
                rd = new StreamReader(filename, Encoding.Unicode);

                /// kreira se objekat serijalizatora koji moze da deserijalizuje 
                /// objekte klase student
               XmlSerializer sr = new XmlSerializer(typeof(StorageUnit));

                ///poziva se deserijalizacija
                StorageUnit loadedData = (StorageUnit)sr.Deserialize(rd);
                r.Name = loadedData.Name;
                r.Code = loadedData.Code;
                r.CapacityInPieces = loadedData.CapacityInPieces;
                r.CapsityInWeight = loadedData.CapsityInWeight;
                /// vraca se restaurirani objekat
            }
            catch(Exception e)
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
