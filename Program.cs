using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Olá usuário\nMe chamo Ana Beatriz!");


            Console.ResetColor();
        }
    }
}
