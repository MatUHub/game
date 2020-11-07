using System;

namespace GameHella
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(1, 3, '*');
            Draw(5, 5, '#');
            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
