using System;

namespace What_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will choose a number, please guess it.");
            int r = new Random().Next(1, 21);
            Console.WriteLine("Now guess!");
            int t = 0;
            while (t < 6)
            {
                string sa = Console.ReadLine();
                int a = int.Parse(sa);
                if (a == r)
                {
                    Console.WriteLine("Congratulations, that's it!");
                    Console.ReadKey();
                    break;
                }
                else if (a < r)
                {
                    Console.WriteLine("Your number is smaller than mine.");
                    t = t + 1;
                    Console.WriteLine("Number of tries: " + t);
                }
                else if (a > r)
                {
                    Console.WriteLine("Your number is greater than mine.");
                    t = t + 1;
                    Console.WriteLine("Number of tries: " + t);

                }
                
            }
        }
    }
}