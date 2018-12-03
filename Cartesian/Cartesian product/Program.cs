using System;

namespace Cartesian_product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me two numbers, and I will show you Cartesian product.");
            Console.WriteLine("First number: ");
            string sx = Console.ReadLine();
            int x = int.Parse(sx);
            Console.WriteLine("Second number: ");
            string sy = Console.ReadLine();
            int y = int.Parse(sy);
            while (y != 0)
            {
                while (x != 0)
                {
                    Console.Write("(" + x + ", " + y + ")");
                    x--;  
                }
                y--;
                x = int.Parse(sx);
                Console.WriteLine();  
            }  
        }
    }
}
