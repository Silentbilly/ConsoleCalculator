using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Utils
    {
        public static void makeCalculation()
        {
            string signOfOperation;
            double num1;
            double num2;
            string quit;
            try
            {
                do
                {
                    Console.Write("Insert a mathematical sign: '+', '-', '*' or '/': ");
                    signOfOperation = Console.ReadLine();
                    quitRequest(signOfOperation);

                    // Input operation and throw exception if operation is incorrect
                    if (signOfOperation == "+" || signOfOperation == "-" || signOfOperation == "*" || signOfOperation == "/")
                    {
                        // Input values.
                        Console.WriteLine("Insert number 1");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Insert number 2");
                        num2 = double.Parse(Console.ReadLine());

                        Console.Write("{0} {1} {2} = ", num1, signOfOperation, num2);
                        CalculateClass calculateClass = new CalculateClass();
                        // Make calculations.
                        Console.WriteLine(calculateClass.Calculate(num1, num2, signOfOperation));
                    }
                    else
                    {
                        throw new ArgumentException("Unexpected operation!");
                    }
                    // Repeat or quit. 
                    Console.WriteLine("Press any key for repeat. Or 'q' to exit");
                    quit = Console.ReadLine();
                } while (quit != "q");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"{e.StackTrace}.\n Try again:");
                makeCalculation();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"{e.Message}.\n Try again:");
                makeCalculation();
            }            
            catch (FormatException e)
            {
                Console.WriteLine($"{e.Message}.\n Try again:");
                makeCalculation();
            }
        }
        // If q, quit
        public static void quitRequest(string str)
        {
            if (str.Equals("q"))
            {
                Console.WriteLine("Pressed q, quitting");
                System.Environment.Exit(1);
            }
        }
    }
}
