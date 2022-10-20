using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Parallellogram : Geometri
    {
        public double height;
        public double lenght;

        public Parallellogram()
        {
            this.height = 4;
            this.lenght = 8;
        }
        public override double Area()
        {
            area = height * lenght;

            return area;
        }
        public override void print()
        {
            Console.WriteLine("Area Parallellogram " + area);
        }
    }
}
