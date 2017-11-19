using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace OOP___2.Lab
{
    public partial class Lista_vozaca : Form
    {
        #region atributs
        private Timer t = null;

        #endregion


        #region constructors/load
        public Lista_vozaca()
        {
            InitializeComponent();
        }

        private void Lista_vozaca_Load(object sender, EventArgs e)
        {
            cbSort.Items.Add(new Delegat("Po imenu",
                new Delegat.Sort(Podaci.ListaVozaca.Instance.SortIme)));
            cbSort.Items.Add(new Delegat("Po Prezimenu",
                new Delegat.Sort(Podaci.ListaVozaca.Instance.SortPrezime)));
            cbSort.Items.Add(new Delegat("Po vozackoj",
                new Delegat.Sort(Podaci.ListaVozaca.Instance.SortBrVoz)));
            cbSort.SelectedIndex = 0;

            t = new Timer();
            t.Interval = 1000;
            t.Start();
            t.Tick += t_Tick;
            lbTime.Text = String.Empty;
            gbListaVozaca.Text = "Lista vozaca";
            dgvVozaci.MultiSelect = false;

            LoadList();
        }

        #endregion

        #region events

        private void t_Tick(object sender, EventArgs e)
        {
            lbTime.Text = "Sat: " + DateTime.Now.ToString("HH:mm:ss")
                + " Datum: " + DateTime.Now.ToString("dd.MM.yyyy");

        }


        private void btnDodajVozaca_Click(object sender, EventArgs e)
        {//add
            Podaci.Vozac_O v = new Vozac_O();
            Form f = new Vozac(ref v);
            //f.Visible = true;
            DialogResult dr = f.ShowDialog();
            Podaci.ListaVozaca.Instance.ReturnList.Add(v);
            LoadList();

        }

        private void btnObrisiVozaca_Click(object sender, EventArgs e)
        { // delete
            if (dgvVozaci.SelectedRows.Count == 1 ||
               dgvVozaci.SelectedCells.Count == 1)
            {
                if (dgvVozaci.SelectedCells.Count == 1)
                {
                    Podaci.ListaVozaca.Instance.ReturnList.RemoveAt(dgvVozaci.SelectedCells[0].RowIndex);
                }
                else
                {
                    Podaci.ListaVozaca.Instance.ReturnList.RemoveAt(dgvVozaci.SelectedRows[0].Index);
                }
                LoadList();
            }
        }


        private void btnIzmeni_Click(object sender, EventArgs e)
        {  // edit
            if (dgvVozaci.SelectedRows.Count == 1)
            {
                Podaci.Vozac_O v = Podaci.ListaVozaca.Instance.ReturnList[dgvVozaci.SelectedRows[0].Index];
                Vozac f = new Vozac(ref v);
                f.ShowDialog();
                LoadList();
            }
        }


        private void Lista_vozaca_FormClosing(object sender, FormClosingEventArgs e)
        {//close
            DialogResult r = MessageBox.Show("Da li zelite da izadjete?", "?",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region methods

        private void LoadList()
        {//ucitaj listu
            dgvVozaci.DataSource = Podaci.ListaVozaca.Instance.ReturnList.ToList();
            dgvVozaci.Columns["PRINT"].Visible = false;
            dgvVozaci.Columns["Pol"].Visible = false;
            dgvVozaci.Columns["Datrodj"].Visible = false;
            dgvVozaci.Columns["Vazido"].Visible = false;
            dgvVozaci.Columns["Vaziod"].Visible = false;

            dgvVozaci.ReadOnly = true;

            //dgv automatic size rows
            /*dgvVozaci.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;*/
        }


        #endregion

        private void btnSort_Click(object sender, EventArgs e)
        {
            ((Delegat)cbSort.SelectedItem).Sort1();
            LoadList();
        }

      


        
    }
}
