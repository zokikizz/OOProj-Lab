using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteroloskaStanica___OOP_lab_4;
using ProjectData;

namespace MeteroloskaStanica___OOP_lab_4.Children
{
    public partial class FrmGenerator : Form
    {

        public FrmGenerator()
        {
            InitializeComponent();
            tmGen.Interval = 1000;
            tmGen.Start();
        }

        private void tbTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
            if (!String.IsNullOrEmpty(((TextBox)sender).Text) && ((e.KeyChar == '-') || (e.KeyChar == '+')))
                e.Handled = true;
            if (e.KeyChar == '_' || e.KeyChar == '/' 
                || e.KeyChar == '*'  || e.KeyChar == ',' ||
                e.KeyChar == '?' || e.KeyChar == '|' || e.KeyChar == '=')
                e.Handled = true;

        }

        private void FrmGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmGenerator_Load(object sender, EventArgs e)
        {
            btnTemp.Tag = ((FrmMain)MdiParent).Temp;
            btnPress.Tag = ((FrmMain)MdiParent).Press;
            btnairh.Tag = ((FrmMain)MdiParent).Airh;
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Data data = (Data)(b.Tag);
            if (data != null)
            {
                FrmMinMax Min_Max = new FrmMinMax(data);
                Min_Max.MdiParent = this.MdiParent;
                Min_Max.Show();
            }
        }

        public void CallMinMax(Data data)
        {
            if (data != null)
            {
                FrmMinMax Min_Max = new FrmMinMax(data);
                Min_Max.MdiParent = this.MdiParent;
                Min_Max.Show();
            }
        }


        private void WriteInTag()
        {

            #region temp
            if (tbTemperature.Text.Length > 0)
            {
                double t = double.Parse(tbTemperature.Text);
                if (!cbIgnore.Checked)
                {
                    if (((Data)(btnTemp.Tag)).Validation(t))
                    {
                        ((Data)(btnTemp.Tag)).Value = t;
                    }
                    else
                    {
                        MessageBox.Show(((Data)(btnTemp.Tag)).Name + " is out of bounds." +
                            "Becouse that it won't be sand to another forms."
                            , "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ((Data)(btnTemp.Tag)).Value = t;
                }
            }

            #endregion


            #region press
            if (tbPressure.Text.Length > 0)
            {
                double p = double.Parse(tbPressure.Text);
                if (!cbIgnore.Checked)
                {
                    if (((Data)(btnPress.Tag)).Validation(p))
                    {
                        ((Data)(btnPress.Tag)).Value = p;
                    }
                    else
                    {
                        MessageBox.Show(((Data)(btnPress.Tag)).Name + " is out of bounds." +
                            "Becouse that it won't be sand to another forms."
                            , "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ((Data)(btnPress.Tag)).Value = p;
                }
            }


            #endregion


            #region airh
            if (tbAirHumidity.Text.Length > 0)
            {
                double ah = double.Parse(tbAirHumidity.Text);
                if (!cbIgnore.Checked)
                {
                    if (((Data)(btnairh.Tag)).Validation(ah))
                    {
                        ((Data)(btnairh.Tag)).Value = ah;
                    }
                    else
                    {
                        MessageBox.Show(((Data)(btnairh.Tag)).Name + " is out of bounds." +
                            "Becouse that it won't be sand to another forms."
                            , "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    ((Data)(btnairh.Tag)).Value = ah;
                }
            }
            #endregion
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            WriteInTag(); // napunim value mojih objekata vrednostim tb-va temp, press i ah
            ((FrmMain)MdiParent).Change();
        }

        public bool Checked()
        {
            if (cbIgnore.Checked)
                return true;
            return false;
        }

        private void tmGen_Tick(object sender, EventArgs e)
        {
            if(cbGeninSec.Checked)
            {
                int g;
                Int32.TryParse(tbSecounds.Text, out g);
                tmGen.Interval =  g * 1000;
                Random r = new Random();
                ((Data)(btnTemp.Tag)).Value = r.Next(0, 300);
                tbTemperature.Text = ((Data)(btnTemp.Tag)).Value.ToString();
                ((Data)(btnPress.Tag)).Value = r.Next(0, 300);
                tbTemperature.Text = ((Data)(btnTemp.Tag)).Value.ToString();
                ((Data)(btnairh.Tag)).Value = r.Next(0, 300);
                tbTemperature.Text = ((Data)(btnTemp.Tag)).Value.ToString();
                btnSend.Enabled = false;
                WriteInTag();
                ((FrmMain)MdiParent).Change();
            }
            else
            {
                tmGen.Interval = 1000;
                btnSend.Enabled = true;
            }
        }
    }
}
