using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MSObjects
{
    public class ButtonMatrix : IControl
    {
        #region atributs
        private Button[,] matrix;
        private int row;
        private int column;
        private int br_mina;
        private int br_flagova;
        private Timer timer;
        private ImageList lista_slika;
        bool administration_mod;

        #endregion

        public ButtonMatrix(int i, int j, int br)
        {
            #region pravljenje potrebnih atributa

            matrix = new Button[i, j];
            lista_slika = new ImageList();
            administration_mod = false;


            if (Directory.Exists("MineSweeperr1"))
            {
                string[] r = Directory.GetFiles("MineSweeperr1");
                foreach (string path in r)
                {
                    Image img = Image.FromFile(path);
                    lista_slika.Images.Add(img);
                }
            }

            br_mina = br;
            row = i;
            column = j;
            br_flagova = 0;

            #endregion


            #region iscrtavanje matrice

            int ButtonWidth = 40;
            int ButtonHeight = 40;
            //int Distance = 20; lepse izgleda bez ovoga
            int start_x = 0; //bilo je 10
            int start_y = 0; // bilo je 10

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {

                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight); //+ Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth); //+ Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    matrix[x, y] = tmpButton;
                    tmpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(Matrica_MouseDown);
                    tmpButton.Tag = new Polja(x, y);
                    tmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tmpButton.ImageList = lista_slika;
                    tmpButton.ForeColor = Color.Red;

                    // tmpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(Matrica_Click);
                    // nije radio desni klik
                    //tmpButton.AutoSize = true; ne valja jer se dugmici menjaju
                }
            }
            #endregion

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();


            #region inicijalizacija mina,brojanje koliko mina ima u okolini

            GenerateMines(i, j);

            NumbersOfMineInMatrix(row, column);



            #endregion


        }



        public ButtonMatrix(int i, int j)
        {
            matrix = new Button[i, j];
            lista_slika = new ImageList();
            administration_mod = true;


            if (Directory.Exists("MineSweeperr1"))
            {
                string[] r = Directory.GetFiles("MineSweeperr1");
                foreach (string path in r)
                {
                    Image img = Image.FromFile(path);
                    lista_slika.Images.Add(img);
                }
            }

            br_mina = 0;
            row = i;
            column = j;
            br_flagova = 0;


            #region iscrtavanje matrice

            int ButtonWidth = 40;
            int ButtonHeight = 40;
            //int Distance = 20; lepse izgleda bez ovoga
            int start_x = 0; //bilo je 10
            int start_y = 0; // bilo je 10

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {

                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight); //+ Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth); //+ Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    matrix[x, y] = tmpButton;
                    //tmpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(Matrica_MouseDown);
                    tmpButton.Tag = new Polja(x, y);
                    tmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tmpButton.ImageList = lista_slika;
                    tmpButton.ForeColor = Color.Red;
                    tmpButton.MouseClick += Matrica_Click;

                    //tmpButton.AutoSize = true; ne valja jer se dugmici menjaju
                }
            }
            #endregion

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();

        }


        public ButtonMatrix(int i, int j, bool b)
        {
            matrix = new Button[i, j];
            lista_slika = new ImageList();
            administration_mod = b;


            if (Directory.Exists("MineSweeperr1"))
            {
                string[] r = Directory.GetFiles("MineSweeperr1");
                foreach (string path in r)
                {
                    Image img = Image.FromFile(path);
                    lista_slika.Images.Add(img);
                }
            }

            br_mina = 0;
            row = i;
            column = j;
            br_flagova = 0;


            #region iscrtavanje matrice

            int ButtonWidth = 40;
            int ButtonHeight = 40;
            //int Distance = 20; lepse izgleda bez ovoga
            int start_x = 0; //bilo je 10
            int start_y = 0; // bilo je 10

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {

                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight); //+ Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth); //+ Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    matrix[x, y] = tmpButton;
                    if(administration_mod)
                    {
                        tmpButton.MouseClick += Matrica_Click;
                    }
                    else
                    {
                        tmpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(Matrica_MouseDown);
                    }
                    //tmpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(Matrica_MouseDown);
                    tmpButton.Tag = new Polja(x, y);
                    tmpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tmpButton.ImageList = lista_slika;
                    tmpButton.ForeColor = Color.Red;
                    

                    //tmpButton.AutoSize = true; ne valja jer se dugmici menjaju
                }
            }
            #endregion

            timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();

        }


        public Button[,] ReturnMatrix()
        {
            return matrix;
        }


        public Timer Timer
        {
            get
            {
                return timer;
            }

            set
            {
                timer = value;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Win())
            {
                PrintWin();
                MessageBox.Show("U are the winner!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                timer.Stop();
            }

        }


        private void GenerateMines(int x, int y)
        {
            Random r = new Random();
            int j, k;
            for(int i = 0; i < br_mina; i++)
            {
                j = r.Next(0,x);
                k = r.Next(0, y);
                Polja polje = (Polja)(matrix[j, k].Tag);
                if (polje.Vrsta == VrstaPolja.MINA)
                {
                    i--;
                }
                else
                {
                    ((Polja)(matrix[j, k].Tag)).Vrsta = VrstaPolja.MINA;
                    ((Polja)(matrix[j, k].Tag)).Mine = true;
                }
            }
        }

        #region number-of-mines
        public void NumbersOfMineInMatrix(int r, int z)
        {//UNESE SVIMA BROJ MINA U OKRUZENJU
            for (int x = 0; x < r; x++)
            {
                for (int y = 0; y < z; y++)
                {
                    int no = NumbersOfMineAroundButton(x, y);
                    ((Polja)(matrix[x, y].Tag)).Br_mina = no;

                }
            }
        }



        public int NumbersOfMineAroundButton(int x, int y)
        {  //BROJ MINA KO JEDNOG DUGMETA KOJE JE U MATRICI SA X I Y INDEKSOM
            int sum = 0;
            for (int i = (x - 1); i < (x + 2); i++)
                if (i >= 0 && i < row)
                    for (int j = (y - 1); j < (y + 2); j++)
                        if (j >= 0 && j < column)
                            if (((Polja)(matrix[i, j].Tag)).Vrsta == VrstaPolja.MINA && (i != x || j != y))
                                sum++;
            return sum;
        }


        #endregion

        public void PrintWin()
        {
            for (int l = 0; l < row; l++)
                for (int g = 0; g < column; g++)
                {
                    Polja p = (Polja)(matrix[l, g]).Tag;
                    if (p.Vrsta == VrstaPolja.ZASTAVICA)
                    {
                        if (p.Mine)
                            p.Vrsta = VrstaPolja.MINA;
                        else
                            p.Vrsta = VrstaPolja.ZATVORENO_POLJE;
                        (matrix[l, g]).ImageIndex = -1;
                    }
                    if (p.Vrsta == VrstaPolja.MINA)
                        matrix[l, g].ImageIndex = 1;
                    if (p.Br_mina != 0)
                        matrix[l, g].Text = p.Br_mina.ToString();
                    matrix[l, g].Enabled = false;
                }
        }

        public void Print()
        {
            //Da mi istampa sva polja
            for (int l = 0; l < row; l++)
                for (int g = 0; g < column; g++)
                {
                    Polja p = (Polja)(matrix[l, g]).Tag;
                    if (p.Vrsta == VrstaPolja.MINA)
                        matrix[l, g].ImageIndex = 1;
                    if(p.Br_mina != 0)
                        matrix[l, g].Text = p.Br_mina.ToString();
                }
        }

        #region action

        public void Matrica_MouseDown(object sender, MouseEventArgs e)
        {
            if (administration_mod == false)
            {
                Button b = sender as Button;
                if (b != null)
                {
                    Polja r = b.Tag as Polja;

                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if (r != null)
                        {
                            if (r == null)  // provera koju sam uveo jer sam imao nekih problema koje sada nemam
                                return;


                            if (r.Vrsta == VrstaPolja.MINA)
                            {
                                b.ImageIndex = 3;
                                GameOver(r, b);
                                MessageBox.Show("U step on mine!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (r.Vrsta == VrstaPolja.ZASTAVICA)
                            {
                                return;
                            }
                            else if (r.Vrsta == VrstaPolja.ZATVORENO_POLJE)
                            {
                                if (r.Br_mina == 0)
                                {
                                    b.Enabled = false;
                                    r.Vrsta = VrstaPolja.OTVORENO_POLJE;
                                    Open(r, b);  //rekurzija
                                }
                                else
                                {
                                    b.Text = r.Br_mina.ToString();
                                    b.Enabled = false;
                                }
                            }
                        }
                    }
                    else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        PutFlag(r, b);
                    }
                }
            }
        }

        public void Matrica_Click(object sender, MouseEventArgs e)
        {
            if (administration_mod)
            {
                Button b = sender as Button;
                if (b != null)
                {
                    Polja p = (Polja)b.Tag;
                    if (p.Vrsta != VrstaPolja.OTVORENO_POLJE)
                    {
                        if (p.Vrsta != VrstaPolja.MINA)
                        {
                            b.ImageIndex = 1;
                            p.Vrsta = VrstaPolja.MINA;
                            br_mina++;
                        }
                    }
                }
            }
        }



        private void PutFlag(Polja p, Button b)
        {
            if ((p.Vrsta == VrstaPolja.ZATVORENO_POLJE ||p.Vrsta == VrstaPolja.MINA) && br_flagova < br_mina)
            {
                if (p.Vrsta != VrstaPolja.ZASTAVICA)
                {
                    b.ImageIndex = 0;
                    p.Vrsta = VrstaPolja.ZASTAVICA;
                    br_flagova++;
                }
            }
            else if(p.Vrsta == VrstaPolja.ZASTAVICA)
            {
                if (p.Mine)
                    p.Vrsta = VrstaPolja.MINA;
                else
                    p.Vrsta = VrstaPolja.ZATVORENO_POLJE;
                b.ImageIndex = -1;
                br_flagova--;
            }
        }

        private void Open(Polja r, Button b)
        {  //rekurzija


            b.Enabled = false;
            if ( r.Vrsta == VrstaPolja.MINA)
            {
                b.Enabled = true;
                return;
            }
            if (r.Br_mina > 0)
            {
                r.Vrsta = VrstaPolja.OTVORENO_POLJE;
                b.Text = r.Br_mina.ToString();
                ((Polja)(b.Tag)).Vrsta = VrstaPolja.ZATVORENO_POLJE;
                b.Enabled = false;
                return;
            }
            else
            {
                for (int i = (r.Row - 1); i < (r.Row + 2); i++)
                    if (i >= 0 && i < row)
                        for (int j = (r.Column - 1); j < (r.Column + 2); j++)
                            if (j >= 0 && j < column)
                            {
                                    if(matrix[i,j].Enabled && (
                                    r.Row != i || r.Column!=j ))
                                    {
                                    r.Vrsta = VrstaPolja.OTVORENO_POLJE;
                                    Polja pom = ((Polja)(matrix[i, j].Tag));
                                    Button b1 = matrix[i, j];
                                    Open(pom, b1);
                                    }
                            }
            }
        }


        private void GameOver(Polja n, Button b)
        {
            timer.Stop();
            //Da mi istampa sva polja i onemoguci igraca da igra
            for (int l = 0; l < row; l++)
                for (int g = 0; g < column; g++)
                {
                    if (l != n.Row && g != n.Column)
                    {
                        Polja p = (Polja)(matrix[l, g]).Tag;
                        if (p.Vrsta == VrstaPolja.ZASTAVICA)
                        {
                            if (p.Mine)
                                p.Vrsta = VrstaPolja.MINA;
                            else
                                p.Vrsta = VrstaPolja.ZATVORENO_POLJE;
                            (matrix[l, g]).ImageIndex = -1;
                        }
                        if (p.Vrsta == VrstaPolja.MINA)
                            matrix[l, g].ImageIndex = 1;
                        if (p.Br_mina != 0)
                            matrix[l, g].Text = p.Br_mina.ToString();
                    }
                    (matrix[l, g]).Enabled = false;
                }
        }

        private bool Win()
        {
            if (!administration_mod)
            {
                bool res = true;
                for (int i = 0; i < row; i++)
                    for (int j = 0; j < column; j++)
                        if ((((Polja)(matrix[i, j].Tag)).Mine == false &&
                            ((Polja)(matrix[i, j].Tag)).Vrsta == VrstaPolja.ZASTAVICA) ||
                            (((Polja)(matrix[i, j].Tag)).Mine == true &&
                            ((Polja)(matrix[i, j].Tag)).Vrsta != VrstaPolja.ZASTAVICA))
                            res = false;
                return res;
            }
            return false;
        }

        #endregion

        public void Save(StreamWriter stream)
        {
            int br = 0;
            stream.WriteLine(br_mina);
            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                {
                    Polja p = ((Polja)((matrix[i, j]).Tag));
                    if (p.Vrsta == VrstaPolja.MINA)
                    {
                        stream.WriteLine(p.Row);
                        stream.WriteLine(p.Column);
                        br++;
                    }
                    if (br == br_mina)
                        return;
                }
        }



        public void Load(StreamReader stream)
        {
            int index1, index2;
            br_mina = Int32.Parse(stream.ReadLine());
            for (int i = 0; i < br_mina; i++)
                {
                    index1 = Int32.Parse(stream.ReadLine());
                    index2 = Int32.Parse(stream.ReadLine());
                    ((Polja)(matrix[index1, index2].Tag)).Mine = true;
                    ((Polja)(matrix[index1, index2].Tag)).Vrsta = VrstaPolja.MINA;
                }

        }

        public bool Administration_mod()
        {
            return administration_mod;
        }

        //private void Print(int i, int j)
        //{
        //    for (int l = 0; l < row; l++)
        //        for (int g = 0; g < column; g++)
        //        {
        //            if (l != i && g != j)
        //            {
        //                Polja p = (Polja)(matrix[l, g]).Tag;
        //                if (p.Vrsta == VrstaPolja.MINA)
        //                    matrix[l, g].ImageIndex = 1;
        //                if (p.Br_mina != 0)
        //                    matrix[l, g].Text = p.Br_mina.ToString();
        //            }
        //        }
        //}


    }
}
