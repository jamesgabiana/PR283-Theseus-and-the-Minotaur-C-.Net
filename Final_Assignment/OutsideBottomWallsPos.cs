using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class OutsideBottomWallsPos : OutsideWallPos
    {
        public List<TileIndex> newWalls = new List<TileIndex>();

        public OutsideBottomWallsPos(Single newIniPosX, Single newEndPosX, Single newIniPosY, 
                                    Single newEndOfPosY,Int32 newRow, Int32 newCol)
        {
            iniPosX = newIniPosX;
            endPosX = newEndPosX;
            iniPosY = newIniPosY;
            endPosY = newEndOfPosY;
            row = newRow;
            col = newCol;
            Initialize();

        }

        public void Initialize()
        {
            TileIndex index;
            for (int i = 0; i < 4; i++)
            {
                index = new TileIndex(row, col + i);
                newWalls.Add(index);
            }
            base.walls = newWalls;
        }
    }
}
