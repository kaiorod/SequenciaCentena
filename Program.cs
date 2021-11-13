using System;
using System.Threading;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 1;
            Console.Clear();
            Console.Beep();
            while(c <= 100)
            {
                Thread.Sleep(50);
                Console.Write($" {c}");
                c++;
            }
            Console.WriteLine("");
        }
    }
}
