using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Xml;
using System.IO;

namespace Lab_6___Proizvod
{
    public partial class Storage : Form
    {

        private Controler controler;

        public Storage()
        {
            InitializeComponent();


            controler = new Controler();

            string Load = "Storage.xml";

            using (StreamReader reader = new StreamReader(Load))
            {
                controler.Read(reader);
                ToList();
            }
            UpdateStorageBox();
        }

        public void ToList()
        {
            foreach(InstanceOfProduct i in controler.ListOfProducts)
            {
                foreach (StorageUnit s in controler.ListOfStorage)
                    if (i.RefOfStorage.Code == s.Code)
                        i.RefOfStorage = s;
            }
        }


        private void Storage_Load(object sender, EventArgs e)
        {
            //controler = new Controler();
            //Product p = new Product("da", "ne", new DateTime(), new DateTime());
            //StorageUnit s = new StorageUnit("sdferfsf", "sda", 21, (float)2.1);
            //controler.AddProduct(p, s);
            UpdateStorageBox();

        }

        public void UpdateStorageBox()
        {
            StorageBox.Items.Clear();
            StorageUnit[] s = controler.ListOfStorage.ToArray();
            for (int i = 0; i < s.Length; i++)
                StorageBox.Items.Add(s[i]);
        }

        private void btnNewStorage_Click(object sender, EventArgs e)
        {
            AddStorage AS = new AddStorage(this.controler.ListOfStorage);
            if(AS.ShowDialog() == DialogResult.OK)
            {
                controler.ListOfStorage.Add(AS.S);
                this.UpdateStorageBox();
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            if (controler.ListOfStorage.Count > 0)
            {
                AddOrEditProduct P = new AddOrEditProduct(controler.ListOfStorage);
                if (P.ShowDialog() == DialogResult.OK)
                {
                    controler.ListOfProducts.Add(P.Instanca);
                    this.UpdateList();
                }
                UpdateList();
            }
        }

        private void BtnEditProduct_Click(object sender, EventArgs e)
        {
            if (dgwProducts.SelectedRows.Count > 0)
            {
                AddOrEditProduct P = new AddOrEditProduct((InstanceOfProduct)(dgwProducts.SelectedRows[0].Tag), controler.ListOfStorage);
                if (P.ShowDialog() == DialogResult.OK)
                {
                    this.UpdateList();
                }
            }
        }

        public void UpdateList()
        {
            if(StorageBox.SelectedIndex != -1)
            {
                //foreach (InstanceOfProduct i in controler.ListOfProducts)
                //{
                //    if (i.RefOfStorage.Code.Equals(StorageBox.SelectedItem))
                //        dgwProducts.Rows.Add(i);
                //}
                //dgwProducts.DataSource = controler.ListOfProducts.Select(a => a.RefOfStorage.Code == ((StorageUnit)StorageBox.SelectedItem).Code);
                List<InstanceOfProduct> s = BackList((StorageUnit)StorageBox.SelectedItem);
                dgwProducts.DataSource = s;
                int i = 0;
                foreach (DataGridViewRow r in dgwProducts.Rows)
                {
                    if (s[i].UsuableTo < DateTime.Now)
                        r.DefaultCellStyle.ForeColor = Color.Red;
                    r.Tag = s[i];
                    i++;
                 }
                dgwProducts.Columns["RefOfProduct"].Visible = false;
                dgwProducts.Columns["RefOfStorage"].Visible = false;
                dgwProducts.Columns["NumberOfPackage"].Visible = false;
                dgwProducts.Columns["Weight"].Visible = false;
                    
                dgwProducts.Refresh();
            }
        }

        private void btnDeleteStorage_Click(object sender, EventArgs e)
        {
            if(StorageBox.SelectedIndex != -1)
            {
                controler.ListOfStorage.Remove((StorageUnit)StorageBox.SelectedItem);
                controler.Delete((StorageUnit)StorageBox.SelectedItem);
                StorageBox.Items.Remove(StorageBox.SelectedItem);

                StorageBox.SelectedItem = -1;
                StorageBox.Text = String.Empty;
                dgwProducts.DataSource = null;
                dgwProducts.Refresh();
            }
        }

        private void BtnEditStorage_Click(object sender, EventArgs e)
        {
            if (StorageBox.SelectedIndex > -1)
            {
                StorageUnit s = (StorageUnit)(StorageBox.SelectedItem);
                AddStorage As = new AddStorage(s);
                if(As.ShowDialog() == DialogResult.OK)
                {
                    ((StorageUnit)StorageBox.SelectedItem).Name = As.S.Name;
                    ((StorageUnit)StorageBox.SelectedItem).CapacityInPieces = As.S.CapacityInPieces;
                    ((StorageUnit)StorageBox.SelectedItem).CapsityInWeight = As.S.CapsityInWeight;
                    UpdateStorageBox();
                    StorageBox.SelectedIndex = -1;
                    StorageBox.SelectedIndex = StorageBox.Items.IndexOf(s);
                }
            }

        }

        private void StorageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        public List<InstanceOfProduct> BackList(StorageUnit s)
        {
            List<InstanceOfProduct> l = new List<InstanceOfProduct>();
            foreach(InstanceOfProduct i in controler.ListOfProducts)
            {
                if (s.Code.Equals(i.RefOfStorage.Code))
                    l.Add(i);
            }
            return l;
        }

        public void RemoveProduct(InstanceOfProduct s)
        {
            foreach (InstanceOfProduct i in controler.ListOfProducts)
            {
                if (s.RefOfProduct.Code == i.RefOfProduct.Code)
                {
                    controler.ListOfProducts.Remove(i);
                    return;
                }
            }

        }



        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if(dgwProducts.SelectedRows.Count > 0)
            {
                ((InstanceOfProduct)dgwProducts.SelectedRows[0].Tag).RefOfStorage.TempWeight -= ((InstanceOfProduct)dgwProducts.SelectedRows[0].Tag).Weight;
                RemoveProduct((InstanceOfProduct)dgwProducts.SelectedRows[0].Tag);
                List<InstanceOfProduct> s = BackList((StorageUnit)StorageBox.SelectedItem);
                dgwProducts.DataSource = s;
                int i = 0;
                foreach (DataGridViewRow r in dgwProducts.Rows)
                {
                    r.Tag = s[i];
                    i++;
                }
                dgwProducts.Refresh();
            }
        }



        #region events

        #region ms
        private void msCreate_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.FileName = "Storage.xml";
            Load.Filter = "Text files (*.xml) | *.xml | All files(*.*) | *.*";
            DialogResult dr = Load.ShowDialog();

            if (dr == DialogResult.OK)
            {
                File.Create(Load.FileName);
            }

            StorageBox.DataSource = new List<StorageUnit>();
            StorageBox.SelectedIndex = -1;
            controler.ListOfProducts = new List<InstanceOfProduct>();
            controler.ListOfStorage = new List<StorageUnit>();
            dgwProducts.DataSource = null;
            dgwProducts.Rows.Clear();

        }

        private void msDelete_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.FileName = "Storage.xml";
            Load.Filter = "Text files (*.xml) | *.xml | All files(*.*) | *.*";

            DialogResult dr = Load.ShowDialog();

            if (dr == DialogResult.OK)
            {
                File.Delete(Load.FileName);
            }
            UpdateStorageBox();
        }

        private void msOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.FileName = "Storage.xml";
            Load.Filter = "Text files (*.xml) | *.xml; | All files(*.*) | *.*;";
            

            DialogResult dr = Load.ShowDialog();

            if (dr == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(Load.FileName))
                {
                    controler.Read(reader);
                    ToList();
                }
            }
            UpdateStorageBox();
        }

        private void msUpdateOrSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "Storage.xml";
            sf.Filter = "Text files (*.xml) | *.xml | All files(*.*) | *.*";

            DialogResult dr = sf.ShowDialog();
            if (dr == DialogResult.OK)
            {
                using (XmlTextWriter stream = new XmlTextWriter(sf.FileName, Encoding.Unicode))
                {
                    controler.Update(stream);
                }
            }
        }

        #endregion


        #endregion
    }
}
