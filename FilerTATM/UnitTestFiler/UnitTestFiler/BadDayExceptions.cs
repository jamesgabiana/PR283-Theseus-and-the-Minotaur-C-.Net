using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilerTATM;
using System.IO;
namespace UnitTestFiler
{
    [TestClass]
    public class BadDayException
    {
        FileHandler fileHandler = new FileHandler();
        Validator validator = new Validator();


        //******** SAVE FILE\COMPRESSION TEST**********

        [TestMethod]
        public void Test_Save_Multiple_Theseus_Err()
        {
            String expected = "There must be only one Theseus, there are 3 Theseus on the map";
            String input = "TTT";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Multiple_Theseus_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_No_Theseus_Err()
        {
            String expected = "Theseus is not found on the map, Please edit the map";
            String input = "XM";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_No_Theseus_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Multiple_Minotaur_Err()
        {
            String expected = "There must be only one Minotaur, there are 3 Minotaur on the map";
            String input = "TXMMM";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Multiple_Minotaur_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_No_Minotaur_Err()
        {
            String expected = "Minotaur is not found on the map, Please edit the map";
            String input = "TX";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_No_Minotaur_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_No_Exit_Err()
        {
            String expected = "Exit is not found on the map, please put an exit on the map";
            String input = "TM";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_No_Exit_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_InvalidFile_Format_Err()
        {
            String expected = "Invalid File Format, closing bracket \']\' found before open bracket, missing \'[\'";
            String input = "TMX][";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_InvalidFile_Format_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_InvalidFile_Format_Err2()
        {
            String expected = "Invalid File Format, Number of closing and opening brackets are not equal\n" +
                        "Number of opening brackets is 2, Number of closing brackets is 1";
            String input = "TMX[[]";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_InvalidFile_Format_Err2 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err()
        {
            String expected = "Invalid File Format, " + "\"A\"" + " is invalid character";
            String input = "TMXA";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err2()
        {
            String expected = "Invalid File Format, " + "\"$\"" + " is invalid character";
            String input = "$%^&";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err2 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err3()
        {
            String expected = "Invalid File Format, " + "\"%\"" + " is invalid character";
            String input = "%]]]]]]]";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err3 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err4()
        {
            String expected = "Invalid File Format, " + "\"*\"" + " is invalid character";
            String input = "[[*]]]]]]";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err3 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err5()
        {
            String expected = "Invalid File Format, " + "\"(\"" + " is invalid character";
            String input = "[(SVSV3S]";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err5 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err6()
        {
            String expected = "Invalid File Format, " + "\"}\"" + " is invalid character";
            String input = "2[SVCTM}";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err6 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err7()
        {
            String expected = "Invalid File Format, " + "\";\"" + " is invalid character";
            String input = "2SVDD;%$^&;";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err7 Failed");
            }
        }

        [TestMethod]
        public void Test_Save_Invalid_Chars_Err8()
        {
            String expected = "Invalid File Format, " + "\"~\"" + " is invalid character";
            String input = "6[SVS]XTM~;";
            try
            {
                //do
                validator.ValidateMap(input);
                fileHandler.SaveMap("H:\\C#\\FilerDocuments\\SaveTest.txt", input);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Save_Invalid_Chars_Err7 Failed");
            }
        }


        //******** LOAD FILE\DECOMPRESSION TEST**********

        [TestMethod()]
        [ExpectedException(typeof(FileNotFoundException))]
        public void Invalid_File_Location_Err()
        {
            fileHandler.LoadMap("FAKE:\\C#\\FilerDocuments\\InvalidCharacters.txt");
        }

        [TestMethod]
        public void Test_Load_Invalid_File_Type_Err()
        {
            String expected = "File Failed to load!, Please select a .txt file\nError: H:\\C#\\FilerDocuments\\InvalidCharacters.xt";
            try
            {
                //do
                fileHandler.LoadMap("H:\\C#\\FilerDocuments\\InvalidCharacters.xt");
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_InvalidFileLocation_Err Failed");

            }
        }

        [TestMethod]
        public void Test_Load_Multiple_Theseus_Err()
        {
            String expected = "There must be only one Theseus, there are 3 Theseus on the map";
            try
            {
                String map = "            .   .\n" +
                              "            | X |\n" +
                              ".___.___.___.   .___.\n" +
                              "|   | T   T       T |\n" +
                              ".   .   .   .___.   .\n" +
                              "|       |       | M |\n" +
                              ".   .___.   .   .   .\n" +
                              "|           |       |\n" +
                              ".   .___.___.   .   .\n" +
                              "|           |   |   |\n" +
                              ".   .   .   .___.   .\n" +
                              "|                   |\n" +
                              ".___.___.___.___.___.";
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_Multiple_Theseus_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_No_Theseus_Err()
        {
            String expected = "Theseus is not found on the map, Please edit the map";
            try
            {
                String map = "            .   .\n" +
                              "            | X |\n" +
                              ".___.___.___.   .___.\n" +
                              "|   |               |\n" +
                              ".   .   .   .___.   .\n" +
                              "|       |       | M |\n" +
                              ".   .___.   .   .   .\n" +
                              "|           |       |\n" +
                              ".   .___.___.   .   .\n" +
                              "|           |   |   |\n" +
                              ".   .   .   .___.   .\n" +
                              "|                   |\n" +
                              ".___.___.___.___.___.";
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_No_Theseus_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_Multiple_Minotaur_Err()
        {
            String expected = "There must be only one Minotaur, there are 3 Minotaur on the map";
            String map = "            .   .\n" +
                              "            | X |\n" +
                              ".___.___.___.   .___.\n" +
                              "|   | T             |\n" +
                              ".   .   .   .___.   .\n" +
                              "|       |       | M |\n" +
                              ".   .___.   .   .   .\n" +
                              "|           |     M |\n" +
                              ".   .___.___.   .   .\n" +
                              "|           |   | M |\n" +
                              ".   .   .   .___.   .\n" +
                              "|                   |\n" +
                              ".___.___.___.___.___.";
            try
            {

                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");
            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_Multiple_Minotaur_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_No_Minotaur_Err()
        {
            String expected = "Minotaur is not found on the map, Please edit the map";
            String map = "            .   .\n" +
                              "            | X |\n" +
                              ".___.___.___.   .___.\n" +
                              "|   | T             |\n" +
                              ".   .   .   .___.   .\n" +
                              "|       |       |   |\n" +
                              ".   .___.   .   .   .\n" +
                              "|           |       |\n" +
                              ".   .___.___.   .   .\n" +
                              "|           |   |   |\n" +
                              ".   .   .   .___.   .\n" +
                              "|                   |\n" +
                              ".___.___.___.___.___.";
            try
            {
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_No_Minotaur_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_No_Exit_Err()
        {
            String expected = "Exit is not found on the map, please put an exit on the map";
            String map = "            .   .\n" +
                              "            |   |\n" +
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
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_No_Exit_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_InvalidFile_Format_Err()
        {
            String expected = "Invalid File Format, closing bracket \']\' found before open bracket, missing \'[\'";
            String map = "]D2H2D.[";
            try
            {
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_InvalidFile_Format_Err Failed");
            }
        }

        [TestMethod]
        public void Test_Load_InvalidFile_Format_Err2()
        {
            String expected = "Invalid File Format, Number of closing and opening brackets are not equal\n" +
                        "Number of opening brackets is 2, Number of closing brackets is 1";
            String map = "[[D2H2D].";
            try
            {
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_InvalidFile_Format_Err2 Failed");
            }
        }

        [TestMethod]
        public void Test_Load_Invalid_Chars_Err()
        {
            String expected = "Invalid File Format, " + "\"$\"" + " is invalid character";
            String map = "$%^&*";
            try
            {
                //do
                validator.ValidateMap(map);
                Assert.Fail("An exception should have been thrown");

            }
            catch (InvalidInputError ex)
            {
                //assert
                Assert.AreEqual(expected, ex.Message, "Test_Load_Invalid_Chars_Err Failed");

            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_Multiple_Theseus_Err2()
        {
            String map = fileHandler.LoadMap("H:\\C#\\FilerDocuments\\WriteLinesMultipleTheseus.txt");
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Brackets_Err()
        {
            String map = "2[SV]3[HV]2[SH]]]]]]]]]]]]]]]]]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Brackets_Err2()
        {
            String map = "3[[[[[[[[[SV]3[HV]2[SH]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Brackets_Err3()
        {
            String map = "5][3S3V3H][[[";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Brackets_Err4()
        {
            String map = "7]{]]{}[}}}[[3S3V3H]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Brackets_Err5()
        {
            String map = "10[2][3][3]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err1()
        {
            String map = "[[2][3][3]]";
            validator.ValidateMap(map);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err3()
        {
            String map = "2[SV][D][D][D][D[D][D][D]D[D]DDD[D]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err4()
        {
            String map = "[2[SV]2[SV]2[SV]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err5()
        {
            String map = "3SD.\n" +
                        "3SC|\n" +
                        "3HDH.\n" +
                        "\n" +
                        "V2S2V|\n" +
                        "3DHD.\n" +
                        "V4S|\n" +
                        "5H.";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err6()
        {
            String map = "3SD.\n" +
                        "3SC|\n" +
                        "3HDH.H" +
                        "5H.";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err7()
        {
            String map = "S2D3S[]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err8()
        {
            String map = "2[[V2S]|";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err9()
        {
            String map = "[[][][]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err10()
        {
            String map = "[[SV][SV][SV]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err11()
        {
            String map = "[[H4[SV2[SH]]]]";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err12()
        {
            String map = "2[SV]...........................";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err13()
        {
            String map = "2[SV]______________________";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err14()
        {
            String map = "2[SV]||||||||||||||||||||||||||||||||";
            validator.ValidateMap(map);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidInputError))]
        public void Test_Load_InvalidFile_Format_Err15()
        {
            String map = "3SD.\n" +
                        "3SC|\n" +
                        "3HDH.\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "\n" +
                        "V2S2V|\n" +
                        "3DHD.\n" +
                        "V4S|\n" +
                        "5H."; ;
            validator.ValidateMap(map);
        }
    }
}
