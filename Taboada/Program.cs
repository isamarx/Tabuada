using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual tabuada você quer ver?");
            int tab = Convert.ToInt16(Console.ReadLine());

            {
                for (int d = 1; d <= 10; d++)

                    Console.WriteLine(tab + " x " + d + " = " + tab * d);

            }
        }
    }
}
