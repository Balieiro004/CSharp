using System;
using OrientacaoObjetos.src.Entities;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard janni = new Wizard("Janni", 23, "Wizard");
            Ninja naruto = new Ninja("Naruto", 23, "Ninja");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(janni.Attack());
            Console.WriteLine(naruto.Attack());
        }
    }
}
