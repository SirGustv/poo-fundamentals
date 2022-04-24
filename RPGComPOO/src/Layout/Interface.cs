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
            Knight arus = new Knight("Arus", 29, "Knight", "469/749", "72/72");
            Wizard jenica = new Wizard("Jenica", 30, "White Wizard", "325/601", "474/482");
            BWizard topapa = new BWizard("Topapa", 47, "Black Wizard", "180/385", "611/641");
            Ninja wedee = new Ninja("Wedee", 38, "Ninja", "292/574", "89/89");

            Console.WriteLine(arus);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" " + arus.Attack());
            Console.WriteLine(" " + arus.Attack(2));
            Console.WriteLine(" " + arus.Attack(10));
            Console.WriteLine(" ====================================\n");

            Console.WriteLine(jenica);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" " + jenica.Attack());
            Console.WriteLine(" " + jenica.Attack(3));
            Console.WriteLine(" " + jenica.Attack(9));
            Console.WriteLine(" ====================================\n");

            Console.WriteLine(topapa);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" " + topapa.Attack());
            Console.WriteLine(" " + topapa.Attack(1));
            Console.WriteLine(" " + topapa.Attack(12));
            Console.WriteLine(" ====================================\n");

            Console.WriteLine(wedee);
            Console.WriteLine(" ------------------------------------");
            Console.WriteLine(" " + wedee.Attack());
            Console.WriteLine(" " + wedee.Attack(1));
            Console.WriteLine(" " + wedee.Attack(12));
        }

    }

}