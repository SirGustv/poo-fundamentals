using System;
using RPGComPOO.src.Entities;

namespace RPGComPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 25, "Knight");
            Console.Write(arus.Attack());

        }
    }
}
