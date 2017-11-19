using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Podaci
{
    public class Vozac_O
    {
        #region atribus
        private string _ime;
        private string _prezime;
        private DateTime _datrodj;
        private DateTime _vaziod;
        private DateTime _vazido;
        private string _brvozacke;
        private char _pol;
        private List<Kategorija> _listaKategorija;
        private List<Kategorija> _listaZabrana;
        #endregion

        #region constuctors

        public Vozac_O()
        {
            Ime = String.Empty;
        }

        public Vozac_O(string i, string p, string br, char pl, DateTime dr,
    DateTime vod, DateTime vdo)
        {
            Ime = i;
            Prezime = p;
            Brvozacke = br;
            Pol = pl;
            Datrodj = dr;
            Vazido = vdo;
            Vaziod = vod;
            ListaKategorija = null;
            ListaZabrana = null;
        }

        #endregion


        #region property


        public string Ime
        {
            get
            {
                return _ime;
            }

            set
            {
                _ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return _prezime;
            }

            set
            {
                _prezime = value;
            }
        }

        public DateTime Datrodj
        {
            get
            {
                return _datrodj;
            }

            set
            {
                _datrodj = value;
            }
        }

        public DateTime Vaziod
        {
            get
            {
                return _vaziod;
            }

            set
            {
                _vaziod = value;
            }
        }

        public DateTime Vazido
        {
            get
            {
                return _vazido;
            }

            set
            {
                _vazido = value;
            }
        }

        public string Brvozacke
        {
            get
            {
                return _brvozacke;
            }

            set
            {
                _brvozacke = value;
            }
        }

        public char Pol
        {
            get
            {
                return _pol;
            }

            set
            {
                _pol = value;
            }
        }

        public string PRINT
        {
            get { return Ime + " " + Prezime + " " + Brvozacke; }
        }

        public List<Kategorija> ListaKategorija
        {
            get
            {
                return _listaKategorija;
            }

            set
            {
                _listaKategorija = value;
            }
        }

        public List<Kategorija> ListaZabrana
        {
            get
            {
                return _listaZabrana;
            }

            set
            {
                _listaZabrana = value;
            }
        }

        #endregion

        #region methods



        #endregion
    }
}
