using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14_Homework_Task5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть кількість елементів масиву:");
            int elementsQty = Int32.Parse(Console.ReadLine());

            int[] array = new int[elementsQty];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введіть {0}-е значення масиву:", i);
                array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Масив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }

            int[] sortArray = IntExtension.IntArraySorting(array[elementsQty]); // як прийняти масив?

            Console.ReadKey();
        }
    }
}
