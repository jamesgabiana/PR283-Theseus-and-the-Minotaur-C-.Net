using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;


namespace FilerTATM
{
    class FileController
    {
        IMapHandler maphandler;
        IFileView fileView;
        IFileHandler fileHandler;
        IValidator validator;

        public FileController(IMapHandler newMapHandler, IFileView newFileView, IFileHandler newFileHandler, IValidator newValidator)
        {
            maphandler = newMapHandler;
            fileView = newFileView;
            fileHandler = newFileHandler;
            validator = newValidator;
        }
        
        public void Save()                        
        {
            Boolean fail = true;
            String map = "            .   .\n" +
                         "            | X |\n" +
                         ".___.___.___.   .___.\n" +
                         "|   | T             |\n" +
                         ".   .   .   .___.   .\n" +
                         "|       |       | M |\n" +
                         ".   .___.   .   .   .\n" +
                         "|           |       |\n" +
                         ".   .___.___.   .   .\n" +
                         "|           |   |   |\n" +
                         ".   .   .   .___.   .\n" +
                         "|                   |\n" +
                         ".___.___.___.___.___.";
            try
            {
                validator.ValidateMap(map);
                fileView.Show("Below is the orinal map to be saved.", true);
                fileView.Show(map, true);
                map = maphandler.CompressMap(map);
                fileView.Show("Below shows the Compressed map that was saved.", true);

                fileView.Show(maphandler.Map, true);// struct Map

                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\ZControllerSave.txt", map);
                fileView.Show("FILE SUCCESFULLY SAVED", true);
                fail = false;
            }
            catch (InvalidInputError ex)
            {
                fileView.Show(ex.Message, true);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                fileView.Show(ex.Message + "File Failed to save!, make sure its a .txt file", true);
            }
            catch (FileNotFoundException ex)
            {
                fileView.Show(ex.Message + "File Failed to save!, Please input the correct location", true);
            }
            finally
	        {
                if (fail == true)
                {
                    fileView.Show("FAILED TO SAVE FILE!", true); 
                }
	        }
            

        }

        public void Load()
        {
            Boolean fail = true;
            try
            {
                String map = fileHandler.LoadMap("H:\\C#\\FilerDocuments\\ControllerSave.txt");
                validator.ValidateMap(map);
                map = maphandler.DecompressMap(map);
                fileView.Show("Below shows the Decompressed map loaded from file.", true);

                fileView.Show(maphandler.Map, true);// struct Map

                fileView.Show("FILE SUCCESFULLY LOADED", true);
                fail = false;
            }
            catch (InvalidInputError ex)
            {
                fileView.Show(ex.Message, true);
            }
            catch (FileNotFoundException ex)
            {
                fileView.Show(ex.Message + "File not found!, Please input the correct location", true);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                fileView.Show(ex, true);
            }
            finally 
            {
                if (fail == true)
                {
                    fileView.Show("FAILED TO LOAD FILE!", true);
                }
                fileView.Stop();
            }
        }

        public void TryCompression(String input)
        {
            try
            {
                validator.ValidateMap(input);
                maphandler.CompressMap(input);
                fileView.Show("Below is the Compressed version\n" + maphandler.Map + "\n", true); //struct class
            }
            catch (InvalidInputError ex)
            {
                fileView.Show(ex.Message, true);
            }

        }

        public void TryDeCompression(String input)
        {
            try
            {

                validator.ValidateMap(input);
                maphandler.DecompressMap(input);
                fileView.Show("Below is the Decompressed version\n" + maphandler.Map + "\n", true);// struct class
            }
            catch (InvalidInputError ex)
            {
                fileView.Show(ex.Message, true);
            }
        }

        public Boolean StopCommand(String userInput)
        {
            String a = "-e", b = "-E", c = "-D", d = "-d", e = "-c", f = "-C", g = "-h", h = "-H";
            Boolean stop = false;
            if (userInput == a
                             || userInput == b
                             || userInput == c
                             || userInput == d
                             || userInput == e
                             || userInput == f
                             || userInput == g
                             || userInput == h)
            {
                stop = true;
            }

            return stop;
        }

        public void CommandLine()
        {
            String command = "";
            fileView.Show("\nCOMMANDS\n-c to try compression\n-d to try decompression\n" +
                          "-h to view help\n-e to exit", true);
            String userInput;

            do
            {
                command = fileView.GetString("Please Enter Command: ");

                if (command == "-c" || command == "-C")
                {
                    do
                    {
                        userInput = fileView.GetString("Please enter the map in HARRISON FORMAT to be compressed\ne.g .___    |       .___    .___    | X | T | M |\n");
                        if (StopCommand(userInput) == true)
                        {
                            break;
                        }
                        TryCompression(userInput);
                    } while (StopCommand(userInput) == false);

                    command = userInput;
                }
                else if (command == "-d" || command == "-D")
                {
                    do
                    {
                        userInput = fileView.GetString("Please enter the map to be Decompressed e.g. 2[H4[SV]] or 2[3S3V3H]\n");
                        if (StopCommand(userInput) == true)
                        {
                            break;
                        }
                        TryDeCompression(userInput);
                    } while (StopCommand(userInput) == false);

                    command = userInput;
                }
                else if (command == "-H" || command == "-h")
                {
                    fileView.Show("\nCOMMANDS\n-c to try compression\n-d to try decompression\n" +
                                  "-h to view help\n\n-e to exit\nV = \"|   \"\nH = \".___\"\nS = \"    \"\nD = \".   \"\nX = \"  X \"\nC = \"| X \"\nT = \"  T \"\nY = \"|   \"\n" +
                                  "M = \"  M \"\nK = \"| M \"\n", true);
                }
                else if (command == "-E" || command == "-e")
                {
                    break;
                }
                else
                {
                    fileView.Show("The command was not recognized, try again.", true);
                }

            } while (command != "-E" || command != "-e");
        }
    }
}
