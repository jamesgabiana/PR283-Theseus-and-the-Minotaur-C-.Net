using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    interface IBigTile
    {
        List<List<ITile>> smallTiles { get; }
    }
}
