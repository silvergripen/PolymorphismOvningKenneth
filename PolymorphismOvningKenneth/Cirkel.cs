using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Cirkel : Geometri
    {
        double Pi = 3.1415;
        public double radie;
        public Cirkel()
        {
            this.radie = 4;
        }
        public override double Area()
        {
            area = Pi * (radie * 2);

            return area;
        }
        public override void print()
        {
            Console.WriteLine("Area Cirkel " + area);
        }
    }
}
