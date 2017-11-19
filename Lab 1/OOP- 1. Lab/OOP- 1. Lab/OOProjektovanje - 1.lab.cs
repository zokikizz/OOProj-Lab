using System;
using System.Windows.Forms;
using System.Linq;
using Extensions;
using System.Text.RegularExpressions;
using Osobe1;

namespace OOP__1.Lab
{
    public partial class Form1 : Form
    {
        #region atributi

        int oznacen = -1; //sluzi mi da vidim da li je iko oznacen na dvoklik, 
        //-1 je vrednost koja nam govori da nije niko oznacen
        #endregion

        #region constructor/load
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // 4.
        {
            LoadList();
            dtDatRodj.CustomFormat = "dd.MM.yyyy"; //za format kalendara


            //23.

            cbSort.Items.Add(new Delegat("Po imenu", 
                new Sort(ListaOsoba.Instance.SortIme)));
            cbSort.Items.Add(new Delegat("Po prezimenu",
                new Sort(ListaOsoba.Instance.SortPrezime)));
            cbSort.Items.Add(new Delegat("Po datumu rodjenja",
                new Sort(ListaOsoba.Instance.SortDatRodj)));
            //cbSort.Items.Add("Po imenu");
            //cbSort.Items.Add("Po prezimenu");
            //cbSort.Items.Add("Po datumu rodjenja");
            cbSort.SelectedIndex = 0;
                

        }

        #endregion

        #region events

        private void tbIme_Leave(object sender, EventArgs e)
        {
            tbIme.Text = tbIme.Text.VelikoSlovo();
        }

        private void tbPrezime_Leave(object sender, EventArgs e)
        {
            tbPrezime.Text = tbPrezime.Text.VelikoSlovo();
        }


        private void tbIme_KeyPress(object sender, KeyPressEventArgs e) // 2.
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }




        private void tbPrezime_KeyPress(object sender, KeyPressEventArgs e) //2.
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        




        private void tbTel_Leave(object sender, EventArgs e) //3.
        {
            Regex r = new Regex(@"^[+]\d{3}\s\d{2}\s\d{7}$"); //za proveru formata caka
            //\d{n} n- koliko karaktera ocekujemo \s - space i plus kao obavezni deo
            if (r.Match(tbTel.Text).Success)
                return;
            else
                MessageBox.Show("Niste uneli dobar format broja telefona",
                    "Pogresan format", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private void btnZapamti_Click(object sender, EventArgs e) //5. , 6. , 17.
        {
            if(oznacen > -1)
            { //azuriranje
                Osobe1.ListaOsoba.Instance.Lista[oznacen].Ime = tbIme.Text;
                Osobe1.ListaOsoba.Instance.Lista[oznacen].Prezime = tbPrezime.Text;
                Osobe1.ListaOsoba.Instance.Lista[oznacen].Datrodj = dtDatRodj.Value.Date;
                Osobe1.ListaOsoba.Instance.Lista[oznacen].Broj = tbTel.Text;
                Osobe1.ListaOsoba.Instance.Lista[oznacen].Stanuje = tbAdr.Text;
                oznacen = -1;
                LoadList();
            }
            else if (Validation()) //5.
            {
                 Osoba o = new Osoba(tbIme.Text, tbPrezime.Text, tbTel.Text,
                    dtDatRodj.Value, tbAdr.Text);
                if (Osobe1.ListaOsoba.Instance.Dodaj(o)) //6.
                {
                    MessageBox.Show("Uspesno dodata osoba.", "Obavestenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                    this.ActiveControl = tbIme; // 17.
                    return;
                }
                else
                    MessageBox.Show("Osoba vec postoji.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Niste pounili sve potrebne podatke za unos.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }




        private void btnPonisti_Click(object sender, EventArgs e) //7.
        {
            tbIme.Text = String.Empty;
            tbPrezime.Text = String.Empty;
            tbTel.Text = String.Empty;
            tbAdr.Text = String.Empty;
            dtDatRodj.Text = DateTime.Now.ToShortDateString();
            oznacen = -1;
        }



        private void btnObrisiosobu_Click(object sender, EventArgs e)  //8.
        {
            if (lbListaOsoba.SelectedValue != null)
            {
                DialogResult res = MessageBox.Show(((Osoba)lbListaOsoba.SelectedValue).PRINT +
                    "\nDa li zelite da obriste ovu osobu?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    Osobe1.ListaOsoba.Instance.Obrisi((Osoba)lbListaOsoba.SelectedValue);
                    LoadList();

                    MessageBox.Show("Uspesno obrisana osoba.", "Obavestenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }

        }




        private void btnObrisilistu_Click(object sender, EventArgs e) //9.
        {
            DialogResult res = MessageBox.Show("Da li zelite da obrisete sve Osobe1?",
                "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Osobe1.ListaOsoba.Instance.ObrisiSve();
                LoadList();
                MessageBox.Show("Uspesno su obrisane sve Osobe1.", "Obavestenje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSort_Click(object sender, EventArgs e) //10.
        {
            Sort d = ((Delegat)cbSort.SelectedItem).Sortiraj;
            d();
            LoadList();
            //if ((cbSort.SelectedIndex == -1) || ( cbSort.SelectedIndex > 2))
            //    return;
            //if (cbSort.SelectedIndex == 0)
            //{
            //    Sort s = new Sort(Osobe1.ListaOsoba.Instance.SortIme);
            //    s();
            //    MessageBox.Show("Lista osoba je sortirana po imenu.", "Obavestenje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (cbSort.SelectedIndex == 1)
            //{
            //    Sort s = new Sort(Osobe1.ListaOsoba.Instance.SortPrezime);
            //    s();
            //    MessageBox.Show("Lista osoba je sortirana po prezimenu.", "Obavestenje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    Sort s = new Sort(Osobe1.ListaOsoba.Instance.SortDatRodj);
            //    s();
            //    MessageBox.Show("Lista osoba je sortirana po datumu rodjenja.", "Obavestenje",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //LoadList();
        }





        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 11.
        {
            DialogResult res = MessageBox.Show("Da li zelite da izadjete?", "Izadji?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }


        //12.MessageBox nakon svake akcije, odradjeno



        private void lbListaOsoba_DoubleClick(object sender, EventArgs e) //13.
        {
            Osoba osoba = (Osoba)lbListaOsoba.SelectedItem;
            tbIme.Text = osoba.Ime;
            tbPrezime.Text = osoba.Prezime;
            tbTel.Text = osoba.Broj;
            tbAdr.Text = osoba.Stanuje;
            dtDatRodj.Text = osoba.Datrodj.ToString();
            oznacen = lbListaOsoba.SelectedIndex;
            
        }


        //14. omoguci editovanje

        //15. forma fiksnix dimenzija, odradjeno u popertiju tako sto je
        // i minsize i maxsize forme isti kolika je forma i na pocetku

        // 16. urediti taborder, odradjeno


        private void Form1_DoubleClick(object sender, EventArgs e) //21.
        {
            MessageBox.Show(DateTimeExtension.TrenutnoVreme(DateTime.Now),
                "Trenutno vreme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        #endregion


        #region methods




        private void LoadList() // 4. , 22. za ucitavanje listeosoba u listbox
        {
            lbListaOsoba.DisplayMember = "PRINT";
            lbListaOsoba.DataSource = Osobe1.ListaOsoba.Instance.Lista.ToList();
        }





        private bool Validation() //5.
        {
            if (!(String.IsNullOrEmpty(tbIme.Text) && String.IsNullOrEmpty(tbPrezime.Text)
                && String.IsNullOrEmpty(tbTel.Text) && String.IsNullOrEmpty(tbAdr.Text)))
                return true;
            return false;
        }



        #endregion


        //24. pridruzene su ikonice
    }
}
