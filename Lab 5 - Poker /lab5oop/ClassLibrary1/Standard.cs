using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Standard : Model
    {
        private Stack<karta> _dek;
        public void create()
        {
            List<karta> temp = new List<karta>();
            for(int i=1;i<14;i++)
            {
                for(int j=0;j<4;j++)
                {
                    switch (j)
                    {
                        case 0:
                            temp.Add(new karta(i, "L"));
                            break;
                        case 1:
                            temp.Add(new karta(i, "S"));
                            break;
                        case 2:
                            temp.Add(new karta(i, "D"));
                            break;
                        case 3:
                            temp.Add(new karta(i, "K"));
                            break;
                    }

                }
            }
            _dek = (Stack<karta>)temp.OrderBy(a => Guid.NewGuid());
        }

        public karta draw()
        {
            return _dek.Pop();
        }

        public void returnK(karta[] K)
        {
            List<karta> temp = _dek.ToList();
            temp.AddRange(K);
            _dek = (Stack<karta>)temp.OrderBy(a => Guid.NewGuid());
        }
    }
}
