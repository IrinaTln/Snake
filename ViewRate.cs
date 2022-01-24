using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class ViewRate
    {
        public static void Results()
        {
 
            int xOffset = 30;
            int yOffset = 6;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Walls walls = new Walls(80, 25);
            walls.Draw();

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Результаты", xOffset + 1, yOffset++);
            yOffset++;

            Console.ForegroundColor = ConsoleColor.Green;
            Text.WriteText("Очки   Имя", xOffset, yOffset++);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Users.ShowRate(xOffset, yOffset++);

            Console.ReadLine();
        }
    }
}
