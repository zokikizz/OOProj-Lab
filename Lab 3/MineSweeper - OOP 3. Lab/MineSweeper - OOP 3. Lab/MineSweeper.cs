using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MSObjects;
using System.IO;

namespace MineSweeper
{
    public partial class FrmMineSweeper : Form, IView
    { 
        #region atributs

        private ButtonMatrix Matrica;  //Control

        private int i, j, nmbOfMines;


        #endregion


        public FrmMineSweeper()
        {
            InitializeComponent();
        }


        #region interface

        /*public void CostumGame()
        {
            throw new NotImplementedException();
        }*/



        public DialogResult Quit()
        {
            DialogResult r = MessageBox.Show("Do u wanna exit?", "Exit",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r;
        }


        public void NewGame()
        {
            #region add-to-panel
            if (pnFild.Controls.Count > 0)
                pnFild.Controls.Clear();
            pnFild.AutoSize = true;

            Matrica = new ButtonMatrix(9, 9, 10);
            i = j = 9;
            nmbOfMines = 10;
            Button[,] b = Matrica.ReturnMatrix();
            foreach (Button tmpButton in b)
            {
                pnFild.Controls.Add(tmpButton);
            }


            #endregion
            
            
        }

        public void NewGame(int r, int t)
        {
            if (pnFild.Controls.Count > 0)
                pnFild.Controls.Clear();
            pnFild.AutoSize = true;

            Matrica = new ButtonMatrix(r, t, true);
            i = r;
            j = t;
            Button[,] b = Matrica.ReturnMatrix();
            foreach (Button tmpButton in b)
            {
                pnFild.Controls.Add(tmpButton);
            }
        }


        public void NewGame(int r, int t, bool h)
        {
            if (pnFild.Controls.Count > 0)
                pnFild.Controls.Clear();
            pnFild.AutoSize = true;

            Matrica = new ButtonMatrix(r, t, h);
            i = r;
            j = t;
            Button[,] b = Matrica.ReturnMatrix();
            foreach (Button tmpButton in b)
            {
                pnFild.Controls.Add(tmpButton);
            }
        }

        public void NewGame(int r, int t, int no)
        {
            #region add-to-panel
            if (pnFild.Controls.Count > 0)
                pnFild.Controls.Clear();
            pnFild.AutoSize = true;

            Matrica = new ButtonMatrix(r, t, no);
            i = r;
            j = t;
            nmbOfMines = no;
            Button[,] b = Matrica.ReturnMatrix();
            foreach (Button tmpButton in b)
            {
                pnFild.Controls.Add(tmpButton);
            }


            #endregion
            
        }




        #endregion

        #region events
        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }


        #region menustrip

        private void classicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }



        private void costumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCostumGame f = new frmCostumGame();
            DialogResult r = f.ShowDialog();
            if (r == frmCostumGame.dr)
                return;
            pnFild.Controls.Clear();
            NewGame(f.i, f.j, f.no_mine);
            i = f.i;
            j = f.j;
            nmbOfMines = f.no_mine;
        }

        private void FrmMineSweeper_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do u wanna exit?", "Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void administratorModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame(i, j);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Matrica.Administration_mod())
            {
                SaveFileDialog sf = new SaveFileDialog();
                sf.FileName = "game.txt";
                sf.Filter = "Text files (*.txt) | *.txt | All files(*.*) | *.*";

                DialogResult dr = sf.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    using (StreamWriter stream = new StreamWriter(sf.FileName))
                    {
                        Matrica.Save(stream);
                    }
                }
                NewGame();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Load = new OpenFileDialog();
            Load.FileName = "game.txt";
            Load.Filter = "Text files (*.txt) | *.txt | All files(*.*) | *.*";

            DialogResult dr = Load.ShowDialog();

            if(dr == DialogResult.OK)
            {
                NewGame(i, j, false);
                using (StreamReader reader = new StreamReader(Load.FileName))
                {
                    Matrica.Load(reader);
                }
                Matrica.NumbersOfMineInMatrix(i,j);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matrica.Print();
        }

        #endregion


        #endregion

    }
}
