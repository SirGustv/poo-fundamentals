using System;
using RPGComPOO.scr.Entities;

namespace RPGComPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Person arus = new Person("Arus", 25, "Knight");
            Console.Write(arus.Attack());

        }
    }
}
