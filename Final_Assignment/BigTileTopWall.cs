using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class BigTileTopWall : IBigTile
    {
        public Single posX;
        public Single posY;
        public Single width;
        public Single height;
        public List<List<ITile>> tiles = new List<List<ITile>>();

        public BigTileTopWall(Single newPosX, Single newPosY, Single newWidth, Single newHeight)
        {
            posX = newPosX;
            posY = newPosY;
            width = newWidth;
            height = newHeight;
            Initialize();
        }

        public void Initialize()
        {
            Single currentPosX = posX;
            Single currentPosY = posY;
            List<ITile> temp;
            ITile ATile;

            //Fixed objects
            temp = new List<ITile>();
            tiles.Add(temp);
            ATile = new DrawDot(currentPosX, currentPosY, width, height);
            tiles[0].Add(ATile);
            currentPosX += width;
            for (int i = 0; i < 3; i++)
            {
                ATile = new DrawHWall(currentPosX, currentPosY, width, height);
                tiles[0].Add(ATile);
                currentPosX += width;
            }
            currentPosX = posX;
            currentPosY += height;

            temp = new List<ITile>();
            tiles.Add(temp);
            for (int i = 0; i < 4; i++)
            {
                ATile = new DrawSpace(currentPosX, currentPosY, width, height * 3);
                tiles[1].Add(ATile);
                currentPosX += width;
            }
        }

        public List<List<ITile>> smallTiles
        {
            get
            {
                return tiles;
            }
        }

    }
}
