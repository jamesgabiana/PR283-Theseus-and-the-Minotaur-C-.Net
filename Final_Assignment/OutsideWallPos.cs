using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    abstract class OutsideWallPos
    {
        public Single iniPosX;
        public Single iniPosY;
        public Single endPosX;
        public Single endPosY;
        public Int32 row;
        public Int32 col;
        public List<TileIndex> walls;
    }
}
