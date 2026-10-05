using System;
using System.Collections.Generic;
using System.Text;

namespace zadacha3
{
    internal class Circle
    {
        private double radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(double radius)
        {
            if (radius == 0)
            {
                throw new ArgumentException(
                    "Радиусът на кръга не може да бъде равен на 0!"
                );
            }

            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
