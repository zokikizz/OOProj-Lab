using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija
    {
        #region atributs
        private string _ktg;
        private DateTime _od;
        private DateTime _do;
        #endregion


        #region const

        public Kategorija(string r, DateTime od, DateTime do1)
        {
            _ktg = r;
            _do = do1;
            _od = od;
        }

        public Kategorija()
        {
            _ktg = String.Empty;
        }
        #endregion

        #region property/methods
        public string Ktg
        {
            get
            {
                return _ktg;
            }

            set
            {
                _ktg = value;
            }
        }

        public DateTime Od
        {
            get
            {
                return _od;
            }

            set
            {
                _od = value;
            }
        }

        public DateTime Do
        {
            get
            {
                return _do;
            }

            set
            {
                _do = value;
            }
        }

        public override string ToString()
        {
            return Ktg;
        }
        #endregion
    }
}
