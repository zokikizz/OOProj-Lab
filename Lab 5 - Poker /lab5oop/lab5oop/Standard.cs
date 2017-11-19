using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5oop
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
            _dek = new Stack<karta>(sufel(temp).ToList());
        }
        private ICollection<karta>  sufel(List<karta> g)
        {
            List<karta> temp = g;
            Random r = new Random(Environment.TickCount);
            for (int i=0;i<temp.Count*temp.Count;i++)
            {
                int x2 = r.Next(0,temp.Count-1);
                karta tmp = temp[i % temp.Count];
                temp[i % temp.Count] = temp[x2];
                temp[x2] = tmp;
            }
            return temp;
        }
        public karta draw()
        {
            return _dek.Pop();
        }

        public void returnK(karta[] K)
        {
            List<karta> temp = _dek.ToList();
            temp.AddRange(K);
            _dek = new Stack<karta>(sufel(temp));
        }
    }
}
