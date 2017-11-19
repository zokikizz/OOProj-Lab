using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5oop
{
    public partial class Form1 : Form
    {
        
        Controler con;
        List<PictureBox> selected = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
           
        }
        public void addControler(Controler c)
        {
            con = c;
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 ,pictureBox6,pictureBox7};
            c.create(100, true, d);
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
        }

        private void standardniToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(selected!=null)
            {
                PictureBox x = sender as PictureBox;
                karta tag = x.Tag as karta;
                tag.IsSelected = !tag.IsSelected;

                if (tag.IsSelected)
                {
                    if (selected.Count == 3)
                    {
                        MessageBox.Show("maksimalno tri slike");
                    }
                    else
                    {
                        x.BorderStyle = BorderStyle.FixedSingle;
                        selected.Add(x);
                    }
                }
                else
                {
                    x.BorderStyle = BorderStyle.None;
                    selected.Remove(x);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.swap(ref selected);
            for (int i = 0; i < selected.Count; i++)
            {
                karta x = selected[i].Tag as karta;
                selected[i].Image = new Bitmap(x.Slika, selected[i].Width, selected[i].Height);
                selected[0].BorderStyle = BorderStyle.None;
                selected[i].Update();
            }
           if(con.GetType()==typeof(Clasic))
            {
                selected = null;
                button1.Enabled = false;
            }
            else
            {
                selected = new List<PictureBox>();
            }
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.open(), "rezultat");
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
            selected = new List<PictureBox>();
            button1.Enabled = true;
            numericUpDown1.Value = 5;
            if(!con.UlogP((int)numericUpDown1.Value))
            {
                if(MessageBox.Show("do you want anather try","lost",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    con = new Clasic(this);
                    con.create(100, true, d);
                    con.UlogP((int)numericUpDown1.Value);
                    label1.Text = "stanje: " + con.Stanje.ToString();
                    label2.Text = "ulog: " + con.Ulog;
                }
            }
            else
            {
                con.restart(d);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            con = new Clasic(this);
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            con.create(100,true , d);
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            con = new Clasic(this);
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            con.create(100, false, d);
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            con = new texsas(this);
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            con.create(100, true, d);
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            con = new texsas(this);
            PictureBox[] d = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            con.create(100, false, d);
            con.UlogP((int)numericUpDown1.Value);
            label1.Text = "stanje: " + con.Stanje.ToString();
            label2.Text = "ulog: " + con.Ulog;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }
    }
}
