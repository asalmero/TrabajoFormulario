using System;
using System.Net;

namespace AplicacionPrueba
{
    class Program
    {
        static void Main(string[] args)

        {
            int number, i, j, count = 1;
            Console.Write("Rows :");
            number = int.Parse(Console.ReadLine());
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
          

        }
    }
   
}
