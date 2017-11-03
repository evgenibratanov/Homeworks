using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose option (triangle,square and radians :");
            string thechoose = Console.ReadLine();
            switch (thechoose)
            {
                case "triangle":
                {
                        Console.WriteLine("Enter side:");
                        int side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height:");
                        int height = int.Parse(Console.ReadLine());
                        int answer = (side * height) / 2;
                        Console.WriteLine($"The area of the triangle is = {answer}  ");



                    }

                
                    break;
                case "square":
                        {
                        Console.WriteLine("Enter side:");
                        int side2 = int.Parse(Console.ReadLine());
                        int face = side2 * side2;
                        Console.WriteLine($"The are of the square is = {face}");


                    }

                        break;
                case "radians":
                    {
                        Console.WriteLine("Enter the degrees you want to transfer in radians:");
                        double degrees = double.Parse(Console.ReadLine());
                        double radians = (Math.PI / 180) * degrees;
                        Console.WriteLine($"Your degrees in radians are: {radians}");


                    }
                
                    break;
                
                   


            }
        }
    }
}
