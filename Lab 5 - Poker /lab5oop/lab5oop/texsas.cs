using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace lab5oop
{
    class texsas:Controler
    {
        private Model _model;

        private List<karta> _list;

        private int _ulog;
        private int _stanje;
        public Model modl
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
        private int swaps = 0;
        public List<karta> List
        {
            get
            {
                return _list;
            }

            set
            {
                _list = value;
            }
        }

        public int Ulog
        {
            get
            {
                return _ulog;
            }

            set
            {
                _ulog = value;
            }
        }

        public int Stanje
        {
            get
            {
                return _stanje;
            }

            set
            {
                _stanje = value;
            }
        }
        private int _dodatnimul;
        public Form1 View
        {
            get
            {
                return _view;
            }

            set
            {
                _view = value;
            }
        }

        public int Dodatnimul
        {
            get
            {
                return _dodatnimul;
            }

            set
            {
                _dodatnimul = value;
            }
        }

        private Form1 _view;
        public texsas(Form1 v)
        {
            View = v;
            v.addControler(this);
        }

        public void Fold()
        {
            throw new NotImplementedException();
        }

        public string open()
        {
            rezultat mul = check();
            mul.Multiplicator = mul.Multiplicator * _ulog*Dodatnimul;
            _ulog = 0;
            Stanje += mul.Multiplicator;
            return mul.Text;
        }

        public void restart(PictureBox[] slike)
        {
            _model.create();
            _list = new List<karta>();
            for (int i = 0,j=-1 ; i < 7; i++)
            {
                if(i<3)
                {
                    karta blank = new karta();
                    blank.Broj = -1;
                    blank.Slika = new Bitmap(Application.StartupPath + "/cards/back.jpg");
                    _list.Add(blank);
                }
                else
                {
                    _list.Add(_model.draw());
                    j++;
                }
                Bitmap x = new Bitmap(_list[i].Slika, slike[i].Width, slike[i].Height);
                slike[i].Image = x;
                slike[i].Tag = _list[i];
            }
            Dodatnimul = 5;
            swaps = 0;
        }

        public void swap(ref List<PictureBox> krt)
        {
            if (krt.Count ==1)
            {
                if(((karta)krt[0].Tag).Broj==-1)
                {
                    int i = find((karta)krt[0].Tag);
                    //_list.Add(_model.draw());
                    karta nov = _model.draw();
                    Bitmap x = new Bitmap(_list[i].Slika, krt[0].Width, krt[0].Height);
                    krt[0].Image.Dispose();
                    krt[0].Image = new Bitmap(_list[i].Slika, krt[0].Width, krt[0].Height);
                    _list[i] = nov;
                    krt[0].Tag = _list[i];
                    krt[0].Update();
                    switch(swaps)
                    {
                        case 0:
                            Dodatnimul = 2;
                            break;
                        case 1:
                            int g=Stanje - _ulog;
                            _ulog += g;
                            Stanje -= g;    
                            break;
                        case 2:
                            int s = _ulog * 2;
                            Stanje -= s;
                            _ulog += s;
                            break;
                    }
                    swaps++;
                }
            }

        }
        private int find(karta x)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i] == x)
                    return i;
            }
            return -1;
        }
        public bool UlogP(int u)
        {
            if (Stanje >= u)
            {
                Stanje -= u;
                _ulog += u;
                return true;
            }
            else
                return false;
        }

        public void wait()
        {
            throw new NotImplementedException();
        }

        public void create(int ulog, bool model, PictureBox[] slike)
        {
            if (model)
            {
                _model = new Standard();
            }
            else
                _model = new francuz();
            _model.create();
            _stanje = ulog;
            _list = new List<karta>();
            for (int i = 0; i < 7; i++)
            {
                if (i < 3)
                {
                    karta blank = new karta();
                    blank.Broj = -1;
                    blank.Slika = new Bitmap(Application.StartupPath + "/cards/back.jpg");
                    _list.Add(blank);
                }
                else
                    _list.Add(_model.draw());
                Bitmap x = new Bitmap(_list[i].Slika, slike[i].Width, slike[i].Height);
                slike[i].Image = x;
                slike[i].Tag = _list[i];
            }
            _ulog = 0;

        }

        private rezultat check()
        {
            List<karta> list = new List<karta>();
            for (int z = 0; z < 7; z++)
                if (_list[z].Broj != -1)
                    list.Add(List[z]);
            int i = list[0].Broj + 1;
            int j = 1;
            while (i == list[j].Broj)
            {
                j++;
                i++;
            }
            if (j == 5)
            {
                if (list[0].Broj == 7)
                {
                    int x = 1;
                    while (x < 5)
                    {
                        if (list[x].Znak != list[0].Znak)
                            break;
                        x++;
                    }
                    if (x == 5)
                        return new rezultat(100, "strait flush");//strait flush
                }
                else
                {
                    int x = 1;
                    while (x < list.Count)
                    {
                        if (list[x].Znak != list[0].Znak)
                            break;
                        x++;
                    }
                    if (x == 5)
                        return new rezultat(40, "big bob tail");//big bob tail
                }
                return new rezultat(12, "strait");//straith

            }
            else
            {
                List<int> par = new List<int>();
                int y = 0;
                for (int x = 0; x < list.Count; x++)
                {
                    par.Add(ponavljanje(list[x].Broj,list));
                    if (list[0].Znak != list[x].Znak)
                        y = 1;
                }
                if (y == 0)
                {
                    return new rezultat(16, "flush");//flush
                }
                bool blaze = true;
                for (int x = 0; x < list.Count; x++)
                {
                    if (!(list[x].Broj > 10))
                    {
                        blaze = false;
                        break;
                    }
                }
                if (blaze)
                    return new rezultat(9, "blaze");
                int max = par.Max();
                if (max == 4)
                    return new rezultat(60, "four of kind");//four of kind
                if (max == 3 && par.Min() == 2)
                {
                    return new rezultat(24, "full house");//full house
                }
                if (max == 3)
                    return new rezultat(6, "three pair");//three pair
                if (max == 2)
                {
                    int h = 0;
                    for (int x = 0; x < par.Count; x++)
                        if (par[x] == 2)
                            h++;
                    if (h == 4)
                        return new rezultat(4, "two pairs");//two pairs
                    else
                        return new rezultat(2, "one pair");//one pair
                }
                return new rezultat(0, "you lose");
            }
        }
        private int ponavljanje(int br,List<karta> list)
        {
            int j = 0;
            for (int i = 0; i < list.Count; i++)
                if (list[i].Broj == br)
                    j++;
            return j;
        }
    }
}
