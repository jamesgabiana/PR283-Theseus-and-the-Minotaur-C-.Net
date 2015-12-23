using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class TileScaler
    {
        public Single AssignTileWidth(Single panelWidth, Single panelHeight, List<List<String>> _2DMap)
        {
            Single tileWidth;
            Single trim;
            Int32 mapRowCount = CalcNumberOfRowsInMap(_2DMap);
            Int32 mapColCount = CalcLongestRowInMap(_2DMap);

            if (panelHeight > panelWidth)
            {
                if (mapRowCount > mapColCount)
                {
                    tileWidth = panelWidth / (Single)(mapRowCount);
                    trim = (tileWidth / 4) / mapRowCount;
                }
                else
                {
                    tileWidth = panelWidth / (Single)(mapColCount);
                    trim = (tileWidth / 4) / mapColCount;
                }

            }
            else
            {
                if (mapRowCount > mapColCount)
                {
                    tileWidth = panelHeight / (Single)(mapRowCount);
                    trim = (tileWidth / 4) / mapRowCount;

                }
                else
                {
                    tileWidth = panelHeight / (Single)(mapColCount);
                    trim = (tileWidth / 4) / mapColCount;
                }
            }

            return tileWidth - trim;
        }

        public Int32 CalcLongestRowInMap(List<List<String>> _2DMap)
        {
            Int32 longest = _2DMap[0].Count;
            for (int i = 1; i < _2DMap.Count; i++)
            {
                if (_2DMap[i].Count > longest)
                    longest = _2DMap[i].Count;
            }
            return (longest - 1) / 4;
        }

        public Int32 CalcNumberOfRowsInMap(List<List<String>> _2DMap)
        {
            return ((_2DMap.Count) - 1) / 2;
        }
    }
}
