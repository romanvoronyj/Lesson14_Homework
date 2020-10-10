using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Homework_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            Console.WriteLine("Введіть арифметичну операцію:");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "+":
                    {
                        double res = Calculator.Addition();
                        Console.WriteLine("Результат обчислень = {0}", res);
                        break;
                    }
                case "-":
                    {
                        double res = Calculator.Subtraction();
                        Console.WriteLine("Результат обчислень = {0}", res);
                        break;
                    }
                case "*":
                    {
                        double res = Calculator.Multiplication();
                        Console.WriteLine("Результат обчислень = {0}", res);
                        break;
                    }
                case "/":
                    {
                        double res = Calculator.Division();
                        Console.WriteLine("Результат обчислень = {0}", res);
                        break;
                    }


            }

            Console.ReadKey();
        }
    }
}
