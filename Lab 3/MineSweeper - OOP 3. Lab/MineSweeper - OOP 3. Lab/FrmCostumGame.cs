using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class frmCostumGame : Form
    {
        #region atributs
        public int i, j, no_mine;
        public static DialogResult dr = DialogResult.No;
        #endregion

        public frmCostumGame()
        {
            InitializeComponent();
        }

        private void tbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void frmCostumGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tbi.Text == String.Empty || tbj.Text == String.Empty || tbmine.Text == String.Empty)
                 this.DialogResult = DialogResult.No;
            else
                this.DialogResult = DialogResult.OK;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbi.Text == String.Empty || tbj.Text == String.Empty || tbmine.Text == String.Empty)
            {
                MessageBox.Show("Niste popunili sva polja!");
            }
            else
            {
                i = Int32.Parse(tbi.Text);
                j = Int32.Parse(tbj.Text);
                no_mine = Int32.Parse(tbmine.Text);
                this.Close();
            }
        }

        private void frmCostumGame_Load(object sender, EventArgs e)
        {
            btnStart.DialogResult = DialogResult.Yes;
        }
    }
}
