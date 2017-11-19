using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Osobe
{
    public class Osoba
    {

        #region atributs

        private string _ime;
        private string _prezime;
        private string _broj;
        private DateTime _datrodj;
        private string _stanuje;


        #endregion


        #region constructors

        public Osoba()
        {
            _ime = string.Empty;
            _prezime = string.Empty;
            _broj = string.Empty;
            _datrodj = DateTime.Now;
            _stanuje = string.Empty;
        }

        public Osoba(string ime, string prezime, string broj,
            DateTime dat, string stan)
        {
            _ime = ime;
            _prezime = prezime;
            _broj = broj;
            _datrodj = dat;
            _stanuje = stan;
        }
        #endregion

        #region properti
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

        public string Broj
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

        public string Stanuje
        {
            get
            {
                return _stanuje;
            }

            set
            {
                _stanuje = value;
            }
        }

        public string PRINT
        {
            get
            {
                return "Ime: " + Ime + " Prezime: " + Prezime + " Broj: " + Broj
                    + " Datum: " + Datrodj.ToString("dd.MM.yyyy");
            }
        }

        #endregion

        #region methods


        public static bool operator==(Osoba o, Osoba o1)
        {
                if (o.Ime.Equals(o1.Ime) && o.Prezime.Equals(o1.Prezime) &&
                    o.Stanuje.Equals(o1.Stanuje) && o.Datrodj.Equals(o1.Datrodj))
                    return true;
                return false;
        }

        public static bool operator!=(Osoba o, Osoba o1)
        {
                if (!(o.Ime.Equals(o1.Ime) && o.Prezime.Equals(o1.Prezime) &&
                        o.Stanuje.Equals(o1.Stanuje) && o.Datrodj.Equals(o1.Datrodj)))
                    return true;
                return false;


        }

        #endregion
    }
}
