using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.WriteLine("Enter first number :");
            num[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            num[2] = int.Parse(Console.ReadLine());
            int highest = ((num[0] > num[1] ? num[0] : num[1]) > num[2] ? (num[0] > num[1] ? num[0] : num[1]) : num[2]);
            Console.WriteLine($"The biggest number is : {highest}");

            
        }
    }
}
