using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectData;

namespace MeteroloskaStanica___OOP_lab_4.Children
{
    public partial class FrmMinMax : Form
    {
        private Data podatak;


        public FrmMinMax(Data d)
        {
            InitializeComponent();

            podatak = d;
            this.Text = podatak.Name;
        }

        public FrmMinMax()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(Double.Parse(tbMin.Text) > Double.Parse(tbMax.Text))
            {
                MessageBox.Show("Somthing is wrong. Probably you input Min value to be greater then Max velue",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                podatak.Min = Double.Parse(tbMin.Text);
                podatak.Max = Double.Parse(tbMax.Text);
                MessageBox.Show("You have successfully changed Min and Max value of" + podatak.Name,
                    "Successfully changed Min/Max Value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void tbMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            if (e.KeyChar == ',' || e.KeyChar == '*' || e.KeyChar == '/' || e.KeyChar == '_' || e.KeyChar == '='
                || e.KeyChar == '|')
                e.Handled = true;
            if (!String.IsNullOrEmpty(((TextBox)(sender)).Text) &&  (e.KeyChar == '+' || e.KeyChar == '-'))
                e.Handled = true;
        }

        private void FrmMinMax_Load(object sender, EventArgs e)
        {
            tbMax.Text = podatak.Max.ToString();
            tbMin.Text = podatak.Min.ToString();
        }
    }
}
