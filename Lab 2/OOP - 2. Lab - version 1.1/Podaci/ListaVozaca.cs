using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {
        #region atributs
        private List<Vozac_O> _lista;
        #endregion

        #region constr
        private ListaVozaca()
        {
            _lista = new List<Vozac_O>();
        }
        #endregion

        #region property/methods

        public List<Vozac_O> ReturnList
        {
            get
            {
                return _lista;
            }
        }


        public void SortIme()
        {
            for (int i = 0; i < _lista.Count; i++)
                for (int j = 0; j < _lista.Count - 1; j++)
                    if (String.Compare(_lista[j].Ime, _lista[j + 1].Ime) > 0)
                    {
                        Vozac_O temp = _lista[j];
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
                        Vozac_O temp = _lista[j];
                        _lista[j] = _lista[j + 1];
                        _lista[j + 1] = temp;
                    }

        }


        public void SortBrVoz()
        {

            for (int i = 0; i < _lista.Count; i++)
                for (int j = 0; j < _lista.Count - 1; j++)
                    if (String.Compare(_lista[j].Brvozacke, _lista[j + 1].Brvozacke) > 0)
                    {
                        Vozac_O temp = _lista[j];
                        _lista[j] = _lista[j + 1];
                        _lista[j + 1] = temp;
                    }

        }

        #endregion

        private static ListaVozaca _instance = null;

        public static ListaVozaca Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ListaVozaca();
                return _instance;
            }

        }
    }
}
