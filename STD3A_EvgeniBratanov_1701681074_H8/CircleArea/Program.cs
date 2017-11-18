using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RandomNumber = random.Next(33, 187);
            Console.WriteLine($"The square random heigh is {RandomNumber}");
            double S = RandomNumber * RandomNumber * Math.PI;
            Console.WriteLine($"The circle area is: {Math.Round(S,2)}");
            



        }
    }
}
