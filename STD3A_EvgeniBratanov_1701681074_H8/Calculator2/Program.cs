using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            do
            {
                Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                answer = Console.ReadLine();

                if (answer == "yes")
                {


                    Console.WriteLine("Enter first number:");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second number:");
                    double secondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operation:");
                    char operation = char.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case '+':
                            double plus = (firstNumber) * (secondNumber) * 0.1;
                            Math.Round(plus, 2);
                            Console.WriteLine($"Result is : {plus}");


                            break;
                        case '-':
                            if (firstNumber > secondNumber)
                            {
                                double a = (firstNumber * firstNumber) - secondNumber;
                                Math.Round(a, 2);
                                Console.WriteLine($"Result is:{a}");



                            }
                            else
                            {
                                double b = (secondNumber * secondNumber) - firstNumber;
                                Math.Round(b, 2);
                                Console.WriteLine($"Result is: {b}");

                            }



                            break;

                        case '*':
                            
                                double c = firstNumber * Math.Sqrt(secondNumber);
                                Math.Round(c, 2);
                                Console.WriteLine($"Result is: {c}");
                                break;
                            

                        case '/':
                            
                                if (secondNumber <= 0)
                                {
                                    Console.WriteLine("Error! You can't divide to 0");

                                }
                                else
                                {
                                    double d = firstNumber / secondNumber;
                                    Math.Round(d, 2);
                                    Console.WriteLine($"Result is: {d}");
                                }
                            
                            break;


                    }
                }

            } while (!(answer == "no"));
        }
    }   }
