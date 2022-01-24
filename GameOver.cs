using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Snake
{
    class GameOver
    {
        public static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 7;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            Text.WriteText("G A M E    O V E R", xOffset + 1, yOffset++);


            Users users = new Users();

            Text.WriteText("Ваш счет: " + Users.rate, xOffset + 5, yOffset++);


            while (true)
            {
                try
                {
                    
                    Text.WriteText("Введите имя: ", xOffset + 5, 10);
                    Console.SetCursorPosition(43, 10);
                    string playername = Console.ReadLine();
                    int sym = 3;
                    if (sym <= playername.Length)
                    {
                        Users.ScoresSave(playername, Users.rate);
                        break;
                    }
                    else
                    {
                        throw new LengthException();
                    }
                }
                catch (LengthException)
                {
                    Text.WriteText("                                        ", xOffset, 10);
                    Text.WriteText("Введите имя, в котором минимум 3 символа", xOffset - 8, 11);
                }

            }
        }
    }
}

