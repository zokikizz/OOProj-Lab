using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MSObjects
{

    public enum VrstaPolja
    {
        MINA,
        ZASTAVICA,
        OTVORENO_POLJE,
        ZATVORENO_POLJE
    }
    public class Polja
    {
        #region atributs
        bool mine;
        private VrstaPolja vrsta;
        private int br_mina;
        private int row;
        private int column;
        #endregion


        #region const
        public Polja()
        {
            vrsta = VrstaPolja.ZATVORENO_POLJE;
            br_mina = 0;
        }

        public Polja(int r, int c)
        {
            vrsta = VrstaPolja.ZATVORENO_POLJE;
            br_mina = 0;
            row = r;
            column = c;
        }
        #endregion



        #region property / methods


        public int Br_mina
        {
            get
            {
                return br_mina;
            }

            set
            {
                br_mina = value;
            }
        }

        public VrstaPolja Vrsta
        {
            get
            {
                return vrsta;
            }

            set
            {
                vrsta = value;
            }
        }

        public int Row
        {
            get
            {
                return row;
            }

            set
            {
                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }

            set
            {
                column = value;
            }
        }

        public bool Mine
        {
            get
            {
                return mine;
            }

            set
            {
                mine = value;
            }
        }

        /*public static VrstaPolja Raspakuj(object R)
        {
            
        }*/
        #endregion
    }
}
