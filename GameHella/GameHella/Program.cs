using System;
using System.Security.Cryptography;

namespace GameHella
{
    class Program
    {

        

        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.x = 6;
            p1.y = 7;
            p1.sym = '3';
            Draw(p1.x, p1.y, p1.sym);


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
