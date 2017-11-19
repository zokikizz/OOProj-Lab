using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___2.Lab
{
    public partial class Kategorija : Form
    {
        #region atributs
        private string[] kategorije = { "AM","A1", "A2", "A", "B1", "B", "BE" ,"C1","C1E","C",
            "CE", "D1", "D1E", "D", "E", "F", "M" };

        private List<Podaci.Kategorija> lista_kategorija;
        private List<Podaci.Kategorija> lista_zabrana;

        #endregion

        #region const/load
        public Kategorija(ref List<Podaci.Kategorija> l, ref List<Podaci.Kategorija> k,
            bool t)
        {
            InitializeComponent();

            lista_kategorija = l;
            lista_zabrana = k;
            if (t)
                this.Text = "Kategorija";
            else
                this.Text = "Zabrana";
        }

        private void Kategorija_Load(object sender, EventArgs e)
        {
            btnProsledi.DialogResult = DialogResult.OK;
            btnZatvori.DialogResult = DialogResult.Cancel;
            ProveraZaCmb();
            dpDo.CustomFormat = "dd.MM.yyyy";
            dpOd.CustomFormat = "dd.MM.yyyy";
            cbKategorija.SelectedIndex = 0;

        }
        #endregion

        #region events

       

        private void Kategorija_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Da li zelite da izadjete?", "?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region methods
        public void ProveraZaCmb()
        {
            if (this.Text.Equals("Kategorija"))
            {
                if (lista_kategorija.Count == 0) // ako nema ni jednu kategoriju, tj ako je novi onda
                    foreach (string r in kategorije) //mogu mu se dati sve kategorije
                        cbKategorija.Items.Add(r);
                else
                {// ako vec ima neke kategorije, ne mogu mu se dodati te iste
                    bool t = true;
                    foreach (string r in kategorije)
                    {
                        t = true;
                        foreach (var k in lista_kategorija)
                            if (((Podaci.Kategorija)k).Ktg.Equals(r))
                                t = false;
                        if (t)
                            cbKategorija.Items.Add(r);
                    }
                }
            }
            else
            {
                foreach (var r in lista_kategorija)
                    cbKategorija.Items.Add(r);
            }
        }

        #endregion

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if(this.Text == "Kategorija")
            {
                Podaci.Kategorija p = new Podaci.Kategorija((string)cbKategorija.SelectedItem,
                    dpDo.Value, dpOd.Value);
                if(!lista_kategorija.Contains(p))
                {
                    lista_kategorija.Add(p);
                    MessageBox.Show("Uspesno dodata osoba");
                    cbKategorija.Items.RemoveAt(cbKategorija.SelectedIndex);
                    cbKategorija.SelectedIndex = 0;
                }
            }
            else
            {
                Podaci.Kategorija p = new Podaci.Kategorija(cbKategorija.SelectedItem.ToString(),
                    dpDo.Value, dpOd.Value);
                if (!lista_zabrana.Contains(p))
                {
                    lista_zabrana.Add(p);
                    MessageBox.Show("Uspesno dodata osoba");
                    cbKategorija.Items.RemoveAt(cbKategorija.SelectedIndex);
                    cbKategorija.SelectedIndex = 0;
                }
            }
        }
    }
}
