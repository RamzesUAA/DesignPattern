using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID.WRONG_SOLID
{
    class Rectangle
    {
        private int width;
        private int height;
        void setWidth(int width)
        {
            this.width = width;
        }
        void setHeight(int height)
        {
            this.height = height;
        }
    }

    class Square:Rectangle
    {
        private int width;
        private int height;
        void setWidth(int width)
        {

            this.width = width;
            this.height = width;

        }
        void setHeight(int height)
        {
            this.height = height;
            this.width = height;

        }
    }



}
