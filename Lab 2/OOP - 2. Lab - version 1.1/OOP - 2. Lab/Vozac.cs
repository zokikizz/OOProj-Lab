using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP___2.Lab
{
    public partial class Vozac : Form
    {
        #region atributs
        Podaci.Vozac_O vozac;
        #endregion


        #region const/load
        public Vozac(ref Podaci.Vozac_O v)
        {
            InitializeComponent();
            vozac = v;
            
        }

        private void Vozac_Load(object sender, EventArgs e)
        {
            cbPol.Items.Add('M');
            cbPol.Items.Add('Z');
            cbPol.SelectedIndex = 0;


            if (!String.IsNullOrEmpty(vozac.Ime))
            {// ako je prosledjen postojeci vozac za edit!
                tbbrVozacke.Text = vozac.Brvozacke;
                tbIme.Text = vozac.Ime;
                tbPrezime.Text = vozac.Prezime;
                if (vozac.Pol == 'M')
                    cbPol.SelectedIndex = 0;
                else
                    cbPol.SelectedIndex = 1;
                dpDatRodj.Value = vozac.Datrodj;
                dpDatDozOd.Value = vozac.Vaziod;
                dpDozDo.Value = vozac.Vazido;
                dgvKategorija.DataSource = vozac.ListaKategorija;
                dgvZabrana.DataSource = vozac.ListaZabrana;
                pbSlika.Image = Image.FromFile("Slike\\"
                    + vozac.Brvozacke + ".jpg");
                tbMestoIzadavanja.Text = vozac.Mesto_izdavanja;
            }




            //dugme prosledi vraca dialogrioult ok da znam kada da dodam vozaca u listu
            this.btnProsledi.DialogResult = DialogResult.OK;
            this.btnZatvori.DialogResult = DialogResult.Cancel;

            //slika se lepo prikaze sliku
            pbSlika.SizeMode = PictureBoxSizeMode.Zoom;


            if(String.IsNullOrEmpty(vozac.Ime))
                dgvKategorija.DataSource = new List<Podaci.Kategorija>();
            dgvKategorija.MultiSelect = false;
            dgvKategorija.Columns["Ktg"].HeaderText = "Kategorija";
            dgvKategorija.Columns["Od"].HeaderText = "Vazi od";
            dgvKategorija.Columns["Do"].HeaderText = "Vazi do";
            dgvKategorija.ReadOnly = true;

            if (String.IsNullOrEmpty(vozac.Ime))
                dgvZabrana.DataSource = new List<Podaci.Kategorija>();
            dgvZabrana.MultiSelect = false;
            dgvZabrana.Columns["Ktg"].HeaderText = "Kategorija";
            dgvZabrana.Columns["Od"].HeaderText = "Vazi od";
            dgvZabrana.Columns["Do"].HeaderText = "Vazi do";
            dgvZabrana.ReadOnly = true;

            dpDatDozOd.CustomFormat = "dd.MM.yyyy";
            dpDatRodj.CustomFormat = "dd.MM.yyyy";
            dpDozDo.CustomFormat = "dd.MM.yyyy";

        }
        #endregion

        #region events
        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if(Validation())
            {
                vozac.Ime = tbIme.Text;
                vozac.Prezime = tbPrezime.Text;
                vozac.Pol = (char)cbPol.SelectedItem;
                vozac.ListaZabrana = (List<Podaci.Kategorija>)dgvZabrana.DataSource;
                vozac.ListaKategorija = (List<Podaci.Kategorija>)dgvKategorija.DataSource;
                vozac.Brvozacke = tbbrVozacke.Text;
                vozac.Datrodj = dpDatRodj.Value;
                vozac.Vazido = dpDozDo.Value;
                vozac.Vaziod = dpDatDozOd.Value;

                this.Close();
            }
            else
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Danger",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnIzaberiSliku_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.DefaultExt = ".jpg";
            d.ShowDialog();
            string s = d.FileName;
            if (!String.IsNullOrEmpty(s) && !String.IsNullOrEmpty(tbbrVozacke.Text))
            {
                if(!Directory.Exists("Slike"))
                    Directory.CreateDirectory("Slike");
                string path = "C:\\Users\\Kizz\\Documents\\Visual Studio 2015" +
                    "\\Projects\\OOP - 2. Lab\\OOP - 2. Lab\\bin\\Debug\\Slike\\" 
                    + tbbrVozacke.Text + ".jpg";
                if(File.Exists(path))
                    File.Delete(path);
                File.Copy(s, path, true);
                pbSlika.Image = Image.FromFile(path);
            }
        }

        private void btnDodajKategoriju_Click(object sender, EventArgs e)
        { //za dodavanje kategorije

            List<Podaci.Kategorija> lista = (List<Podaci.Kategorija>)dgvKategorija.DataSource;
            List<Podaci.Kategorija> lista_z = (List<Podaci.Kategorija>)dgvZabrana.DataSource;
            Kategorija k = new Kategorija(ref lista, ref lista_z, true);
            k.ShowDialog();
            dgvKategorija.DataSource = lista;
            ToListK();
        }

        private void btnObrisiKategoriju_Click(object sender, EventArgs e)
        { //za brisanje kategorije
            if (dgvKategorija.SelectedRows.Count == 1 ||
                dgvKategorija.SelectedCells.Count == 1)
            {
                if (dgvKategorija.SelectedCells.Count == 1)
                {
                    List<Podaci.Kategorija> k = (List<Podaci.Kategorija>)dgvKategorija.DataSource;
                    k.RemoveAt(dgvKategorija.SelectedCells[0].RowIndex);
                }
                else
                {
                    List<Podaci.Kategorija> k = (List<Podaci.Kategorija>)dgvKategorija.DataSource;
                    k.RemoveAt(dgvKategorija.SelectedRows[0].Index);
                }
                ToListK();
            }
        }

        private void btnDodajZabranu_Click(object sender, EventArgs e)
        {//za dodavanje zabrane

            List<Podaci.Kategorija> lista = (List<Podaci.Kategorija>)dgvKategorija.DataSource;
            List<Podaci.Kategorija> lista_z = (List<Podaci.Kategorija>)dgvZabrana.DataSource;
            Kategorija k = new Kategorija(ref lista, ref lista_z, false);
            k.ShowDialog();
            dgvZabrana.DataSource = lista_z;
            ToListZ();
        }

        private void btnObrisiZabranu_Click(object sender, EventArgs e)
        {//za brisanje zabrane
            if (dgvZabrana.SelectedRows.Count == 1 ||
       dgvZabrana.SelectedCells.Count == 1)
            {
                if (dgvZabrana.SelectedCells.Count == 1)
                {
                    List<Podaci.Kategorija> k = (List<Podaci.Kategorija>)dgvZabrana.DataSource;
                    k.RemoveAt(dgvZabrana.SelectedCells[0].RowIndex);
                }
                else
                {
                        List<Podaci.Kategorija> k = (List<Podaci.Kategorija>)dgvZabrana.DataSource;
                        k.RemoveAt(dgvZabrana.SelectedRows[0].Index);
                }
                ToListZ();
            }
        }

        private void Vozac_FormClosing(object sender, FormClosingEventArgs e)
        { // prilikom zatvaranja forme
            DialogResult r = MessageBox.Show("Da li zelite da izadjete?", "?",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void tbIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tbbrVozacke_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #region methods

        private bool Validation()
        {
            if (String.IsNullOrEmpty(tbIme.Text) || String.IsNullOrEmpty(tbPrezime.Text)
                || String.IsNullOrEmpty(tbbrVozacke.Text) ||
                    String.IsNullOrEmpty(tbMestoIzadavanja.Text)
                    || dgvKategorija.RowCount == 0 || // mora da doda makar jednu kategoriju
                    pbSlika.Image == null)//ako treba i slika samo jos pbSlika.Image ==null
            {
                if(pbSlika.Image == null)
                    btnIzaberiSliku.BackColor = Color.Red;
                else
                    btnIzaberiSliku.BackColor = Color.White;


                if (dpDatRodj.Value < dpDatDozOd.Value)
                {
                    lbVaziDo.BackColor = Color.Red;
                }
                else
                    lbVaziDo.BackColor = Color.White;



                if (dpDozDo.Value.Year - dpDatDozOd.Value.Year < 1)
                {
                    lbVaziDo.BackColor = Color.Red;
                }
                else
                    lbVaziDo.BackColor = Color.White;



                if (tbIme.Text == String.Empty)
                    tbIme.BackColor = Color.Red;
                else
                    tbIme.BackColor = Color.White;


                if (tbPrezime.Text == String.Empty)
                    tbPrezime.BackColor = Color.Red;
                else
                    tbPrezime.BackColor = Color.White;


                if (tbbrVozacke.Text == String.Empty)
                {
                    tbbrVozacke.BackColor = Color.Red;
                }
                else
                    tbbrVozacke.BackColor = Color.White;


                if (dgvKategorija.RowCount == 0)
                    dgvKategorija.BackgroundColor = Color.Red;
                else
                    dgvKategorija.BackgroundColor = Color.White;


                return false;  
            }
            return true;
        }


        private void ToListK()
        {
            dgvKategorija.DataSource = 
                ((List<Podaci.Kategorija>)dgvKategorija.DataSource).ToList();
        }


        private void ToListZ()
        {
            dgvZabrana.DataSource =
               ((List<Podaci.Kategorija>)dgvZabrana.DataSource).ToList();
        }






        #endregion

        private void dpDatDozOd_Leave(object sender, EventArgs e)
        {
            if (dpDatRodj.Value < dpDatDozOd.Value)
            {
                lbVaziDo.BackColor = Color.Red;
            }
            else
                lbVaziDo.BackColor = Color.White;
        }

        private void dpDozDo_Leave(object sender, EventArgs e)
        { // button.tag je tipa object i moze se koristiti za bilo sta za bilo koji obj u pozadini
            if (dpDozDo.Value.Year - dpDatDozOd.Value.Year < 1)
            {
                lbVaziDo.BackColor = Color.Red;
            }
            else
                lbVaziDo.BackColor = Color.White;
        }

        private void tbIme_Leave(object sender, EventArgs e)
        {
            if (tbIme.Text == String.Empty)
                tbIme.BackColor = Color.Red;
            else
                tbIme.BackColor = Color.White;
        }

        private void tbPrezime_Leave(object sender, EventArgs e)
        {
            if (tbPrezime.Text == String.Empty)
                tbPrezime.BackColor = Color.Red;
            else
                tbPrezime.BackColor = Color.White;
        }

        private void tbbrVozacke_Leave(object sender, EventArgs e)
        {
            if (tbbrVozacke.Text == String.Empty)
            {
                tbbrVozacke.BackColor = Color.Red;
            }
            else
                tbbrVozacke.BackColor = Color.White;
        }

        private void dgvKategorija_Leave(object sender, EventArgs e)
        {
            if (dgvKategorija.RowCount == 0)
                dgvKategorija.BackgroundColor = Color.Red;
            else
                dgvKategorija.BackgroundColor = Color.White;
        }
    }
}
