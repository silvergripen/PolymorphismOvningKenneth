using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Ellips : Geometri
    {
        public double height;
        public double lenght;
        public double Pi;
        public Ellips()
        {
            this.height = 2;
            this.lenght = 3;
            this.Pi = 3.1415;
        }
        public override double Area()
        {
            area = (height * lenght) * Pi;

            return area;
        }
        public override void print()
        {
            Console.WriteLine("Area Ellips " + area);
        }
    }
}
