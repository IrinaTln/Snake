using System;
using static System.Console;
using System.Threading;

namespace Snake
{
    class Program
    {
		private const int MapWidth = 80;
		private const int MapHeight = 25;
		public const ConsoleColor BorderColor = ConsoleColor.Yellow;
		static void Main(string[] args)
        {
			SetWindowSize(MapWidth, MapHeight);
			SetBufferSize(MapWidth, MapHeight);
			CursorVisible = false;


            Walls walls = new Walls(80, 25);
            walls.Draw();


            //Отрисовка рамочки
            HorizontalLine upline = new HorizontalLine(0, 78, 0, '+', BorderColor);
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '+', BorderColor);
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+', BorderColor);
            VerticalLine rightline = new VerticalLine(0, 24, 78, '+', BorderColor);
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{
					food = foodCreator.CreateFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(300);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}


		static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 12;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("G A M E    O V E R", xOffset + 1, yOffset++);
			
		}

		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}