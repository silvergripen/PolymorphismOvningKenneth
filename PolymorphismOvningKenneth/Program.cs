using System;

namespace PolymorphismOvningKenneth
{
    class Program : Geometri
    {
        static void Main(string[] args)
        {
            Geometri newArea = new Geometri();
            Geometri newCirkle = new Cirkel();
            Geometri newFyrkan = new Fyrkant();
            Geometri newRektangle = new Rektangel();
            Geometri newParallellogram = new Parallellogram();
            Geometri newEllips = new Ellips();
            newCirkle.Area();
            newFyrkan.Area();
            newRektangle.Area();
            newParallellogram.Area();
            newEllips.Area();

            newCirkle.print();
            newFyrkan.print();
            newRektangle.print();
            newParallellogram.print();
            newEllips.print();
        }
    }
}
