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
    public partial class FrmChart : Form, IUpdate
    {

        List<Data> _lista = new List<Data>();
        string naziv;
        bool mode;


        public FrmChart()
        {
            InitializeComponent();
        }

        public FrmChart(string n, string i, bool b)
        {
            InitializeComponent();
            naziv = n;
            this.Text = n + i;
            mode = b;
            
            chGraph.Series.Add(naziv);
            if(mode)
                chGraph.ChartAreas[0].AxisY.LogarithmBase = 2;
            chGraph.ChartAreas[0].AxisY.IsLogarithmic = mode;


        }


        private void FrmChart_Load(object sender, EventArgs e)
        {
        }

        private void FrmChart_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void UpdateTemp(Data t)
        {
            if(naziv == "Temperature")
            {
                if (mode)
                {
                    if (t.Value > 0)
                    {
                        _lista.Add(t);
                        chGraph.Series[naziv].Points.AddXY(_lista.Count, t.Value);
                    }
                    else
                        return;
                }
                else
                {
                    _lista.Add(t);
                    chGraph.Series[naziv].Points.AddXY(_lista.Count, t.Value);
                }
            }
        }

        public void UpdatePress(Data p)
        {
            if (naziv == "Pressure")
            {
                _lista.Add(p);
                chGraph.Series[naziv].Points.AddXY(_lista.Count, p.Value);
            }
        }

        public void UpdateAH(Data ah)
        {
            if (naziv == "Air H")
            {
                _lista.Add(ah);
                chGraph.Series[naziv].Points.AddXY(_lista.Count, ah.Value);
            }
        }
    }
}
