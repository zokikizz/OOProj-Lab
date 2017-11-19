using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osobe
{
    public class ListaOsoba
    {  //18. kreirana lista osoba koja je jedinstvena za ceo projekat preko Singleton obrasca

        #region atributs

        private List<Osoba> _lista;

        #endregion

        #region constructors

        private ListaOsoba()
        {
            _lista = new List<Osoba>();
        }

        #endregion

        #region methods

        public bool Postoji(Osoba o)
        {
            foreach (var r in _lista)
                if (o == r)
                    return true;
            return false;
        }


        public bool Dodaj(Osoba o)
        {
            if (Postoji(o))
                return false;
            Lista.Insert(0,o);
            return true;
        }


        public bool Obrisi(Osoba o)
        {
            foreach (var r in _lista)
                if (o == r)
                {
                    Lista.Remove(r);
                    return true;
                }
            return false;
        }

        public void ObrisiSve()
        {
            while (_lista.Count > 0)
                _lista.RemoveAt(0);
        }


        public void SortIme()
        {
            for(int i = 0; i < _lista.Count; i++)
                for(int j = 0; j < _lista.Count - 1; j++)
                    if(String.Compare(_lista[j].Ime, _lista[j+1].Ime) > 0)
                    {
                        Osoba temp = _lista[j];
                        _lista[j] = _lista[j + 1];
                        _lista[j + 1] = temp;
                    }

        }


        public void SortPrezime()
        {

            for (int i = 0; i < _lista.Count; i++)
                for (int j = 0; j < _lista.Count - 1; j++)
                    if (String.Compare(_lista[j].Prezime, _lista[j + 1].Prezime) > 0)
                    {
                        Osoba temp = _lista[j];
                        _lista[j] = _lista[j + 1];
                        _lista[j + 1] = temp;
                    }

        }

        public void SortDatRodj()
        {
            for (int i = 0; i < _lista.Count; i++)
                for (int j = 0; j < _lista.Count - 1; j++)
                    if (String.Compare(_lista[j].Datrodj.ToString("yyyy.MM.dd"),
                        _lista[j + 1].Datrodj.ToString("yyyy.MM.dd")) > 0)
                    {
                        Osoba temp = _lista[j];
                        _lista[j] = _lista[j + 1];
                        _lista[j + 1] = temp;
                    }
        }

        public Osoba Nadji(Osoba o)
        {
            foreach (var o1 in _lista)
                if (o1 == o)
                    return o1;
            return null;
        }

        #endregion

        private static ListaOsoba _instance = null;

        public static ListaOsoba Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaOsoba();

                return _instance;
            }

        }

        #region properti


        public List<Osoba> Lista
        {
            get
            {
                return _lista;
            }
        }
        #endregion
    }
}
