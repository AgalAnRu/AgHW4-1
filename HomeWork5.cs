using System;
using System.Collections.Generic;

namespace AgHW
{
    internal static class HomeWork5
    {
        private static Random rnd = new Random();
        internal static void DoTask1()
        {
            const byte MIN_COUNT_NUMBERS = 1;
            const int MIN_VALUE_TO_FILL = -1000;
            const int MAX_VALUE_TO_FILL = 1000;
            Console.WriteLine("Задача 1");
            byte countNumbers = AgGetInput.GetByte("количество генерируемых чисел", MIN_COUNT_NUMBERS);
            List<int> numbers = CreatListRandomNumbers(MIN_VALUE_TO_FILL, MAX_VALUE_TO_FILL, countNumbers);
            Console.WriteLine("\nНачальный список:");
            PrintAllList(numbers);
            numbers.Sort();
            Console.WriteLine($"Минимальное значение: {numbers[0]}");
            Console.WriteLine($"Максимальное значение: {numbers[numbers.Count - 1]}");
        }
        internal static void DoTask2()
        {
            const int NUMBER_OF_DIGIT = 6;
            Console.WriteLine("Задача 2");
            List<int> listSixDigitNumbers = CreatListRandomFixDigitNumber(NUMBER_OF_DIGIT);
            Console.WriteLine("\nНачальный список:");
            PrintAllList(listSixDigitNumbers);
            Console.WriteLine("\nСписок после удаления нечётных чисел:");
            for (int i = 0; i < listSixDigitNumbers.Count; i++)
            {
                if (listSixDigitNumbers[i] % 2 != 0)
                {
                    listSixDigitNumbers.RemoveAt(i);
                    i--;
                }
            }
            PrintAllList(listSixDigitNumbers);
        }
        internal static void DoTask3()
        {
            const int NUMBER_OF_DIGIT = 6;
            Console.WriteLine("Задача 3");
            List<int> listSixDigitNumbers = CreatListRandomFixDigitNumber(NUMBER_OF_DIGIT);
            Console.WriteLine("\nНачальный список:");
            PrintAllList(listSixDigitNumbers);
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
            PrintAllList(listSixDigitNumbers);
        }
        
        private static List<int> CreatList(byte listMaxLength = 0)
        {
            const int LIST_MIN_LEHGHS = 1;
            if (listMaxLength <= 0)
            {
                listMaxLength = AgGetInput.GetByte("максимальную длину списка", LIST_MIN_LEHGHS);
            }
            List<int> list = new List<int>(listMaxLength);
            return list;
        }
        private static List<int> CreatListRandomNumbers(int minValue = int.MinValue, int maxValue = int.MaxValue, byte listMaxLength = 0)
        {
            const int LIST_MIN_LEHGHS = 1;
            if (listMaxLength <= 0)
            {
                listMaxLength = AgGetInput.GetByte("максимальную длину списка", LIST_MIN_LEHGHS);
            }
            List<int> list = new List<int>(listMaxLength);

            for (int i = 0; i < listMaxLength; i++)
            {
                list.Add(rnd.Next(minValue, maxValue + 1));
            }
            return list;
        }
        private static List<int> CreatListRandomFixDigitNumber(int numberDigits, byte listMaxLength = 0)
        {
            int minValue = (int)Math.Pow(10, numberDigits - 1);
            int maxValue = (int)Math.Pow(10, numberDigits);
            List<int> list = CreatListRandomNumbers(minValue, maxValue, listMaxLength);
            return list;
        }
        private static void PrintAllList(List<int> list)
        {
            string prefix = string.Empty;
            foreach (int i in list)
            {
                prefix = (i < 0) ? "\t" : "\t ";
                Console.WriteLine(prefix + i);
            }
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
