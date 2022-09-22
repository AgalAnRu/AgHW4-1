using System;

namespace AgHW4_1
{
    internal static class HomeWork3
    {
        private static Random rnd = new Random();
        internal static void DoTask1()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine("Вывод цифр 0...9 (используется for)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Вывод чисел 10...1 (используется for)");
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Вывод целых положительных чисел (кратных 3 или 5) до заданного числа (используется for)");
            ushort maxUshot = AgGetInput.GetUint16("заданное число");
            for (int i = 1; i < maxUshot; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}\t- кратно 3");
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}\t- кратно 5");
                }
            }
            Console.WriteLine("Вывод случайного ряда целых чисел");
            Console.WriteLine("Введите границы диапазона:");
            short minValue = AgGetInput.GetInt16("границы диапазона:");
            short maxValue = AgGetInput.GetInt16();
            Console.WriteLine("Введите число повторений:");
            byte numberDice = AgGetInput.GetByte("число повторений:");
            if (minValue > maxValue)
            {
                short val = maxValue;
                maxValue = minValue;
                minValue = val;
            }
            for (int i = 0; i < numberDice; i++)
            {
                Console.WriteLine(rnd.Next(minValue, (maxValue + 1)));
            }
        }
        internal static void DoTask2()
        {
            Console.WriteLine("Задача 2");
        }
        internal static void DoTask3()
        {
            Console.WriteLine("Задача 3");
        }
        internal static void DoTask4()
        {
            Console.WriteLine("Задача 4");
        }

    }
}
