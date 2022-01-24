using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class LengthException : Exception
    {
        public override string Message
        {
            get
            {
                return "Введите минимум 3 символа!!!!";
            }
        }
    }
}
