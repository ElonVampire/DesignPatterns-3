using Bridge_Pattern.Abstraction;
using Bridge_Pattern.Implementor;
using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new Hammer(new Nails()).PrintComboDeal();
            Console.ReadKey();
            new Hammer(new Screws()).PrintComboDeal();
            Console.ReadKey();
        }
    }
}
