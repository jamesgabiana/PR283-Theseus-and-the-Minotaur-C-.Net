using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class AlertOutput
    {
        public static String alertSelection = "Please DESLECT the bottom/right wall, A wall is NOT A TILE \nA WALL IS CURRENTLY SELECTED\n" +
                        alertSelection2;
        public static String alertSelection2 = "Select a group of RIGHT WALLS ONLY at a time\nSelect a group of BOTTOM WALLS ONLY at a time\nSelect a group of TILES ONLY at a time";
        public static String alertTileBottom = "You cannot select Tiles and Bottom walls at the same time!\n" + alertSelection2;
        public static String alertTileRight = "You cannot select Tiles and Right walls at the same time!\n" + alertSelection2;

        public static String alertRightBottom = "You cannot select Tiles and Bottom walls at the same time!\n" + alertSelection2;
        
        public static String alertT = "Please Select only one tile for Theseus";
        public static String alertM = "Please Select only one tile for Minotaur";
        public static String alertE = "Please Select only one tile for Exit";
        public static String alertSSave = "File Succesfully Saved!";

    }
}
