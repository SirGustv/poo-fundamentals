using System;
using RPGComPOO.src.Entities;

namespace RPGComPOO.src.Layout
{
    public class Interface
    {

        public static void Show()
        {
            Console.Clear();
            DrawScreen();

            Console.SetCursorPosition(15, 1);
            Console.WriteLine("RPG Status");
            Console.SetCursorPosition(9, 2);
            Console.WriteLine("======================");
            Heroes();
            DrawLines();
            Draw("+", "-", 36);





        }
        public static void DrawScreen()
        {
            Draw("+", "=", 36);
            DrawLines();
        }
        public static void Draw(string symbol, string space, int value)
        {
            Console.Write(symbol);
            for (int columns = 0; columns <= value; columns++)
                Console.Write(space);
            Console.Write(symbol);
            Console.Write("\n");
        }
        public static void DrawLines()
        {
            for (int lines = 0; lines < 1; lines++)
                Draw("|", " ", 36);
        }
        public static void Heroes()
        {
            Knight arus = new Knight("Arus", 29, "Knight", "489/500", "20/20");
            Wizard jenica = new Wizard("Jenica", 30, "White Wizard", "180/200", "460/500");

            Console.WriteLine(arus);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" " + arus.Attack());
            Console.WriteLine(" " + arus.Attack(4));
            Console.WriteLine(" " + arus.Attack(9));
            Console.WriteLine(" ------------------------------------");
        }

    }

}