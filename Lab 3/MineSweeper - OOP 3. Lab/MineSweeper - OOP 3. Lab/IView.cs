﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
     public interface IView
    {
        DialogResult Quit();
        void NewGame();
        //void CostumGame();
    }
}
