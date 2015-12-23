using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilerTATM
{
    public interface IMapHandler
    {
        String CompressMap(String map);
        String DecompressMap(String map);
        String Map{ get; }
    }
}
