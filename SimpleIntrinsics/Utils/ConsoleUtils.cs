using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleIntrinsics.Utils
{
    public class ConsoleUtils
    {
        public static void Write(ConsoleColor color, string text)
        {
            var copy = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = copy;
        }

        public static void Write(string text)
        {
            Console.Write(text);
        }

        public static void WriteLine(ConsoleColor color, string text)
        {
            var copy = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = copy;
        }

        public static void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
