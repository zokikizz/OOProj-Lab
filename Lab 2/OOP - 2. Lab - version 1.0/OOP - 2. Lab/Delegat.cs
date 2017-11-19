using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___2.Lab
{
    public class Delegat
    {
        public delegate void Sort();
        private Sort sort;
        string naziv;

        public Sort Sort1
        {
            get
            {
                return sort;
            }

            set
            {
                sort = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public Delegat(string n, Sort d)
        {
            Sort1 = d;
            Naziv = n;
        }

        public override string ToString()
        {
            return naziv;
        }
    }
}
