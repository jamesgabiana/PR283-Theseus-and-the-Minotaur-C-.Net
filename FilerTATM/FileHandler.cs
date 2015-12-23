using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilerTATM
{
    public class FileHandler : IFileHandler
    {
        
        public String LoadMap(String input) 
        {
            StringBuilder map = new StringBuilder();
            String txt;
            InvalidInputError invalidInput;

            txt = input.Substring((input.Length) - 4, 4);
            if (txt != ".txt")
            {
                invalidInput = new InvalidInputError("File Failed to load!, Please select a .txt file\nError: " + input);
                throw invalidInput;
            }
            if (!File.Exists(@input))
            {
                throw new FileNotFoundException();
            }
            map.Append(@File.ReadAllText(input));

            return map.ToString();
        
        }

        public void SaveMap(String path, String input)
        {
            String txt;
            txt = path.Substring((@path.Length) - 4, 4);

            if (txt != ".txt")
            {
                throw new ArgumentOutOfRangeException();
            }
            if (!File.Exists(@path))
            {
                throw new FileNotFoundException();
            }
            File.WriteAllText(@path, input);
        }
    }
}
