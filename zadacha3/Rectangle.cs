using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha3
{
    internal class Rectangle
    {
        private double width;
        private double height;

        public Rectangle()
        {
            width = 1;
            height = 1;
        }

        public Rectangle(double width, double height)
        {
            if (width == 0 || height == 0)
            {
                throw new ArgumentException(
                    "Страните на правоъгълника не могат да бъдат равни на 0!"
                );
            }

            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return width * height;
        }
    }
}
