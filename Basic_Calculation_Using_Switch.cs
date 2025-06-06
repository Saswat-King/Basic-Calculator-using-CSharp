using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Using_Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                long res;
                Console.Write("Enter the First Number");
                long num1 = Convert.ToInt64(Console.ReadLine());
                Console.Write("Enter the Second Number");
                long num2 = Convert.ToInt64(Console.ReadLine());
                Console.Write("symbol (/,*,+.-):");
                string symbol = Console.ReadLine();


                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Adittion:" + res);
                        break;

                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("subtraction:" + res);
                        break;

                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiply:" + res);
                        break;

                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }

                Console.ReadLine();
                Console.WriteLine("continue(press y for yes n for no");
                value = Console.ReadLine();
            }

            while (value == "y" || value == "Y");
        }
    }
}




                            