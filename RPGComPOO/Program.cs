using System;
using RPGComPOO.src.Entities;

namespace RPGComPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 29, "Knight", "489/500", "20/20");
            Wizard jenica = new Wizard("Jenica", 30, "White Wizard", "180/200", "460/500");

            Console.WriteLine(jenica);
            Console.WriteLine(arus);

        }
    }
}
