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

namespace Lab_6___Proizvod
{

    public partial class AddOrEditProduct : Form
    {
        private InstanceOfProduct instanca;

        public InstanceOfProduct Instanca
        {
            get
            {
                return instanca;
            }

            set
            {
                instanca = value;
            }
        }

        public AddOrEditProduct(List<StorageUnit> s)
        {
            InitializeComponent();
            Instanca = new InstanceOfProduct();

            cbStorage.Items.AddRange(s.ToArray());
        }

        public AddOrEditProduct(InstanceOfProduct i, List<StorageUnit> s)
        {
            InitializeComponent();

            if (i != null)
            {
                Instanca = i;
                this.Text = "Edit product";
            }
            else
            {
                Instanca = new InstanceOfProduct();
                
            }
            cbStorage.Items.AddRange(s.ToArray());
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbShelLife_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;

        }

        private void AddOrEditProduct_Load(object sender, EventArgs e)
        {
            cbState.Items.Add(State.OPENED);
            cbState.Items.Add(State.PACKED);
            cbState.SelectedItem = Instanca.StateOfProduct;

            cbStorage.SelectedItem = Instanca.RefOfStorage;
            
            tbName.Text = Instanca.RefOfProduct.Name;
            tbCode.Enabled = false;
            tbCode.Text = Instanca.RefOfProduct.Code;
            tbFit.Text = Instanca.RefOfProduct.FitAfterOpening.ToString();
            tbShelLife.Text = Instanca.RefOfProduct.ShelfLife.ToString();
            tbProducer.Text = Instanca.RefOfProduct.Producer;
            tbNo.Text = Instanca.NumberOfPackage.ToString();
            tbWeight.Text = Instanca.Weight.ToString();
            if (this.Text == "Edit product")
            {
                dtDateOfStorage.Value = Instanca.DateOfStorage;
                cbState.SelectedIndex = cbState.Items.IndexOf(Instanca.StateOfProduct);
                int g;
                for (g = 0; g < cbStorage.Items.Count; g++)
                    if (((StorageUnit)cbStorage.Items[g]).Code == Instanca.RefOfStorage.Code)
                        break;
                cbStorage.SelectedIndex = g;
            }
            


        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(((Control)sender).Text))
                ((Control)sender).BackColor = Color.Red;
            else
             ((Control)sender).BackColor = Color.White;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                this.DialogResult = DialogResult.OK;
                instanca.RefOfProduct.Name = tbName.Text;
                instanca.RefOfProduct.Producer = tbProducer.Text;
                instanca.RefOfProduct.ShelfLife = Int32.Parse(tbShelLife.Text);
                instanca.RefOfProduct.FitAfterOpening = Int32.Parse(tbFit.Text);
                instanca.StateOfProduct = (State)cbState.SelectedItem;
                instanca.RefOfStorage = (StorageUnit)cbStorage.SelectedItem;
                instanca.NumberOfPackage = Int32.Parse(tbNo.Text);
                double w = instanca.Weight;
                instanca.Weight = Double.Parse(tbWeight.Text);
                instanca.DateOfStorage = dtDateOfStorage.Value;

                if(this.Text != "Edit product")
                    ((StorageUnit)(cbStorage.SelectedItem)).TempWeight += instanca.Weight;
                else
                {
                    ((StorageUnit)(cbStorage.SelectedItem)).TempWeight = (((StorageUnit)(cbStorage.SelectedItem)).TempWeight - w) + instanca.Weight;
                }


                this.Close();
            }
        }

        public bool Validation()
        {
            if (String.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Invalid name of product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                if (String.IsNullOrEmpty(tbShelLife.Text) || Int32.Parse(tbShelLife.Text) < 0)
            {
                MessageBox.Show("Invalid Shelf life od product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(tbFit.Text) || Int32.Parse(tbFit.Text) < 0)
            {
                MessageBox.Show("Invalid Fit of opening for product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cbStorage.SelectedIndex == -1)
            {
                MessageBox.Show("You must select storage.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.Text != "Edit product")
            {
                if (((StorageUnit)(cbStorage.SelectedItem)).CapsityInWeight < (((StorageUnit)(cbStorage.SelectedItem)).TempWeight + Double.Parse(tbWeight.Text)))
                {
                    MessageBox.Show("Storage capacity is overflowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if(((StorageUnit)(cbStorage.SelectedItem)).CapsityInWeight < ((((StorageUnit)(cbStorage.SelectedItem)).TempWeight - instanca.Weight ) + Double.Parse(tbWeight.Text)))
                {
                    MessageBox.Show("Storage capacity is overflowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
