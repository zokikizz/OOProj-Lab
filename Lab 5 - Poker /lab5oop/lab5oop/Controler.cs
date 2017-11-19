using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab5oop
{
   public  interface Controler
    {
        int Stanje { get; set; }
        int Ulog { get; set; }
        Model modl { get; set; }
         void swap(ref List<PictureBox> krt);
        bool UlogP(int u);
        void Fold();
        void wait();
        void restart(PictureBox[] d);
        string open();
        void create(int ulog,bool model,PictureBox[] slike);

    }
}
