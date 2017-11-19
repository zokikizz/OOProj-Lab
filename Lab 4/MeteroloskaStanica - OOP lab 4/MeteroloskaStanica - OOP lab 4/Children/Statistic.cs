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
    public partial class Statistic : Form, IUpdate
    {
        #region atributs

        private List<Data> _ah = new List<Data>();
        private List<Data> _p = new List<Data>();
        private List<Data> _t = new List<Data>();

        #endregion

        public Statistic()
        {
            InitializeComponent();
        }

        public void UpdateAH(Data ah)
        {
            if (!(ah.Value >= (2 * ah.Max)))
            {
                if (ah.Validation(ah.Value))
                {
                    _ah.Add(new Data(ah));
                    tbAH.Text = ah.Value.ToString();
                }
            }
            else
            {
                ((FrmMain)MdiParent).ReturnToGenerator(ah);
            }
        }

        public void UpdatePress(Data p)
        {
            if (!(p.Value >= (2 * p.Max)))
            {
                if (p.Validation(p.Value))
                {
                    _p.Add(new Data(p));
                    tbPress.Text = p.Value.ToString();
                }
            }
            else
            {
                ((FrmMain)MdiParent).ReturnToGenerator(p);
            }
        }

        public void UpdateTemp(Data t)
        {
            if (!(t.Value >= (2 * t.Max)))
            {
                if (t.Validation(t.Value))
                {
                    _t.Add(new Data(t));
                    tbTemp.Text = t.Value.ToString();
                }
            }
            else
            {
                ((FrmMain)MdiParent).ReturnToGenerator(t);
            }
        }



        private void Stat(int lastN)
        {
            if (lastN > 0)
            {
                List<List<Data>> pom = new List<List<Data>>() { this._t, this._p, this._ah };
                List<string> res = new List<string>();
                foreach (List<Data> prop in pom)
                {
                    if (prop.Count == 0)
                    {
                        res.Add("");
                        continue;
                    }

                    if (lastN <= 0 || lastN > prop.Count)
                        lastN = prop.Count;
                    string s = "avg: ";
                    double d = prop.Skip(prop.Count - lastN).Take(lastN).Average(a => a.Value);
                    s += d.ToString();
                    s += ", min: ";
                    s += prop.Skip(prop.Count - lastN).Take(lastN).Min(a => a.Value).ToString();
                    s += ", max: ";
                    s += prop.Skip(prop.Count - lastN).Take(lastN).Max(a => a.Value).ToString();
                    res.Add(s);
                }
                this.lbTemperature.Text = res[0];
                this.lbPressure.Text = res[1];
                this.lbAirHi.Text = res[2];

                this.lbTemperature.Visible = true;
                this.lbPressure.Visible = true;
                this.lbAirHi.Visible = true;
            }
            else
            {
                string r = "avg: 0 min: 0 max: 0";

                this.lbTemperature.Text = r;
                this.lbPressure.Text = r;
                this.lbAirHi.Text = r;

                this.lbTemperature.Visible = true;
                this.lbPressure.Visible = true;
                this.lbAirHi.Visible = true;
            }
        }

        private void cbStat_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                if (!String.IsNullOrEmpty(tbNo.Text))
                {
                    int n;
                    bool b = Int32.TryParse(tbNo.Text, out n);
                    if(b)
                        Stat(n);
                }
            }
            ((CheckBox)sender).Checked = false;
        }

        private void Statistic_Load(object sender, EventArgs e)
        {
            Stat(0);
        }
    }
}
