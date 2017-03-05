using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cor2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5;i++ )
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Hellow World!!");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Hellow World.");
            }
            Console.ReadLine();
        }
    }
}
