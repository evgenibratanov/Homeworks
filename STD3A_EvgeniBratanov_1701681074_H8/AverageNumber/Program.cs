using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbersCount = 0;
            while (a != 0)
            {
                if (a >= 1 && a <= 255)
                {
                    if (a % 2 == 0)
                    {
                        sum = sum + a;
                        numbersCount++;
                    }
                    Console.WriteLine("Enter number:");
                    a = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Enter number:");
                    a = int.Parse(Console.ReadLine());
                }
            }
            if (numbersCount == 0)
            {
                Console.WriteLine("There aren't even numbers in this diapason (1,255]) !!!");
            }
            else
            {
                Console.WriteLine("Finished !!!");
                Console.WriteLine("************************************");
                Console.WriteLine();
                Console.WriteLine("Average " + sum / numbersCount);
            }
            Console.WriteLine();
        }
    }
}
