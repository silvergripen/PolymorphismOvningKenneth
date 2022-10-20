using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Rektangel : Geometri
    {
        public double height;
        public double lenght;

        public Rektangel()
        {
            this.height = 4;
            this.lenght = 6;
        }
        public override double Area()
        {
            area = height * lenght;

            return area;
        }
        public override void print()
        {
            Console.WriteLine("Area Rektangel " + area);
        }
    }
}
