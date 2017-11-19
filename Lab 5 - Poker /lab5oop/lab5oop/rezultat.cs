using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5oop
{
    class rezultat
    {
        private int _multiplicator;
        private string _text;

        public int Multiplicator
        {
            get
            {
                return _multiplicator;
            }

            set
            {
                _multiplicator = value;
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
            }
        }
        public rezultat(int mul,string text)
        {
            _multiplicator = mul;
            _text = text;
        }
    }
}
