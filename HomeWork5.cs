using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgHW
{
    internal static class HomeWork5
    {
        private static Random rnd = new Random();
        internal static void DoTask1()
        {
            Console.WriteLine("Задача 1");

        }
        internal static void DoTask2()
        {
            Console.WriteLine("Задача 2");
            List<int> listSixDigitNumbers = AgFillValues.CreatListRandomFillSixDigitNumber();
            Console.WriteLine("\nНачальный список:");
            foreach (int number in listSixDigitNumbers)
                Console.WriteLine(number);
            Console.WriteLine("\nСписок после удаления нечётных чисел:");
            for (int i = 0; i < listSixDigitNumbers.Count; i++)
            {
                if (listSixDigitNumbers[i] % 2 != 0)
                {
                    listSixDigitNumbers.RemoveAt(i);
                    i--;
                }
            }
            foreach (int number in listSixDigitNumbers)
                Console.WriteLine(number);
        }
        internal static void DoTask3()
        {
            Console.WriteLine("Задача 3");
            List<int> listSixDigitNumbers = AgFillValues.CreatListRandomFillSixDigitNumber();
            Console.WriteLine("\nНачальный список:");
            foreach (int number in listSixDigitNumbers)
                Console.WriteLine(number);
            int digit = AgGetInput.GetDigit(0, 9, true);
            Console.WriteLine($"\nСписок после удаления чисел, содержащих {digit}:");
            for (int i = 0; i < listSixDigitNumbers.Count; i++)
            {
                if (IsNumberContainsDigit(NumberToListDigits(listSixDigitNumbers[i]), digit))
                {
                    listSixDigitNumbers.RemoveAt(i);
                    i--;
                }
            }
            foreach (int number in listSixDigitNumbers)
                Console.WriteLine(number);
        }
        private static List<int> NumberToListDigits(int number)
        {
            List<int> list = new List<int>();
            while (number > 0)
            {
                list.Add(number % 10);
                number /= 10;
            }
            return list;
        }
        private static bool IsNumberContainsDigit(List<int> number, int digit)
        {
            bool isNumberContainsDigit = (number.Contains(digit)) ? true : false;
            return isNumberContainsDigit;
        }
    }
}
