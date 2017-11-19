using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteroloskaStanica___OOP_lab_4.Children;
using ProjectData;

namespace MeteroloskaStanica___OOP_lab_4
{
    public partial class FrmMain : Form
    {

        #region atributs
        private Data temp = new Data("Temperature");
        private Data press = new Data("Pressure");
        private Data airh = new Data("Air Humidity");
        private FrmGenerator gen;

        public Data Temp
        {
            get
            {
                return temp;
            }

            set
            {
                temp = value;
            }
        }

        public Data Press
        {
            get
            {
                return press;
            }

            set
            {
                press = value;
            }
        }

        public Data Airh
        {
            get
            {
                return airh;
            }

            set
            {
                airh = value;
            }
        }

        #endregion


        public FrmMain()
        {
            InitializeComponent();
        }
        

        public void Change()
        {
            foreach (Form f in MdiChildren)
            {
                IUpdate u = f as IUpdate;
                if (u != null)
                {
                    u.UpdateTemp(temp);
                    u.UpdatePress(press);
                    u.UpdateAH(airh);
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( gen != null)
                gen.Close();
        }

        private void generatorFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerator f = Exist();
            if (f == null)
            {
                FrmGenerator generator = new FrmGenerator();
                generator.MdiParent = this;
                gen = generator;
                generator.Show();
            }
            else
            {
                MessageBox.Show("You can't have two or more generators. Only one!");
            }
        }

        private void chartTempToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChart chartTemp = null;
            FrmGenerator f = Exist();
            if (f != null)
            {
                if (f.Checked())
                {
                    chartTemp = new FrmChart("Temperature", " Ignorise opseg", true);
                    chartTemp.MdiParent = this;
                }
                else
                {
                    chartTemp = new FrmChart("Temperature", "Uzima samo pozitivne vrednosti", false);
                    chartTemp.MdiParent = this;
                }
                chartTemp.Show();
            }
            else
            {
                MessageBox.Show("Generator is off. Turn it on.");
            }
        }

        private void chartPritisakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChart chartPress = null;
            FrmGenerator f = Exist();
            if (f != null)
            {
                if (f.Checked())
                {
                    chartPress = new FrmChart("Pressure", "Ignorise opseg", false);
                    chartPress.MdiParent = this;
                }
                else
                {
                    chartPress = new FrmChart("Pressure", "Uzima samo pozitivne vrednosti", false);
                    chartPress.MdiParent = this;
                }
                chartPress.Show();
            }
            else
            {
                MessageBox.Show("Generator is off. Turn it on.");
            }
        }

        private void chartVlaznostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChart chartAH = null;
            FrmGenerator f = Exist();
            if (f != null)
            {
                if (f.Checked())
                {
                    chartAH = new FrmChart("Air H", "Ignorise opseg", false);
                    chartAH.MdiParent = this;
                }
                else
                {
                    chartAH = new FrmChart("Air H", "Uzima samo pozitivne vrednosti", false);
                    chartAH.MdiParent = this;
                }
                chartAH.Show();
            }
            else
            {
                MessageBox.Show("Generator is off. Turn it on.");
            }
        }

        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistic s = new Statistic();
            s.MdiParent = this;
            s.Show();
        }

        public void ReturnToGenerator(Data data)
        {
            foreach (Form f in MdiChildren)
            {
                FrmGenerator gen = f as FrmGenerator;
                if (gen != null)
                {
                    gen.CallMinMax(data);
                    return;
                }
            }

        }
        private FrmGenerator Exist()
        {
            foreach (Form f in MdiChildren)
            {
                FrmGenerator pom = f as FrmGenerator;
                if (pom != null)
                    return pom;
            }
            return null;
        }
    }
}
