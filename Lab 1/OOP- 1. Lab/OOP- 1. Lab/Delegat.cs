using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Osobe1;

namespace OOP__1.Lab
{
    //definisan delegat za sort
    public delegate void Sort();

     public class Delegat
    {
        private string naziv_f;
        private Sort sortiraj;

        public Delegat(string S, Sort d)
        {
            Naziv_f = S;
            Sortiraj = d;
        }

        public string Naziv_f
        {
            get
            {
                return naziv_f;
            }

            set
            {
                naziv_f = value;
            }
        }

        public Sort Sortiraj
        {
            get
            {
                return sortiraj;
            }
            set
            {
                sortiraj = value;
            }
        }

        public string toString()
        {
            return naziv_f;
        }

        public override string ToString()
        {
            return this.naziv_f;
        }
    }
}
