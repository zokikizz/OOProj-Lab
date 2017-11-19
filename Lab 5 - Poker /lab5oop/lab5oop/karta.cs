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
    public enum znak
    {
        srce,
        list,
        kocka,
        detelina
    }
    public class karta
    {
        private int _broj;
        private znak _znak;
        private bool _isSelected=false;
        private bool _isOpen = false;
        private Bitmap _slika;

        public int Broj
        {
            get
            {
                return _broj;
            }

            set
            {
                _broj = value;
            }
        }

        public znak Znak
        {
            get
            {
                return _znak;
            }

            set
            {
                _znak = value;
            }
        }

        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                _isSelected = value;
            }
        }

        public Bitmap Slika
        {
            get
            {
                return _slika;
            }

            set
            {
                _slika = value;
            }
        }

        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }

            set
            {
                _isOpen = value;
            }
        }
        public karta()
        {

        }
        public karta(int br,string znk)
        {
            string temp = br.ToString() + znk;
            _broj = br;
            if (znk == "D")
                _znak = znak.detelina;
            else if (znk == "K")
                _znak = znak.kocka;
            else if (znk == "L")
                _znak = znak.list;
            else
                _znak = znak.srce;
            _slika = (Bitmap)Image.FromFile(Application.StartupPath+"/cards/" + temp+".png");
        }
        public static int compare(karta a,karta b)
        {
            if (a.Broj < b.Broj)
                return -1;
            else if (a.Broj == b.Broj)
                return 0;
            else
                return 1;
        }
    }
}
