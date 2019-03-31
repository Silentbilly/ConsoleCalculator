using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string signOfOperation;          
            float num1;
            float num2;
            string quit;

            // Повторять вычисления, пока quit не будет равен q. 
            do
            {
                Console.Write("Insert a mathematical sign: '+', '-', '*' or '/': ");
                signOfOperation = Console.ReadLine();

                // Ввести знак операции и вывести ошибку, если введён не знак операции.
                if (signOfOperation == "+" || signOfOperation == "-" || signOfOperation == "*" || signOfOperation == "/")
                {
                    // Ввести значения.
                    Console.WriteLine("Insert number 1");
                    num1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Insert number 2");
                    num2 = float.Parse(Console.ReadLine());

                    Console.Write("{0} {1} {2} = ", num1, signOfOperation, num2);
                    // Посчитать.
                    Calculate(num1, num2, signOfOperation);         
                }
                else
                {
                    Console.WriteLine("Unexpected operation!");
                }
                // Повторить либо выйти. 
                Console.WriteLine("Press any key for repeat. Or 'q' to exit");
                quit = Console.ReadLine();
            } while (quit != "q");
        }
        // Метод калькуляции.
        static void Calculate(float num1, float num2, string operation)
        {
            float expected = 0;
            switch (operation)
            {
                case "+": expected = num1 + num2; break;
                case "-": expected = num1 - num2; break;
                case "*": expected = num1 * num2; break;
                case "/": expected = num1 / num2; break;
            }
            Console.WriteLine(expected);
        }
    }
}