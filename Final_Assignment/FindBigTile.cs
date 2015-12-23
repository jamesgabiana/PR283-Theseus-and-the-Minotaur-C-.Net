using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class FindBigTile
    {
        public Int32 BTColsCount;
        public Int32 BTRowsCount;
        public Single iniPosX;
        public Single iniPosY;
        public Single sTileWidth;
        public Int32 currentRow = 0;
        public Int32 currentCol = 0;

        public List<List<BigTilePosition>> BTilePos = new List<List<BigTilePosition>>();

        public FindBigTile(Int32 newNumberOfCols, Int32 newNumberOfRows,
                           Single newSTileWidth, Single newIniPosX, Single newIniPosY)
        {
            BTColsCount = (newNumberOfCols - 1) / 4;
            BTRowsCount = (newNumberOfRows - 1) / 2;
            sTileWidth = newSTileWidth;
            iniPosX = newIniPosX;
            iniPosY = newIniPosY;
            Initialize();
        }

        public void Initialize()
        {
            BigTilePosition bTile;
            List<BigTilePosition> temp;
            Single currentIniPosX = iniPosX;
            Single currentIniPosY = iniPosY;
            Single BEndPosX = iniPosX + sTileWidth * 4;
            Single BEndPosY = iniPosY + sTileWidth * 4;
            Int32 currentSRow = 0;
            Int32 currentSCol = 0;

            for (int i = 0; i < BTRowsCount; i++)
            {
                temp = new List<BigTilePosition>();
                for (int j = 0; j < BTColsCount; j++)
                {

                    bTile = new BigTilePosition(currentIniPosX, BEndPosX, currentIniPosY,
                                                BEndPosY, currentSRow, currentSCol, sTileWidth);
                    temp.Add(bTile);
                    currentIniPosX += sTileWidth * 4;
                    BEndPosX += sTileWidth * 4;
                    currentSCol += 4;
                }
                currentIniPosX = iniPosX;
                BTilePos.Add(temp);
                currentSCol = 0;
                currentSRow += 2;
                BEndPosX = iniPosX + sTileWidth * 4;
                currentIniPosY += sTileWidth * 4;
                BEndPosY += sTileWidth * 4;

            }
        }
    }
}
