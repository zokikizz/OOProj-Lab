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
    public partial class AddStorage : Form
    {
        private StorageUnit s;

        public StorageUnit S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public AddStorage(List<StorageUnit> l)
        {
            InitializeComponent();
            tbCode.Enabled = false;
            S = new StorageUnit(l);
        }

        public AddStorage(StorageUnit l)
        {
            InitializeComponent();
            tbCode.Enabled = false;
            S = l;
            this.Text = "Edit storage";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbCapacityInPieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == '.')
                e.Handled = true;
        }

        private void tbCapacityInWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == ',')
                e.Handled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {

                this.DialogResult = DialogResult.OK;
                s.Name = tbName.Text;
                s.CapacityInPieces = Int32.Parse(tbCapacityInPieces.Text);
                s.CapsityInWeight = Double.Parse(tbCapacityInWeight.Text);
                this.Close();
            }
        }

        private void AddStorage_Load(object sender, EventArgs e)
        {
            tbCode.Text = S.Code;
            if(this.Text == "Edit storage")
            {
                tbName.Text = s.Name;
                tbCapacityInPieces.Text = s.CapacityInPieces.ToString();
                tbCapacityInWeight.Text = s.CapsityInWeight.ToString();
            }
        }

        private bool Validation()
        {
            if (String.IsNullOrEmpty(tbName.Text))
                return false;
            else if (String.IsNullOrEmpty(tbCapacityInPieces.Text))
                return false;
            else if (String.IsNullOrEmpty(tbCapacityInWeight.Text))
                return false;
            else
                return true;
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text))
            {
                ((Control)sender).BackColor = Color.Red;
            }
            else
                ((Control)sender).BackColor = Color.White;
        }
    }
}
