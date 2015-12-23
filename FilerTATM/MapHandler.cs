using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTATM
{
    public class MapHandler : IMapHandler // This is an example of The Middle-Man Class, Bad Smells
    {
        //Do Compression and Decompression here
        Compressor comp = new Compressor();
        Decompressor decomp = new Decompressor();
        private Map myMap;

        public String Map
        {   
            get 
            {
                return myMap.map;
            }
        }

        public String CompressMap(String input)
        {
            String temp1 = "";
            String temp2 = "";
            String stage1 = comp.StageOneCompression(input);
            if (stage1 == input)
            {
                return stage1; // means that the map is not compressed, so do not decompress it
            }
            String stage2 = comp.StageTwoCompression(stage1);
            while (temp1 != stage2)
            {
                temp1 = temp2;
                if (stage2 == input)
                {
                    break;
                }
                else
                {
                    stage2 = comp.StageThreeCompression(stage2);
                }
                temp2 = stage2;
            }
            this.myMap = new Map(stage2);
            return stage2;
        }
        public String DecompressMap(String input)
        {
            String temp1 = "";
            String temp2 = "";
            String stage1 = decomp.StageOneDecompression(input);
            String stage2;
            if (stage1 == input)
            {
                return decomp.StageTwoDecompression(stage1); // means that the map is not compressed, so do not decompress it
            }
            while (temp1 != stage1)
            {
                temp1 = temp2;
                if (stage1 == input)
                {
                    break;
                }
                else
                {
                    stage1 = decomp.StageOneDecompression(stage1);
                }
                temp2 = stage1;
            }
            stage2 = decomp.StageTwoDecompression(stage1);// else decompress the map
            this.myMap = new Map(stage2);
            return stage2;
        }
    }
}
