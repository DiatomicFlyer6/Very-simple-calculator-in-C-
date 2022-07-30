using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            bool running = true;
            
            double n1, n2;
            Console.WriteLine("Simple calculator in C#");
            Console.WriteLine("=======================");
            Console.WriteLine("Enter first number n1");
            string number1 = Console.ReadLine();
            n1 = Convert.ToDouble(number1);
            Console.WriteLine("Enter second number n2");
            string number2 = Console.ReadLine();
            n2 = Convert.ToDouble(number2);
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);
            while (running)
            {
                Console.WriteLine("\n=======================\nWhat mathematical operation do you want to perform?");
                Console.WriteLine("\n\t 1 - add\n\t 2 - subtract\n\t 3 - multiply\n\t 4 - divide\n\t 5 - power");
                string operation = Console.ReadLine();
                int operationconverted = Convert.ToInt32(operation);
                switch (operationconverted)
                {
                    case 1:
                        Console.WriteLine($"The result of {n1} + {n2} = " + (n1 + n2));
                        break;

                    case 2:
                        Console.WriteLine($"The result of {n1} - {n2} = " + (n1 - n2));
                        break;

                    case 3:
                        Console.WriteLine($"The result of {n1} * {n2} = " + (n1 * n2));
                        break;

                    case 4:
                        Console.WriteLine($"The result of {n1} / {n2} = " + (n1 / n2));
                        break;

                    case 5:
                        Console.WriteLine($"The result of {n1}^{n2} = " + (Math.Pow(n1, n2)));
                        break;
                }
                Console.WriteLine("Do you want to do another operation? Y/n");
                string exit = Console.ReadLine();
                if (exit == "y" || exit == "Y")
                {
                    continue;
                }
                else if (exit == "n")
                {
                    running = false;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
