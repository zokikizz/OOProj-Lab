using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab5oop
{
    class Clasic : Controler
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
        private int swaps=3;
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

        private Form1 _view;
        public Clasic(Form1 v)
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
           rezultat mul= check();
            mul.Multiplicator = mul.Multiplicator * _ulog;
            _ulog = 0;
            Stanje += mul.Multiplicator;
            return mul.Text;
        }

        public void restart(PictureBox[] slike)
        {
            _model.create();
            _list = new List<karta>();
            for (int i = 0; i < 5; i++)
            {
                _list.Add(_model.draw());
                Bitmap x = new Bitmap(_list[i].Slika, slike[i].Width, slike[i].Height);
                slike[i].Image = x;
                slike[i].Tag = _list[i];
            }
            swaps = 3;
        }

        public void swap(ref List<PictureBox> krt)
        {
           if(krt.Count<=swaps)
            {
                for(int i=0;i<swaps && i<krt.Count;i++)
                {

                    var x = _model.draw();
                    _list[find((karta)krt[i].Tag)] = x;
                    krt[i].Image = new Bitmap(x.Slika, krt[i].Width, krt[i].Height);
                    krt[i].Tag = x;
                    krt[i].BorderStyle = BorderStyle.None;
                }
                swaps =swaps - krt.Count ;
            }

        }
        private int find(karta x)
        {
            for(int i=0;i<_list.Count;i++)
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

        public void create(int ulog,bool model,PictureBox[] slike)
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
            for (int i = 0; i < 5; i++)
            {
                _list.Add(_model.draw());
                Bitmap x = new Bitmap(_list[i].Slika, slike[i].Width, slike[i].Height);
                slike[i].Image = x;
                slike[i].Tag = _list[i];
            }
            _ulog = 0;
            
        }

        private rezultat check()
        {
            int i = _list[0].Broj+1;
            int j = 1;
            while(i==_list[j].Broj)
            {
                j++;
                i++;
            }
            if(j==5)
            {
                if(_list[0].Broj==7)
                {
                    int x = 1;
                    while(x<5)
                    {
                        if (_list[x].Znak != _list[0].Znak)
                            break;
                        x++;
                    }
                    if (x == 5)
                        return new rezultat(100,"strait flush");//strait flush
                }
                else
                {
                    int x = 1;
                    while (x < 5)
                    {
                        if (_list[x].Znak != _list[0].Znak)
                            break;
                        x++;
                    }
                    if (x == 5)
                        return new rezultat(40,"big bob tail");//big bob tail
                }
                return new rezultat(12,"strait");//straith
                    
            }
            else
            {
                List<int> par = new List<int>();
                int y = 0;
                for(int x=0;x<5;x++)
                {
                    par.Add(ponavljanje(_list[x].Broj));
                    if (_list[0].Znak != _list[x].Znak)
                        y = 1;
                }
                if(y==0)
                {
                    return new rezultat(16,"flush");//flush
                }
                bool blaze = true;
                for (int x = 0; x < 5; x++)
                {
                    if(!(_list[x].Broj>10))
                    {
                        blaze = false;
                        break;
                    }
                }
                if (blaze)
                    return new rezultat(9,"blaze");
                int max = par.Max();
                if (max == 4)
                    return new rezultat(60,"four of kind");//four of kind
                if(max==3 && par.Min()==2)
                {
                    return new rezultat(24,"full house");//full house
                }
                if (max == 3)
                    return new rezultat(6,"three pair");//three pair
                if(max==2)
                {
                    int h = 0;
                    for (int x = 0; x < par.Count;x++)
                        if (par[x] == 2)
                            h++;
                    if (h == 4)
                        return new rezultat(4,"two pairs");//two pairs
                    else
                        return new rezultat(2,"one pair");//one pair
                }
                return new rezultat(0,"you lose");
            }
        }
        private int ponavljanje(int br)
        {
            int j = 0;
            for (int i = 0; i < _list.Count; i++)
                if (_list[i].Broj == br)
                    j++;
            return j;
        }
    }
}
