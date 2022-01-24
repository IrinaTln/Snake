using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Text
    {
		public static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

    }
}
