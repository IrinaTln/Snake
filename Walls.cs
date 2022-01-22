using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
		List<Figure> wallList;

        public ConsoleColor BorderColor { get; }

        public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			// Отрисовка рамочки
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+', BorderColor);
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+', BorderColor);
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+', BorderColor);
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+', BorderColor);

			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Drow();
			}
		}
	}
}
