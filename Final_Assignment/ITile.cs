using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    public interface ITile
    {
        Single PosX { set; get; }
        Single PosY { set; get; }
        Single Width { get; }
        Single Height { get; }
    }
}
