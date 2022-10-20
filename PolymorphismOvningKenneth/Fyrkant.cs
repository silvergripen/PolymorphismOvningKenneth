using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Fyrkant : Geometri
    {
        public double side = 4;
       
        public Fyrkant()
        {
            this.side = 4;
            
        }
        public override double Area()
        {
            area = side * side;
            return area;
            
        }
        public override void print()
        {
            Console.WriteLine("Area Fyrkant " + area);
        }
    }
}
