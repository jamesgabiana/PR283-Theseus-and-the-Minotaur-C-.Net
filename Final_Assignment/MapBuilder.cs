using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class MapBuilder
    {


        public List<List<ITile>> TileList = new List<List<ITile>>();
        public List<List<String>> _2DMap = new List<List<String>>();
        public Boolean hasTheseus = false;
        public Boolean hasMinotaur = false;
        public Boolean hasExit = false;
        TileScaler tileScaler = new TileScaler();

        public Single iniPosX;
        public Single iniPosY;

        public String map;
        public Single panelWidth;
        public Single panelHeight;
        public Single tileWidth;

        public MapBuilder(String newMap, Single newPanelWidth, Single newPanelHeight)
        {
            map = newMap;
            panelWidth = newPanelWidth;
            panelHeight = newPanelHeight;
            InitilizeMapBuilder();

        }


        public void InitilizeMapBuilder()
        {
            ConvertStringToList();
            CalcInitialPosX();
            CalcInitialPosY();
            ConvertStringListToObjectList();

        }


        public void CalcInitialPosX()
        {
            Single posX;
            //Single tileWidth = tileScaler.AssignTileWidth(panelWidth, panelHeight, _2DMap);
            Int32 numberOfRows = tileScaler.CalcNumberOfRowsInMap(_2DMap);
            Int32 numberOfCols = tileScaler.CalcLongestRowInMap(_2DMap);
            Single mapWidth = CalcMapWidth(numberOfCols, tileWidth);
            if (numberOfRows >= numberOfCols || panelWidth >= panelHeight)
            {
                posX = (panelWidth / 2) - ((mapWidth / 2)) - (tileWidth / 4);
            }
            else
            {
                posX = 0;
            }
            iniPosX = posX;
            //return posX;
        }

        public void CalcInitialPosY()
        {
            Single posY;
            //Single tileWidth = tileScaler.AssignTileWidth(panelWidth, panelHeight, _2DMap);
            Int32 numberOfRows = tileScaler.CalcNumberOfRowsInMap(_2DMap);
            Int32 numberOfCols = tileScaler.CalcLongestRowInMap(_2DMap);
            Single mapHeight = CalcMapWidth(numberOfRows, tileWidth);

            if (numberOfRows >= numberOfCols && panelWidth >= panelHeight)
            {
                posY = 0;
            }
            else
            {
                posY = (panelHeight / 2) - ((mapHeight / 2)) - (tileWidth / 4);
            }

            iniPosY = posY;
            //return posY;
        }

        public Single GetTileWidth()
        {
            Single tileWidth = tileScaler.AssignTileWidth(panelWidth, panelHeight, _2DMap);

            return tileWidth;
        }


        public Int32 GetDesignerPlanelHeight()
        {
            Int32 height = 0;
            return height;
        }

        public String Convert2DArrayToString()
        {
            String newMapString = "";

            for (int i = 0; i < _2DMap.Count; i++)
            {
                for (int j = 0; j < _2DMap[i].Count; j++)
                {
                    newMapString += _2DMap[i][j];
                    if (j == _2DMap[i].Count-1)
                    {
                        newMapString += "\n";
                    }
                    
                }
            }

            return newMapString;
        }


        public void ConvertStringToList()
        {
            List<String> temp;
            temp = new List<String>();
            foreach (Char c in map)
            {
                if (c != '\n')
                {
                    temp.Add(c + "");
                }
                else
                {

                    //temp.ForEach(item => Console.Write(item));
                    _2DMap.Add(temp);
                    temp = new List<String>(); // a new List, not a reference

                }
            }
            _2DMap.Add(temp);
            tileWidth = tileScaler.AssignTileWidth(panelWidth, panelHeight, _2DMap);
        }

        public Single CalcMapWidth(Int32 maxCols, Single tileWidth)
        {
            Single mapWidth = maxCols * tileWidth;
            return mapWidth;

        }

        public Single CalcMapHeight(Int32 rowCount, Single tileWidth)
        {
            Single mapHeight = rowCount * tileWidth;
            return mapHeight;
        }

        public void ConvertStringListToObjectList()
        {
            TileList.Clear();
            Boolean isLongSpace = false;
            Single currentPosX = iniPosX;
            Single currentPosY = iniPosY;
            ITile tile;
            List<ITile> temp;
            Single smallerTileWidth = tileWidth / 4;
            temp = new List<ITile>();
            Boolean hasScanned = false;

            for (int i = 0; i < _2DMap.Count; i++)
            {
                for (int j = 0; j < _2DMap[i].Count; j++)
                {
                    if (hasScanned == false)
                    {
                        if (_2DMap[i][j] == " ")
                        {
                            for (int k = 0; k < _2DMap[i].Count; k++)
                            {
                                if (_2DMap[i][k] == "|")
                                {
                                    isLongSpace = true;
                                    hasScanned = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            isLongSpace = false;
                        }

                    }

                    tile = CreateTypeOfObject(_2DMap[i][j], currentPosX, currentPosY, isLongSpace);
                    temp.Add(tile);

                    currentPosX += smallerTileWidth;
                }

                hasScanned = false;
                TileList.Add(temp);
                temp = new List<ITile>(); // a new List, not a reference
                currentPosX = iniPosX;
                if (isLongSpace == true)
                {
                    currentPosY += smallerTileWidth * 3;
                }
                else
                {
                    currentPosY += smallerTileWidth;
                }

            }
        }


        private ITile CreateTypeOfObject(String input, Single posX, Single posY, Boolean isLongSpace)
        {

            ITile tile;
            Single smallerTileWidth = tileWidth / 4;

            switch (input)
            {
                case ".":
                    tile = new DrawDot(posX, posY, smallerTileWidth, smallerTileWidth);
                    break;
                case "_":
                    tile = new DrawHWall(posX, posY, smallerTileWidth, smallerTileWidth);
                    break;
                case " ":
                    if (isLongSpace == true)
                    {
                        tile = new DrawSpace(posX, posY, smallerTileWidth, smallerTileWidth * 3);
                    }
                    else
                    {
                        tile = new DrawSpace(posX, posY, smallerTileWidth, smallerTileWidth);
                    }
                    break;
                case "|":
                    tile = new DrawVWall(posX, posY, smallerTileWidth, smallerTileWidth * 3);
                    break;
                case "X":
                    tile = new DrawExit(posX - smallerTileWidth, posY, smallerTileWidth * 3, smallerTileWidth * 3);
                    hasExit = true;
                    break;
                case "T":
                    tile = new DrawTheseus(posX - smallerTileWidth, posY, smallerTileWidth * 3, smallerTileWidth * 3);
                    hasTheseus = true;
                    break;
                case "M":
                    tile = new DrawMinotaur(posX - smallerTileWidth, posY, smallerTileWidth * 3, smallerTileWidth * 3);
                    hasMinotaur = true;
                    break;
                default:
                    tile = new DrawDot(posX, posY, smallerTileWidth, smallerTileWidth);
                    break;
            }
            return tile;
        }
    }
}
