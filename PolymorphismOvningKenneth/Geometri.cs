using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismOvningKenneth
{
    class Geometri
    {
        public double area = 3;
        
        public virtual double Area()
        {

            return area;
        }
        public virtual void print()
        {

        }
    }
}
