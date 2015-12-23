using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class FindOutsideWalls
    {
        public Int32 colsCount;
        public Int32 rowsCount;
        public Single iniPosX;
        public Single iniPosY;
        public Single sTileWidth;
        public Int32 currentRow = 0;
        public Int32 currentCol = 0;

        public List<OutsideRightWallsPos> outsideRightWalls = new List<OutsideRightWallsPos>();
        public List<OutsideBottomWallsPos> outsideBottomWalls = new List<OutsideBottomWallsPos>();

        public FindOutsideWalls(Int32 newColsCount, Int32 newRowsCount, Single newSTileWidth, Single newIniPosX, Single newIniPosY)
        {
            colsCount = newColsCount - 1;
            rowsCount = newRowsCount - 1;
            sTileWidth = newSTileWidth;
            iniPosX = newIniPosX;
            iniPosY = newIniPosY;
            Initialize();
        }

        public void Initialize()
        {
            Single iniRightWallPosX = (Single)(iniPosX) + (sTileWidth * colsCount);
            Single endRightWallPosX = iniRightWallPosX + sTileWidth;
            Single iniRightWallPosY = iniPosY;
            Single endRightWallPosY = iniRightWallPosY + (sTileWidth * 4);
            Int32 rightWallCol = colsCount;
            Int32 currentRightRowWall = 0;

            Single iniBottomWallPosX = iniPosX;
            Single endBottomWallPosX = iniBottomWallPosX + (sTileWidth * 4);

            Single iniBottomWallPosY = (Single)(iniPosY) + (sTileWidth * rowsCount * 2);
            Single endBottomWallPosY = iniBottomWallPosY + sTileWidth;
            Int32 currentBottomWallCol = 0;
            Int32 bottomRowWall = rowsCount;

            OutsideRightWallsPos newRightWall;
            OutsideBottomWallsPos newBottomWall;


            for (int i = 0; i < rowsCount/2; i++)
            {
                newRightWall = new OutsideRightWallsPos(iniRightWallPosX, endRightWallPosX, iniRightWallPosY,
                                                        endRightWallPosY, currentRightRowWall, rightWallCol);
                outsideRightWalls.Add(newRightWall);
                currentRightRowWall += 2;
                iniRightWallPosY += sTileWidth * 4;
                endRightWallPosY += sTileWidth * 4;
            }

            for (int i = 0; i < colsCount/4; i++)
            {
                newBottomWall = new OutsideBottomWallsPos(iniBottomWallPosX, endBottomWallPosX, iniBottomWallPosY,
                                                          endBottomWallPosY, bottomRowWall, currentBottomWallCol);

                outsideBottomWalls.Add(newBottomWall);
                currentBottomWallCol += 4;
                iniBottomWallPosX += sTileWidth * 4;
                endBottomWallPosX += sTileWidth * 4;
            }
        }
    }
}
