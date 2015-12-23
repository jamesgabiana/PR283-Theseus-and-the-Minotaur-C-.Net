using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilerTATM
{
    public class Validator : IValidator
    {
        Regex regex = new Regex(@"[^0-9\\[\]HDSVXCTYMK .|_\r\n]+");
        public void ValidateMap(String map)
        {
            Int32 countM = 0, countT = 0, countX = 0, openBracket = 0, closingbracket = 0;
            Boolean isFirstOpenBracket = false;
            InvalidInputError invalidInput;

            for (int i = 0; i < map.Length; i++)
            {
                if (regex.IsMatch(Convert.ToString(map[i])))
                {
                    invalidInput = new InvalidInputError("Invalid File Format, " + "\"" + Convert.ToString(map[i]) + "\"" + " is invalid character");
                    throw invalidInput;

                }
                if (map[i] == 'M' || map[i] == 'K')
                {
                    countM++;
                }
                if (map[i] == 'T' || map[i] == 'Y')
                {
                    countT++;
                }
                if (map[i] == 'X' || map[i] == 'C')
                {
                    countX++;
                }
                if (map[i] == '[')
                {
                    isFirstOpenBracket = true;
                    openBracket++;
                }
                if (map[i] == ']' && isFirstOpenBracket == false)
                {
                    invalidInput = new InvalidInputError("Invalid File Format, closing bracket \']\' found before open bracket, missing \'[\'");
                    throw invalidInput;
                }
                else if (map[i] == ']')
                {
                    closingbracket++;
                }
            }
            if (openBracket != closingbracket)
            {
                invalidInput = new InvalidInputError("Invalid File Format, Number of closing and opening brackets are not equal\n" +
                                                     "Number of opening brackets is " + openBracket + ", Number of closing brackets is " + 
                                                     closingbracket);
                throw invalidInput;
            }
            if (countT > 1)
            {
                invalidInput = new InvalidInputError("Invalid File Format, there must be only one Theseus, there are " + countT + " Theseus on the map");
                throw invalidInput;
            }

            if (countM > 1)
            {
                invalidInput = new InvalidInputError("Invalid File Format, there must be only one Minotaur, there are " + countM + " Minotaur on the map");
                throw invalidInput;
            }

        }

        /*invalidInput = new InvalidInputError(checkChar);
                throw invalidInput;*/

    }
}
