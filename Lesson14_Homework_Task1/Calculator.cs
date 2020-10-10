using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Homework_Task1
{
    static class Calculator
    {
        private static double firstNumber;
        private static double secondNumber;

        static Calculator() //Можливо реалізувати ініціалізцію статичних полів користувачем з консолі?
        {
            firstNumber = 5;
            secondNumber = 10;
        }
        public static double Addition()
        {
            double resultAddition = firstNumber + secondNumber;
            return resultAddition;
        }
        public static double Subtraction()
        {
            double resultSubtraction = firstNumber - secondNumber;
            return resultSubtraction;
        }

        public static double Multiplication()
        {
            double resultMultiplication = firstNumber * secondNumber;
            return resultMultiplication;
        }

        public static double Division()
        {
            double resultDivision = firstNumber / secondNumber;
            return resultDivision;
        }

    }
}