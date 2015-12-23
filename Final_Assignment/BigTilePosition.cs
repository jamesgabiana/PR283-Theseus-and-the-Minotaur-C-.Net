using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class BigTilePosition
    {
        public Single iniPosX;
        public Single iniPosY;
        public Single endPosX;
        public Single endPosY;
        public Single width;
        public Int32 row;
        public Int32 col;
        public List<List<TileIndex>> sTileIndexes = new List<List<TileIndex>>();

        public BigTilePosition(Single newIniPosX, Single newEndPosX, Single newIniPosY, Single newEndOfPosY,
                               Int32 newRow, Int32 newCol, Single newWidth)
        {
            iniPosX = newIniPosX;
            endPosX = newEndPosX;
            iniPosY = newIniPosY;
            endPosY = newEndOfPosY;
            row = newRow;
            col = newCol;
            width = newWidth;
            Initialize();

        }

        public void Initialize()
        {
            List<TileIndex> temp;
            TileIndex index;
            for (int i = 0; i < 2; i++)
            {
                temp = new List<TileIndex>();
                for (int j = 0; j < 4; j++)
                {
                    index = new TileIndex(row + i, col + j);
                    temp.Add(index);
                }
                sTileIndexes.Add(temp);
            }
        }
    }
}
