using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assignment
{
    class DrawExit : ITile
    {
        public Single posX;
        public Single posY;
        public Single width;
        public Single height;

        public DrawExit(Single newPosX, Single newPosY, Single newWidth, Single newHeight)
        {
            posX = newPosX;
            posY = newPosY;
            width = newWidth;
            height = newHeight;
        }

        public float PosX
        {
            set
            {
                posX = value;
            }
            get
            {
                return posX;
            }
        }

        public float PosY
        {
            set
            {
                posY = value;
            }
            get
            {
                return posY;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }
        }

        public float Width
        {
            get
            {
                return width;
            }
        }
    }
}
