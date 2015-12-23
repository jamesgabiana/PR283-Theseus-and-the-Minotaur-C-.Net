using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilerTATM
{
    class Program
    {
        static void Main(string[] args)
        {
            FileController filer =  new FileController(new MapHandler(), new FileView(), new FileHandler(), new Validator());
            
            //filer.Save();
            //filer.Load();
            filer.CommandLine();
        }
    }
}
